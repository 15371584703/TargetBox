using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Global.BasePath = AppDomain.CurrentDomain.BaseDirectory + "..\\data\\";
            Global.ResourcePath = Global.BasePath + "Resource\\";
            Global.SettingsPath = Global.BasePath + "Settings\\";
            Global.TargetImagesPath = Global.BasePath + "TargetImages\\";

            DataManager.Init();

            Application.Run(new Mainform());
        }
    }
}
