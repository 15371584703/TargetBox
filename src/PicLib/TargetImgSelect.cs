using DataBean;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicLib
{
    public partial class TargetImgSelect : Form
    {
        private List<TargetImg> DataList = null;
        private int Index = 0;
        public TargetImgSelect(List<TargetImg> list)
        {
            InitializeComponent();

            if (list != null)
            {
                DataList = list;
                ShowImage(0);
            }
        }

        private void ShowImage(int index) 
        {
            //显示名称
            lable_name.Text = DataList[index].TargetName;
            //显示图片
            ImgBox.Image = Image.FromFile(DataList[index].FilePath);
            ImgBox.SizeMode = PictureBoxSizeMode.Zoom;
        }


        //下一个
        private void btn_Next_Click(object sender, EventArgs e)
        {
            Index += 1;
            if (Index >= DataList.Count)
            {
                Index = 0;
            }
            ShowImage(Index);
        }
        //上一个
        private void btn_previous_Click(object sender, EventArgs e)
        {
            Index -= 1;
            if (Index <= 0)
            {
                Index = DataList.Count - 1;
            }
            ShowImage(Index);
        }
        //取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //确认
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Hand();
            this.Close();
        }

        #region 传递值到form
        //定义委托
        public delegate void TransferDataDelegate(TargetImg obj);
        //事件变量
        public event TransferDataDelegate TransferDataEvent;            
        //事件激发函数
        private void Hand()
        {
            TransferDataEvent(DataList[Index]);
        }
        #endregion


        #region 手势滑动切换图片
        private float downX = 0;
        private void ImgBox_MouseDown(object sender, MouseEventArgs e)
        {
            downX = e.X;
        }

        private void ImgBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.X - downX > 0)
            {
                btn_Next_Click(sender, new EventArgs());
            }
            else
            { 
                btn_previous_Click(sender, new EventArgs());
            }
        }
        #endregion





    }
}
