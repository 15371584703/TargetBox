namespace PicLib
{
    partial class Equpment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBox_TargetImg = new System.Windows.Forms.PictureBox();
            this.panel_Name = new System.Windows.Forms.Panel();
            this.lable_TargetName = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.rb_Baterry = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TargetImg)).BeginInit();
            this.panel_Name.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox_TargetImg
            // 
            this.PicBox_TargetImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox_TargetImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox_TargetImg.Location = new System.Drawing.Point(0, 0);
            this.PicBox_TargetImg.Name = "PicBox_TargetImg";
            this.PicBox_TargetImg.Size = new System.Drawing.Size(205, 318);
            this.PicBox_TargetImg.TabIndex = 0;
            this.PicBox_TargetImg.TabStop = false;
            this.PicBox_TargetImg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TargetImg_MouseDoubleClick);
            // 
            // panel_Name
            // 
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.lable_TargetName);
            this.panel_Name.Controls.Add(this.panel2);
            this.panel_Name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Name.Location = new System.Drawing.Point(0, 318);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(270, 32);
            this.panel_Name.TabIndex = 1;
            // 
            // lable_TargetName
            // 
            this.lable_TargetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lable_TargetName.Location = new System.Drawing.Point(0, 0);
            this.lable_TargetName.Name = "lable_TargetName";
            this.lable_TargetName.Size = new System.Drawing.Size(204, 30);
            this.lable_TargetName.TabIndex = 0;
            this.lable_TargetName.Text = "A";
            this.lable_TargetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_status
            // 
            this.panel_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_status.Controls.Add(this.rb_Baterry);
            this.panel_status.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_status.Location = new System.Drawing.Point(205, 0);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(65, 318);
            this.panel_status.TabIndex = 2;
            // 
            // rb_Baterry
            // 
            this.rb_Baterry.Location = new System.Drawing.Point(5, 22);
            this.rb_Baterry.Name = "rb_Baterry";
            this.rb_Baterry.Size = new System.Drawing.Size(55, 34);
            this.rb_Baterry.TabIndex = 0;
            this.rb_Baterry.TabStop = true;
            this.rb_Baterry.Text = "启用状态";
            this.rb_Baterry.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicBox_TargetImg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 318);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 30);
            this.panel2.TabIndex = 0;
            // 
            // Equpment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel_Name);
            this.Name = "Equpment";
            this.Size = new System.Drawing.Size(270, 350);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TargetImg)).EndInit();
            this.panel_Name.ResumeLayout(false);
            this.panel_status.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_TargetImg;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.RadioButton rb_Baterry;
        private System.Windows.Forms.Label lable_TargetName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
