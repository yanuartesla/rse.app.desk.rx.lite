using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rse.app.desk.rx.pharmacist.Functions
{
    class SavePDF
    {

        public static void SavedPDF(LocalReport viewer, string savePath)

        {
            byte[] Bytes = viewer.Render(format: "PDF", deviceInfo: "");

            Directory.CreateDirectory(Path.GetDirectoryName(savePath));

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }




        //public static void SavedPDF(ReportViewer viewer, string savePath)

        //{
        //    byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

        //    Directory.CreateDirectory(Path.GetDirectoryName(savePath));

        //    using (FileStream stream = new FileStream(savePath, FileMode.Create))
        //    {
        //        stream.Write(Bytes, 0, Bytes.Length);
        //    }
        //}
    }
}
