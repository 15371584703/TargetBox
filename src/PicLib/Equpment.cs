using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBean;
using Logic;
using Utils;

namespace PicLib
{
    public partial class Equpment : BaseContorl
    {
        private TargetImgSelect targetImgselect = null;
        public Equpment()
        {
            InitializeComponent();
            targetImgselect = new TargetImgSelect(DataManager.GetTargetImgList());
        }

        //双击切换靶标
        private void TargetImg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            targetImgselect.TransferDataEvent += new TargetImgSelect.TransferDataDelegate(GetTargetEvent);//订阅事件
            targetImgselect.ShowDialog();
        }

        void GetTargetEvent(TargetImg obj)
        {
            if (obj != null)
            {
                //TODO:

                Image i = Image.FromFile(obj.FilePath);
                PicBox_TargetImg.Image = i;
                PicBox_TargetImg.SizeMode = PictureBoxSizeMode.Zoom;
                lable_TargetName.Text = obj.TargetName;
            }
        }
    }
}
