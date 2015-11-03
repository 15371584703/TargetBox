using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBean
{
    public enum BoxState
    {
        [Description("离线")]
        OffLine = 0,
        [Description("在线")]
        OnLine  = 1
    }
    /// <summary>
    /// 靶箱
    /// </summary>
    public class TargetBox
    {
        //靶箱编号
        public int Number { get; set; }
        //靶箱状态
        public BoxState State { get; set; }
        //靶标
        public TargetImg BoxImg{ get;set; }
        //靶箱的设置
        public BoxSettings Settings { get; set; }
        //命中点
        public List<HitCoordinates> HitList;


        public TargetBox(int number) 
        {
            this.Number = number;
        }

    }
}
