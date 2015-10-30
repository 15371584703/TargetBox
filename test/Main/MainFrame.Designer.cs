namespace Main
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equpment10 = new PicLib.Equpment();
            this.equpment9 = new PicLib.Equpment();
            this.equpment8 = new PicLib.Equpment();
            this.equpment7 = new PicLib.Equpment();
            this.equpment6 = new PicLib.Equpment();
            this.equpment5 = new PicLib.Equpment();
            this.equpment4 = new PicLib.Equpment();
            this.equpment3 = new PicLib.Equpment();
            this.equpment2 = new PicLib.Equpment();
            this.equpment1 = new PicLib.Equpment();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_Content.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.btn_min);
            this.panel_top.Controls.Add(this.btn_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1400, 28);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainform_MouseDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("SimHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "射击训练分析系统V1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_min
            // 
            this.btn_min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.Location = new System.Drawing.Point(1350, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(24, 26);
            this.btn_min.TabIndex = 1;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1374, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 26);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Controls.Add(this.panel_Content);
            this.panel_main.Controls.Add(this.panel_bottom);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 28);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1400, 772);
            this.panel_main.TabIndex = 1;
            // 
            // panel_Content
            // 
            this.panel_Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Content.Controls.Add(this.tabs);
            this.panel_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Content.Location = new System.Drawing.Point(0, 0);
            this.panel_Content.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(1396, 748);
            this.panel_Content.TabIndex = 1;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1394, 746);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1386, 716);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "设备";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.equpment10, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.equpment9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.equpment8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.equpment7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.equpment6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.equpment5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.equpment4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.equpment3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.equpment2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.equpment1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 712);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equpment10
            // 
            this.equpment10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment10.Location = new System.Drawing.Point(1109, 361);
            this.equpment10.Margin = new System.Windows.Forms.Padding(5);
            this.equpment10.Name = "equpment10";
            this.equpment10.Size = new System.Drawing.Size(268, 346);
            this.equpment10.TabIndex = 9;
            // 
            // equpment9
            // 
            this.equpment9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment9.Location = new System.Drawing.Point(833, 361);
            this.equpment9.Margin = new System.Windows.Forms.Padding(5);
            this.equpment9.Name = "equpment9";
            this.equpment9.Size = new System.Drawing.Size(266, 346);
            this.equpment9.TabIndex = 8;
            // 
            // equpment8
            // 
            this.equpment8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment8.Location = new System.Drawing.Point(557, 361);
            this.equpment8.Margin = new System.Windows.Forms.Padding(5);
            this.equpment8.Name = "equpment8";
            this.equpment8.Size = new System.Drawing.Size(266, 346);
            this.equpment8.TabIndex = 7;
            // 
            // equpment7
            // 
            this.equpment7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment7.Location = new System.Drawing.Point(281, 361);
            this.equpment7.Margin = new System.Windows.Forms.Padding(5);
            this.equpment7.Name = "equpment7";
            this.equpment7.Size = new System.Drawing.Size(266, 346);
            this.equpment7.TabIndex = 6;
            // 
            // equpment6
            // 
            this.equpment6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment6.Location = new System.Drawing.Point(5, 361);
            this.equpment6.Margin = new System.Windows.Forms.Padding(5);
            this.equpment6.Name = "equpment6";
            this.equpment6.Size = new System.Drawing.Size(266, 346);
            this.equpment6.TabIndex = 5;
            // 
            // equpment5
            // 
            this.equpment5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment5.Location = new System.Drawing.Point(1109, 5);
            this.equpment5.Margin = new System.Windows.Forms.Padding(5);
            this.equpment5.Name = "equpment5";
            this.equpment5.Size = new System.Drawing.Size(268, 346);
            this.equpment5.TabIndex = 4;
            // 
            // equpment4
            // 
            this.equpment4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment4.Location = new System.Drawing.Point(833, 5);
            this.equpment4.Margin = new System.Windows.Forms.Padding(5);
            this.equpment4.Name = "equpment4";
            this.equpment4.Size = new System.Drawing.Size(266, 346);
            this.equpment4.TabIndex = 3;
            // 
            // equpment3
            // 
            this.equpment3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment3.Location = new System.Drawing.Point(557, 5);
            this.equpment3.Margin = new System.Windows.Forms.Padding(5);
            this.equpment3.Name = "equpment3";
            this.equpment3.Size = new System.Drawing.Size(266, 346);
            this.equpment3.TabIndex = 2;
            // 
            // equpment2
            // 
            this.equpment2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment2.Location = new System.Drawing.Point(281, 5);
            this.equpment2.Margin = new System.Windows.Forms.Padding(5);
            this.equpment2.Name = "equpment2";
            this.equpment2.Size = new System.Drawing.Size(266, 346);
            this.equpment2.TabIndex = 1;
            // 
            // equpment1
            // 
            this.equpment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equpment1.Location = new System.Drawing.Point(4, 4);
            this.equpment1.Margin = new System.Windows.Forms.Padding(4);
            this.equpment1.Name = "equpment1";
            this.equpment1.Size = new System.Drawing.Size(268, 348);
            this.equpment1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1386, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "训练";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1386, 716);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "系统";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1386, 716);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "关于";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 748);
            this.panel_bottom.Margin = new System.Windows.Forms.Padding(2);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1396, 20);
            this.panel_bottom.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_top.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_Content.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private PicLib.Equpment equpment1;
        private PicLib.Equpment equpment10;
        private PicLib.Equpment equpment9;
        private PicLib.Equpment equpment8;
        private PicLib.Equpment equpment7;
        private PicLib.Equpment equpment6;
        private PicLib.Equpment equpment5;
        private PicLib.Equpment equpment4;
        private PicLib.Equpment equpment3;
        private PicLib.Equpment equpment2;
    }
}