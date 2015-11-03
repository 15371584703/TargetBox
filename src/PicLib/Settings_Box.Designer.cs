namespace PicLib
{
    partial class Settings_Box
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
            this.panel_Target = new System.Windows.Forms.Panel();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.lable_name = new System.Windows.Forms.Label();
            this.panel_settings = new System.Windows.Forms.Panel();
            this.panel_Target.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Target
            // 
            this.panel_Target.Controls.Add(this.ImgBox);
            this.panel_Target.Controls.Add(this.lable_name);
            this.panel_Target.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Target.Location = new System.Drawing.Point(0, 0);
            this.panel_Target.Name = "panel_Target";
            this.panel_Target.Size = new System.Drawing.Size(189, 486);
            this.panel_Target.TabIndex = 0;
            // 
            // ImgBox
            // 
            this.ImgBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgBox.Location = new System.Drawing.Point(0, 31);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(189, 455);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBox.TabIndex = 7;
            this.ImgBox.TabStop = false;
            // 
            // lable_name
            // 
            this.lable_name.BackColor = System.Drawing.Color.Transparent;
            this.lable_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_name.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_name.Location = new System.Drawing.Point(0, 0);
            this.lable_name.Name = "lable_name";
            this.lable_name.Size = new System.Drawing.Size(189, 31);
            this.lable_name.TabIndex = 6;
            this.lable_name.Text = "靶标";
            this.lable_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_settings
            // 
            this.panel_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_settings.Location = new System.Drawing.Point(593, 0);
            this.panel_settings.Name = "panel_settings";
            this.panel_settings.Size = new System.Drawing.Size(179, 486);
            this.panel_settings.TabIndex = 1;
            // 
            // Settings_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 486);
            this.Controls.Add(this.panel_settings);
            this.Controls.Add(this.panel_Target);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_Box";
            this.Text = "Settings";
            this.panel_Target.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Target;
        private System.Windows.Forms.Panel panel_settings;
        private System.Windows.Forms.Label lable_name;
        private System.Windows.Forms.PictureBox ImgBox;
    }
}