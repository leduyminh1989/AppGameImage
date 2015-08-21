namespace ImageTest
{
    partial class Form1
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
            this.btnClick = new System.Windows.Forms.Button();
            this.linkImage1 = new System.Windows.Forms.LinkLabel();
            this.linkImage2 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.lblIma1 = new System.Windows.Forms.Label();
            this.lblIma2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(16, 59);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // linkImage1
            // 
            this.linkImage1.AutoSize = true;
            this.linkImage1.Location = new System.Drawing.Point(13, 13);
            this.linkImage1.Name = "linkImage1";
            this.linkImage1.Size = new System.Drawing.Size(78, 13);
            this.linkImage1.TabIndex = 1;
            this.linkImage1.TabStop = true;
            this.linkImage1.Text = "Select Image 1";
            this.linkImage1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImage1_LinkClicked);
            // 
            // linkImage2
            // 
            this.linkImage2.AutoSize = true;
            this.linkImage2.Location = new System.Drawing.Point(13, 33);
            this.linkImage2.Name = "linkImage2";
            this.linkImage2.Size = new System.Drawing.Size(78, 13);
            this.linkImage2.TabIndex = 2;
            this.linkImage2.TabStop = true;
            this.linkImage2.Text = "Select Image 2";
            this.linkImage2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImage2_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(16, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(512, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(16, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 350);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // lblIma1
            // 
            this.lblIma1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIma1.AutoSize = true;
            this.lblIma1.Location = new System.Drawing.Point(97, 13);
            this.lblIma1.Name = "lblIma1";
            this.lblIma1.Size = new System.Drawing.Size(23, 13);
            this.lblIma1.TabIndex = 5;
            this.lblIma1.Text = "null";
            // 
            // lblIma2
            // 
            this.lblIma2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIma2.AutoSize = true;
            this.lblIma2.Location = new System.Drawing.Point(97, 33);
            this.lblIma2.Name = "lblIma2";
            this.lblIma2.Size = new System.Drawing.Size(23, 13);
            this.lblIma2.TabIndex = 6;
            this.lblIma2.Text = "null";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 486);
            this.Controls.Add(this.lblIma2);
            this.Controls.Add(this.lblIma1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkImage2);
            this.Controls.Add(this.linkImage1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.LinkLabel linkImage1;
        private System.Windows.Forms.LinkLabel linkImage2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label lblIma1;
        private System.Windows.Forms.Label lblIma2;
    }
}

