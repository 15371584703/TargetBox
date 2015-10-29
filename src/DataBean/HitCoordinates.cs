using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DataBean
{
    /// <summary>
    /// 命中点
    /// </summary>
    public class HitCoordinates
    {
        /// <summary>
        /// 原生点
        /// </summary>
        public PointF OriginPoint { get; set; }
        /// <summary>
        /// 变换后的点
        /// </summary>
        public PointF Transform { get; }
        /// <summary>
        /// 是否命中
        /// </summary>
        public int OnTarget { get; set; }
        /// <summary>
        /// 命中时间
        /// </summary>
        public DateTime time { get; set; }
        
    }
}
