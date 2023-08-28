using InsuranceSummaryMaker.CustomControls.CustomMessageBox;
using System;
using System.IO;
using System.Windows.Forms;

namespace PolicyCreator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (args.Length > 0)
            {
                string urlPath = args[0];

                if (checkValidUrl(urlPath))
                {

                    Application.Run(new InsuranceSummaryMaker.PolicyCreator(urlPath, Path.GetFileName(urlPath)));
                    return;
                }


            }

            using (NewOpenMessageBox message = new NewOpenMessageBox())
            {
                if (message.ShowDialog() == DialogResult.OK)
                {
                    string fileOpenPath = message.openpath;
                    string fileName = message.fileName;
                    Application.Run(new InsuranceSummaryMaker.PolicyCreator(fileOpenPath, fileName));

                }
                else
                {
                    Application.Run(new InsuranceSummaryMaker.PolicyCreator());

                }
            }
        }



        private static bool checkValidUrl(string urlPath)
        {
            return urlPath != null && File.Exists(urlPath);
        }
    }
}
