namespace Tyuiu.AgafonovKS.Sprint6.Task3.V15
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_AKS = new System.Windows.Forms.GroupBox();
            this.groupBoxResult_AKS = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.textBoxOutput_AKS = new System.Windows.Forms.TextBox();
            this.buttonResult_AKS = new System.Windows.Forms.Button();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_AKS = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_AKS.SuspendLayout();
            this.groupBoxResult_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_AKS
            // 
            this.groupBoxTask_AKS.Controls.Add(this.textBoxTask);
            this.groupBoxTask_AKS.Location = new System.Drawing.Point(15, 10);
            this.groupBoxTask_AKS.Name = "groupBoxTask_AKS";
            this.groupBoxTask_AKS.Size = new System.Drawing.Size(315, 278);
            this.groupBoxTask_AKS.TabIndex = 0;
            this.groupBoxTask_AKS.TabStop = false;
            this.groupBoxTask_AKS.Text = "Условие";
            // 
            // groupBoxResult_AKS
            // 
            this.groupBoxResult_AKS.Controls.Add(this.dataGridViewMatrix_AKS);
            this.groupBoxResult_AKS.Controls.Add(this.textBoxOutput_AKS);
            this.groupBoxResult_AKS.Location = new System.Drawing.Point(336, 10);
            this.groupBoxResult_AKS.Name = "groupBoxResult_AKS";
            this.groupBoxResult_AKS.Size = new System.Drawing.Size(452, 232);
            this.groupBoxResult_AKS.TabIndex = 1;
            this.groupBoxResult_AKS.TabStop = false;
            this.groupBoxResult_AKS.Text = "Вывод данных";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(14, 29);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(285, 203);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // textBoxOutput_AKS
            // 
            this.textBoxOutput_AKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput_AKS.Location = new System.Drawing.Point(13, 28);
            this.textBoxOutput_AKS.Name = "textBoxOutput_AKS";
            this.textBoxOutput_AKS.ReadOnly = true;
            this.textBoxOutput_AKS.Size = new System.Drawing.Size(136, 13);
            this.textBoxOutput_AKS.TabIndex = 0;
            this.textBoxOutput_AKS.TabStop = false;
            this.textBoxOutput_AKS.Text = "Результат:";
            // 
            // buttonResult_AKS
            // 
            this.buttonResult_AKS.Location = new System.Drawing.Point(679, 250);
            this.buttonResult_AKS.Name = "buttonResult_AKS";
            this.buttonResult_AKS.Size = new System.Drawing.Size(109, 38);
            this.buttonResult_AKS.TabIndex = 2;
            this.buttonResult_AKS.Text = "Выполнить";
            this.buttonResult_AKS.UseVisualStyleBackColor = true;
            this.buttonResult_AKS.Click += new System.EventHandler(this.buttonResult_AKS_Click);
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.Location = new System.Drawing.Point(336, 250);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(67, 38);
            this.buttonHelp_AKS.TabIndex = 3;
            this.buttonHelp_AKS.Text = "?";
            this.buttonHelp_AKS.UseVisualStyleBackColor = true;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            // 
            // dataGridViewMatrix_AKS
            // 
            this.dataGridViewMatrix_AKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_AKS.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_AKS.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewMatrix_AKS.Name = "dataGridViewMatrix_AKS";
            this.dataGridViewMatrix_AKS.ReadOnly = true;
            this.dataGridViewMatrix_AKS.RowHeadersVisible = false;
            this.dataGridViewMatrix_AKS.Size = new System.Drawing.Size(426, 173);
            this.dataGridViewMatrix_AKS.TabIndex = 1;
            this.dataGridViewMatrix_AKS.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_AKS);
            this.Controls.Add(this.buttonResult_AKS);
            this.Controls.Add(this.groupBoxResult_AKS);
            this.Controls.Add(this.groupBoxTask_AKS);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 15 | Агафонов К. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.PerformLayout();
            this.groupBoxResult_AKS.ResumeLayout(false);
            this.groupBoxResult_AKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_AKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_AKS;
        private System.Windows.Forms.GroupBox groupBoxResult_AKS;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxOutput_AKS;
        private System.Windows.Forms.Button buttonResult_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_AKS;
    }
}

