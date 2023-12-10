
namespace Tyuiu.AgafonovKS.Sprint6.Task7.V16
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_AKS = new System.Windows.Forms.PictureBox();
            this.labelInfo_AKS = new System.Windows.Forms.Label();
            this.buttonOk_AKS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_AKS
            // 
            this.pictureBoxAvatar_AKS.ImageLocation = "C:\\Users\\Kirya\\source\\repos\\Tyuiu.AgafonovKS.Sprint6\\Avatar.jpg";
            this.pictureBoxAvatar_AKS.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxAvatar_AKS.Name = "pictureBoxAvatar_AKS";
            this.pictureBoxAvatar_AKS.Size = new System.Drawing.Size(150, 200);
            this.pictureBoxAvatar_AKS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_AKS.TabIndex = 0;
            this.pictureBoxAvatar_AKS.TabStop = false;
            // 
            // labelInfo_AKS
            // 
            this.labelInfo_AKS.AutoSize = true;
            this.labelInfo_AKS.Location = new System.Drawing.Point(168, 9);
            this.labelInfo_AKS.Name = "labelInfo_AKS";
            this.labelInfo_AKS.Size = new System.Drawing.Size(366, 153);
            this.labelInfo_AKS.TabIndex = 1;
            this.labelInfo_AKS.Text = resources.GetString("labelInfo_AKS.Text");
            // 
            // buttonOk_AKS
            // 
            this.buttonOk_AKS.Location = new System.Drawing.Point(384, 190);
            this.buttonOk_AKS.Name = "buttonOk_AKS";
            this.buttonOk_AKS.Size = new System.Drawing.Size(150, 50);
            this.buttonOk_AKS.TabIndex = 2;
            this.buttonOk_AKS.Text = "OK";
            this.buttonOk_AKS.UseVisualStyleBackColor = true;
            this.buttonOk_AKS.Click += new System.EventHandler(this.buttonOk_AKS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 253);
            this.Controls.Add(this.buttonOk_AKS);
            this.Controls.Add(this.labelInfo_AKS);
            this.Controls.Add(this.pictureBoxAvatar_AKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_AKS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_AKS;
        private System.Windows.Forms.Label labelInfo_AKS;
        private System.Windows.Forms.Button buttonOk_AKS;
    }
}