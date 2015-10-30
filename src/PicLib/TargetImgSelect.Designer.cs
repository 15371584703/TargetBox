namespace PicLib
{
    partial class TargetImgSelect
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.lable_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(102, 364);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(70, 34);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确认";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(187, 364);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 34);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Location = new System.Drawing.Point(69, 34);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(220, 325);
            this.ImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgBox.TabIndex = 2;
            this.ImgBox.TabStop = false;
            this.ImgBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgBox_MouseDown);
            this.ImgBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgBox_MouseUp);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(296, 159);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(50, 77);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "下一个";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(12, 159);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(50, 77);
            this.btn_previous.TabIndex = 4;
            this.btn_previous.Text = "上一个";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // lable_name
            // 
            this.lable_name.BackColor = System.Drawing.Color.Transparent;
            this.lable_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lable_name.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lable_name.Location = new System.Drawing.Point(0, 0);
            this.lable_name.Name = "lable_name";
            this.lable_name.Size = new System.Drawing.Size(361, 31);
            this.lable_name.TabIndex = 5;
            this.lable_name.Text = "靶子";
            this.lable_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TargetImgSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 400);
            this.Controls.Add(this.lable_name);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.ImgBox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TargetImgSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TargetImgSelect";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Label lable_name;
    }
}