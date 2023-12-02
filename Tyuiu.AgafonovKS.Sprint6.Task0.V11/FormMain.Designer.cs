namespace Tyuiu.AgafonovKS.Sprint6.Task0.V11
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
            this.pictureBoxFormula_AKS = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_AKS = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxInput_AKS = new System.Windows.Forms.GroupBox();
            this.textBoxInput_AKS = new System.Windows.Forms.TextBox();
            this.textBoxVariable_AKS = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AKS = new System.Windows.Forms.TextBox();
            this.textBoxTextResult_AKS = new System.Windows.Forms.TextBox();
            this.buttonResult_AKS = new System.Windows.Forms.Button();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.groupBoxTask_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_AKS)).BeginInit();
            this.groupBoxInput_AKS.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_AKS
            // 
            this.groupBoxTask_AKS.Controls.Add(this.pictureBoxFormula_AKS);
            this.groupBoxTask_AKS.Controls.Add(this.textBoxCondition_AKS);
            this.groupBoxTask_AKS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_AKS.Name = "groupBoxTask_AKS";
            this.groupBoxTask_AKS.Size = new System.Drawing.Size(776, 185);
            this.groupBoxTask_AKS.TabIndex = 0;
            this.groupBoxTask_AKS.TabStop = false;
            this.groupBoxTask_AKS.Text = "Условие";
            // 
            // pictureBoxFormula_AKS
            // 
            this.pictureBoxFormula_AKS.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_AKS.ErrorImage")));
            this.pictureBoxFormula_AKS.ImageLocation = "C:\\Users\\kardv\\source\\repos\\Tyuiu.AgafonovKS.Sprint6\\Formula.png";
            this.pictureBoxFormula_AKS.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_AKS.InitialImage")));
            this.pictureBoxFormula_AKS.Location = new System.Drawing.Point(495, 39);
            this.pictureBoxFormula_AKS.Name = "pictureBoxFormula_AKS";
            this.pictureBoxFormula_AKS.Size = new System.Drawing.Size(258, 100);
            this.pictureBoxFormula_AKS.TabIndex = 1;
            this.pictureBoxFormula_AKS.TabStop = false;
            // 
            // textBoxCondition_AKS
            // 
            this.textBoxCondition_AKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_AKS.Location = new System.Drawing.Point(22, 39);
            this.textBoxCondition_AKS.Multiline = true;
            this.textBoxCondition_AKS.Name = "textBoxCondition_AKS";
            this.textBoxCondition_AKS.ReadOnly = true;
            this.textBoxCondition_AKS.Size = new System.Drawing.Size(385, 100);
            this.textBoxCondition_AKS.TabIndex = 0;
            this.textBoxCondition_AKS.TabStop = false;
            this.textBoxCondition_AKS.Text = "Дано выражение вычислить его значение при x = 2, результат вывести в TextBox. Окр" +
    "углить до трёх знаков после запятой.";
            // 
            // groupBoxInput_AKS
            // 
            this.groupBoxInput_AKS.Controls.Add(this.textBoxInput_AKS);
            this.groupBoxInput_AKS.Controls.Add(this.textBoxVariable_AKS);
            this.groupBoxInput_AKS.Location = new System.Drawing.Point(15, 219);
            this.groupBoxInput_AKS.Name = "groupBoxInput_AKS";
            this.groupBoxInput_AKS.Size = new System.Drawing.Size(371, 170);
            this.groupBoxInput_AKS.TabIndex = 1;
            this.groupBoxInput_AKS.TabStop = false;
            this.groupBoxInput_AKS.Text = "Ввод данных";
            // 
            // textBoxInput_AKS
            // 
            this.textBoxInput_AKS.Location = new System.Drawing.Point(19, 112);
            this.textBoxInput_AKS.Name = "textBoxInput_AKS";
            this.textBoxInput_AKS.Size = new System.Drawing.Size(225, 20);
            this.textBoxInput_AKS.TabIndex = 1;
            // 
            // textBoxVariable_AKS
            // 
            this.textBoxVariable_AKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVariable_AKS.Location = new System.Drawing.Point(19, 61);
            this.textBoxVariable_AKS.Name = "textBoxVariable_AKS";
            this.textBoxVariable_AKS.ReadOnly = true;
            this.textBoxVariable_AKS.Size = new System.Drawing.Size(153, 13);
            this.textBoxVariable_AKS.TabIndex = 0;
            this.textBoxVariable_AKS.TabStop = false;
            this.textBoxVariable_AKS.Text = "Переменная X:";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxResult_AKS);
            this.groupBoxOutput.Controls.Add(this.textBoxTextResult_AKS);
            this.groupBoxOutput.Location = new System.Drawing.Point(415, 227);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(372, 161);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResult_AKS
            // 
            this.textBoxResult_AKS.Location = new System.Drawing.Point(41, 104);
            this.textBoxResult_AKS.Name = "textBoxResult_AKS";
            this.textBoxResult_AKS.ReadOnly = true;
            this.textBoxResult_AKS.Size = new System.Drawing.Size(228, 20);
            this.textBoxResult_AKS.TabIndex = 1;
            // 
            // textBoxTextResult_AKS
            // 
            this.textBoxTextResult_AKS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTextResult_AKS.Location = new System.Drawing.Point(41, 53);
            this.textBoxTextResult_AKS.Name = "textBoxTextResult_AKS";
            this.textBoxTextResult_AKS.ReadOnly = true;
            this.textBoxTextResult_AKS.Size = new System.Drawing.Size(133, 13);
            this.textBoxTextResult_AKS.TabIndex = 0;
            this.textBoxTextResult_AKS.TabStop = false;
            this.textBoxTextResult_AKS.Text = "Результат:";
            // 
            // buttonResult_AKS
            // 
            this.buttonResult_AKS.Location = new System.Drawing.Point(622, 409);
            this.buttonResult_AKS.Name = "buttonResult_AKS";
            this.buttonResult_AKS.Size = new System.Drawing.Size(143, 29);
            this.buttonResult_AKS.TabIndex = 3;
            this.buttonResult_AKS.Text = "Выполнил";
            this.buttonResult_AKS.UseVisualStyleBackColor = true;
            this.buttonResult_AKS.Click += new System.EventHandler(this.buttonResult_AKS_Click);
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.Location = new System.Drawing.Point(541, 409);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(48, 29);
            this.buttonHelp_AKS.TabIndex = 4;
            this.buttonHelp_AKS.Text = "?";
            this.buttonHelp_AKS.UseVisualStyleBackColor = true;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_AKS);
            this.Controls.Add(this.buttonResult_AKS);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput_AKS);
            this.Controls.Add(this.groupBoxTask_AKS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 11 | Агафонов К. С.";
            this.groupBoxTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_AKS)).EndInit();
            this.groupBoxInput_AKS.ResumeLayout(false);
            this.groupBoxInput_AKS.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_AKS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxInput_AKS;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.PictureBox pictureBoxFormula_AKS;
        private System.Windows.Forms.TextBox textBoxCondition_AKS;
        private System.Windows.Forms.TextBox textBoxTextResult_AKS;
        private System.Windows.Forms.TextBox textBoxVariable_AKS;
        private System.Windows.Forms.Button buttonResult_AKS;
        private System.Windows.Forms.TextBox textBoxInput_AKS;
        private System.Windows.Forms.TextBox textBoxResult_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
    }
}

