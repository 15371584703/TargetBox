using DataBean;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// 数据维护
    /// </summary>
    public class DataManager
    {

        private static DataManager _Instance;

        static DataManager()
        {
            _Instance = null;
        }

        private DataManager()
        {
        }

        public static DataManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    throw new Exception("DataManager Not Initialized");
                }

                return _Instance;
            }
        }

        #region 数据仓储
        private static List<TargetImg> TargetImgList = null;
        #endregion


        public static void Init()
        {
            _Instance = new DataManager();
            LoadTargetList();
        }

        private static void LoadTargetList()
        {
            //加载靶标
            DirectoryInfo dir = new DirectoryInfo(Global.TargetImagesPath + "Targets\\");
            FileInfo[] files = dir.GetFiles("*.png");
            if (files.Length > 0)
            {
                TargetImgList = new List<TargetImg>();//创建
                foreach (FileInfo file in files)
                {
                    TargetImg targetimg = new TargetImg();
                    targetimg.TargetName = file.Name.Split('.')[0];
                    targetimg.FilePath = file.FullName.ToString();

                    TargetImgList.Add(targetimg);
                }
            }
            else
            {
                throw new Exception("There is no Targets!");
            }
        }

        public static List<TargetImg> GetTargetImgList()
        {
            return TargetImgList;
        }



    }
}
