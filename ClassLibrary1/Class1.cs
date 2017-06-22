using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.ApplicationServices;
using System.IO;

namespace 桩建模
{
    public class 桩建模 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            string s = "FINISH\r\n/CLEAR\r\n/PREP7\r\n";
            UIApplication rvtUiApp = commandData.Application;
            Application rvtApp = rvtUiApp.Application;
            UIDocument rvtUiDoc = rvtUiApp.ActiveUIDocument;
            Document rvtDoc = rvtUiDoc.Document;

            ICollection<ElementId> listWall1 = rvtUiDoc.Selection.GetElementIds();
            foreach(ElementId elemID in listWall1)
            {

            }
            using (FileStream fswrite = new FileStream(@"D: \ansysAPDLZhuang.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                byte[] buffer = Encoding.Default.GetBytes(s);
                fswrite.Write(buffer, 0, buffer.Length);
            }
            TaskDialog.Show("Revit", s);
            return Result.Succeeded;
        }
    }
}
