using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicLib
{
    public partial class Selecter : BaseContorl
    {
        private Rectangle rect;
        private Graphics g;

        public Selecter()
        {
            InitializeComponent();
            //rect = new Rectangle(0, 0, this.panel_content.Width, this.panel_content.Height);
            g = this.CreateGraphics();//this.panel_content.CreateGraphics();
            Font f ;//= new System.Drawing.Font("SimSun", 12F);
            f = new Font("楷体GB-2312", 25, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.LawnGreen);
            g.DrawString("A", f, brush, 200, 15);
            g.DrawString("B", f, brush, 200, 40);
            g.DrawString("C", f, brush, 200, 55);

        }

        private void panel_content_MouseMove(object sender, MouseEventArgs e)
        {
            //rect.Contains(e.X, e.Y);
        }

        #region 
        private float StartX = 0;
        private float StartY = 0;

        private void panel_content_MouseDown(object sender, MouseEventArgs e)
        {
            StartX = e.X;
            StartY = e.Y;
        }

        private void panel_content_MouseUp(object sender, MouseEventArgs e)
        {

        }
        #endregion

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;

        }

        private void Selecter_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            Font f;
            f = new Font("楷体GB-2312", 25, FontStyle.Bold);

            Brush brush = new SolidBrush(Color.LawnGreen);
            g.DrawString("A", f, brush, 5, 15);
            g.DrawString("B", f, brush, 5, 40);
            g.DrawString("C", f, brush, 5, 55);
        }
    }
}
