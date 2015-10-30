using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBean
{
    /// <summary>
    /// 靶纸
    /// </summary>
    public class TargetImg
    {
        public String TargetName { get; set; }
        public String FilePath { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Image currentImg { get; set; }


    }
}
