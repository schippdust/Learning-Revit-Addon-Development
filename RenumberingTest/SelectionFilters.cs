using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenumberingTest
{
    public class RoomPickFilter : ISelectionFilter
    {
        public bool AllowElement(Element elem)
        {
            Type elementType = elem.GetType();
            if (elem.Category == null)
            {
                return false;
            }
            else
            {
                return (elem.Category.Id.IntegerValue.Equals((int)BuiltInCategory.OST_Rooms));
            }

        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
