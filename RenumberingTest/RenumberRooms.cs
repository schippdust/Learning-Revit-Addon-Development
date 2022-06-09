#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI.Selection;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
#endregion

namespace RenumberingTest
{
    

    [Transaction(TransactionMode.Manual)]
    public class RenumberRooms : IExternalCommand
    {
        #region Declarations
        private UIApplication uiapp;
        private UIDocument uidoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;

        private int currentNumber = 0;
        private string renumberPrefix = "";
        private int renumberInc = 1;
        private bool continueSelecting = true;

        RenumberRoomsForm form = null;
        #endregion

        Dictionary<string, List<Room>> CreateRoomNumberDictionary()
        {
            Dictionary<string, List<Room>> roomDict = new Dictionary<string, List<Room>>();
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.WhereElementIsNotElementType().OfCategory(BuiltInCategory.OST_Rooms);
            IList<Element> allRooms = collector.ToElements();
            foreach (Room r in allRooms)
            {
                string roomNumber = r.Number;
                bool keyExists = roomDict.ContainsKey(roomNumber);

                if (!keyExists)
                {
                    List<Room> roomList = new List<Room>();
                    roomDict.Add(roomNumber, roomList);
                }
                
                List<Room> targetList = roomDict[roomNumber];
                targetList.Add(r);
            }

            return roomDict;

        }

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            #region Setup Logic
            uiapp = commandData.Application;
            uidoc = uiapp.ActiveUIDocument;
            app = uiapp.Application;
            doc = uidoc.Document;

            //set up form to ask for user information
            form = new RenumberRoomsForm(commandData);
            form.ShowDialog();

            //grab values from Form
            renumberPrefix = form.renumberPrefix;
            currentNumber = form.renumberStart;
            renumberInc = form.renumberInc;
            int devRenumberSteps = 3;
            int devCurrentStep = 1;

            Room selectedRoom;

            #endregion

            while(continueSelecting)
            {
                #region Iterative Transactions
                //having the user click to identify rooms to renumber based on set parameters
                using (TransactionGroup transGroup = new TransactionGroup(doc))
                {
                    using (Transaction trans = new Transaction(doc))
                    {
                        try
                        {
                            transGroup.Start("Renumbered Rooms");
                            trans.Start("Part One");

                            RoomPickFilter selFilter = new RoomPickFilter();
                            Reference pickedref = null;
                            Selection sel = uiapp.ActiveUIDocument.Selection;
                            pickedref = sel.PickObject(ObjectType.Element, selFilter, "Select a Room to Renumber");
                            Element elem = doc.GetElement(pickedref);
                            selectedRoom = elem as Room;

                            //populating dictionary of rooms by room number for quick reference when renumbering
                            Dictionary<string, List<Room>> roomDict = CreateRoomNumberDictionary();
                            //string currentRoomNumber = selectedRoom.Number;
                            bool numberExists = roomDict.ContainsKey(String.Concat(renumberPrefix, currentNumber));
                            if (numberExists)
                            {
                                string addPrefix = "_";
                                foreach (Room r in roomDict[String.Concat(renumberPrefix, currentNumber)])
                                {
                                    string roomNumber = r.Number;

                                    while (roomDict.ContainsKey(roomNumber))
                                    {
                                        roomNumber = addPrefix + roomNumber;
                                    }
                                    r.Number = roomNumber;
                                    List<Room> newRoomList = new List<Room>();
                                    newRoomList.Add(r);
                                    roomDict.Add(roomNumber, newRoomList);
                                }
                            }

                            if (trans.Commit() != TransactionStatus.Committed)
                            {
                                return Result.Failed;
                            }

                            trans.Start("Part Two");
                            selectedRoom.Number = String.Concat(renumberPrefix, currentNumber);

                            if (trans.Commit() != TransactionStatus.Committed)
                            {
                                return Result.Failed;
                            }

                            transGroup.Assimilate();
                        }
                        catch (Autodesk.Revit.Exceptions.OperationCanceledException)
                        {
                            continueSelecting = false;
                            transGroup.Assimilate();
                            return Result.Succeeded;
                        }
                        catch
                        {
                            continueSelecting = false;
                            return Result.Failed;
                        }
                    }

                }
                #endregion
                devCurrentStep += 1;
                currentNumber += renumberInc;
            }
            
            

            

            return Result.Succeeded;
        }
    }
}
