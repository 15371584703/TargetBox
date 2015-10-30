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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_status = new System.Windows.Forms.Panel();
            this.rb_Baterry = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TargetImg)).BeginInit();
            this.panel_Name.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicBox_TargetImg
            // 
            this.PicBox_TargetImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBox_TargetImg.Location = new System.Drawing.Point(0, 0);
            this.PicBox_TargetImg.Name = "PicBox_TargetImg";
            this.PicBox_TargetImg.Size = new System.Drawing.Size(205, 315);
            this.PicBox_TargetImg.TabIndex = 0;
            this.PicBox_TargetImg.TabStop = false;
            this.PicBox_TargetImg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TargetImg_MouseDoubleClick);
            // 
            // panel_Name
            // 
            this.panel_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Name.Controls.Add(this.label1);
            this.panel_Name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Name.Location = new System.Drawing.Point(0, 318);
            this.panel_Name.Name = "panel_Name";
            this.panel_Name.Size = new System.Drawing.Size(270, 32);
            this.panel_Name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Equpment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel_Name);
            this.Controls.Add(this.PicBox_TargetImg);
            this.Name = "Equpment";
            this.Size = new System.Drawing.Size(270, 350);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_TargetImg)).EndInit();
            this.panel_Name.ResumeLayout(false);
            this.panel_status.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_TargetImg;
        private System.Windows.Forms.Panel panel_Name;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.RadioButton rb_Baterry;
        private System.Windows.Forms.Label label1;
    }
}
