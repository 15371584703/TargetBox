using Logic;
using PicLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

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
            ValueDictionary.Init(Global.SettingsPath + "ValueDictionary.xml");
            Application.Run(new Mainform());
            //Application.Run(new Settings_Box());
        }
    }
}
