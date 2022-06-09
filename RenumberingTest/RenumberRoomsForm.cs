using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace RenumberingTest
{
    
    public partial class RenumberRoomsForm : System.Windows.Forms.Form
    {
        private UIApplication uiapp;
        private UIDocument uidoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;

        public int renumberInc;
        public int renumberStart;
        public string renumberPrefix;

        public RenumberRoomsForm(ExternalCommandData commandData)
        {
            InitializeComponent();

            uiapp = commandData.Application;
            uidoc = uiapp.ActiveUIDocument;
            app = uiapp.Application;
            doc = uidoc.Document;
        }

        private void begin_Click(object sender, EventArgs e)
        {
            renumberInc = Convert.ToInt32(incrementData.Value);
            renumberStart = Convert.ToInt32(startData.Value);
            renumberPrefix = prefixData.Text;

            begin.DialogResult = DialogResult.OK;
            Debug.WriteLine("Okay Button Was Clicked");
            Close();

            return;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            cancel.DialogResult = DialogResult.Cancel;
            Debug.WriteLine("Cancel Button Was Clicked");
        }


        private void prefixData_TextChanged(object sender, EventArgs e)
        {

        }

        private void incrementData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void startData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
