#region Namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

using adWin = Autodesk.Windows;
#endregion



namespace RenumberingTest
{
    public class Availability : IExternalCommandAvailability
    {
        public bool IsCommandAvailable(UIApplication a, CategorySet b)
        {
            return true;
        }
    }

    class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            string assemblyPath = Assembly.GetExecutingAssembly().Location;


            ///////////////////// Creating Dev Testing Ribbon If It Doesn't Exist Yet /////////////////////
            try
            {
                application.CreateRibbonTab("Dev Testing");
            }
            catch
            {
                //nothing happens
            }


            #region Renumber Panel
            ///////////////////// Creating Renumber Panel to Contain Commands /////////////////////
            RibbonPanel renumberPanel;
            try
            {
                renumberPanel = application.CreateRibbonPanel("Dev Testing", "Renumbering");
            }
            catch
            {
                renumberPanel = application.GetRibbonPanels("Dev Testing")
                    .Find(p => p.Name == "Renumbering");
            }

            ///////////////////// Adding Buttons to Renumber Panel /////////////////////
            PushButtonData renumberRoomsButton = new PushButtonData(
                "RenumberRooms", 
                "Renumber Rooms", 
                assemblyPath, 
                "RenumberingTest.RenumberRooms"
                );
            renumberRoomsButton.ToolTip = "Use this tool to quickly renumber rooms using custom settings";
            renumberRoomsButton.AvailabilityClassName = "RenumberingTest.Availability";
            renumberPanel.AddItem(renumberRoomsButton);

            #endregion

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        
    }
}
