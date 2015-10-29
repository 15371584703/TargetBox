using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataBean
{
    /// <summary>
    /// 靶箱的设置内容
    /// </summary>
    public class BoxSettings
    {
        //训练模式
        public String TrainMode;
        //枪械模式 训练模式级联
        //public String GunMode;

        //光照模式
        public String IlluminationType;
        //光照级别
        public int IlluminationLevels;

        //显靶时间
        public int ShowTime;

        //射击模式
        //public int ShootPerTime;
        //靶纸
        //public string Target;
    }
}
