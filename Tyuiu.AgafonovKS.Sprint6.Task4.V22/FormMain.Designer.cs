
namespace Tyuiu.AgafonovKS.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_AKS = new System.Windows.Forms.Panel();
            this.panelLeft_AKS = new System.Windows.Forms.Panel();
            this.groupBoxTask_AKS = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_AKS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_AKS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_AKS = new System.Windows.Forms.TextBox();
            this.textBoxStart_AKS = new System.Windows.Forms.TextBox();
            this.textBoxStop_AKS = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_AKS = new System.Windows.Forms.TextBox();
            this.textBoxEndStep_AKS = new System.Windows.Forms.TextBox();
            this.buttonResult_AKS = new System.Windows.Forms.Button();
            this.buttonSave_AKS = new System.Windows.Forms.Button();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.chartResult_AKS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMidle_AKS = new System.Windows.Forms.Panel();
            this.textBoxResult_AKS = new System.Windows.Forms.TextBox();
            this.panelTop_AKS.SuspendLayout();
            this.panelLeft_AKS.SuspendLayout();
            this.groupBoxTask_AKS.SuspendLayout();
            this.groupBoxInput_AKS.SuspendLayout();
            this.groupBoxOutput_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AKS)).BeginInit();
            this.panelMidle_AKS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_AKS
            // 
            this.panelTop_AKS.Controls.Add(this.buttonHelp_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonSave_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonResult_AKS);
            this.panelTop_AKS.Controls.Add(this.groupBoxInput_AKS);
            this.panelTop_AKS.Controls.Add(this.groupBoxTask_AKS);
            this.panelTop_AKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AKS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AKS.Name = "panelTop_AKS";
            this.panelTop_AKS.Size = new System.Drawing.Size(1082, 158);
            this.panelTop_AKS.TabIndex = 0;
            // 
            // panelLeft_AKS
            // 
            this.panelLeft_AKS.Controls.Add(this.groupBoxOutput_AKS);
            this.panelLeft_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AKS.Location = new System.Drawing.Point(0, 158);
            this.panelLeft_AKS.Name = "panelLeft_AKS";
            this.panelLeft_AKS.Size = new System.Drawing.Size(389, 395);
            this.panelLeft_AKS.TabIndex = 1;
            // 
            // groupBoxTask_AKS
            // 
            this.groupBoxTask_AKS.Controls.Add(this.textBoxTask_AKS);
            this.groupBoxTask_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_AKS.Name = "groupBoxTask_AKS";
            this.groupBoxTask_AKS.Size = new System.Drawing.Size(411, 158);
            this.groupBoxTask_AKS.TabIndex = 0;
            this.groupBoxTask_AKS.TabStop = false;
            this.groupBoxTask_AKS.Text = "Условие:";
            // 
            // groupBoxInput_AKS
            // 
            this.groupBoxInput_AKS.Controls.Add(this.textBoxEndStep_AKS);
            this.groupBoxInput_AKS.Controls.Add(this.textBoxStartStep_AKS);
            this.groupBoxInput_AKS.Controls.Add(this.textBoxStop_AKS);
            this.groupBoxInput_AKS.Controls.Add(this.textBoxStart_AKS);
            this.groupBoxInput_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_AKS.Location = new System.Drawing.Point(411, 0);
            this.groupBoxInput_AKS.Name = "groupBoxInput_AKS";
            this.groupBoxInput_AKS.Size = new System.Drawing.Size(671, 158);
            this.groupBoxInput_AKS.TabIndex = 1;
            this.groupBoxInput_AKS.TabStop = false;
            this.groupBoxInput_AKS.Text = "Ввод данных:";
            // 
            // groupBoxOutput_AKS
            // 
            this.groupBoxOutput_AKS.Controls.Add(this.textBoxResult_AKS);
            this.groupBoxOutput_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_AKS.Name = "groupBoxOutput_AKS";
            this.groupBoxOutput_AKS.Size = new System.Drawing.Size(389, 395);
            this.groupBoxOutput_AKS.TabIndex = 0;
            this.groupBoxOutput_AKS.TabStop = false;
            this.groupBoxOutput_AKS.Text = "Вывод данных:";
            // 
            // textBoxTask_AKS
            // 
            this.textBoxTask_AKS.Location = new System.Drawing.Point(10, 21);
            this.textBoxTask_AKS.Multiline = true;
            this.textBoxTask_AKS.Name = "textBoxTask_AKS";
            this.textBoxTask_AKS.Size = new System.Drawing.Size(389, 94);
            this.textBoxTask_AKS.TabIndex = 0;
            this.textBoxTask_AKS.TabStop = false;
            this.textBoxTask_AKS.Text = "Протабулироать функцию sin(x) на заданном диапазоне от -5 до 5. Построить график " +
    "функции и сохронить в файл OutPutFileTask4.txt по нажатию кнопки";
            // 
            // textBoxStart_AKS
            // 
            this.textBoxStart_AKS.Location = new System.Drawing.Point(15, 28);
            this.textBoxStart_AKS.Name = "textBoxStart_AKS";
            this.textBoxStart_AKS.Size = new System.Drawing.Size(130, 22);
            this.textBoxStart_AKS.TabIndex = 0;
            this.textBoxStart_AKS.TabStop = false;
            this.textBoxStart_AKS.Text = "Старт шага:";
            // 
            // textBoxStop_AKS
            // 
            this.textBoxStop_AKS.Location = new System.Drawing.Point(170, 28);
            this.textBoxStop_AKS.Name = "textBoxStop_AKS";
            this.textBoxStop_AKS.Size = new System.Drawing.Size(130, 22);
            this.textBoxStop_AKS.TabIndex = 1;
            this.textBoxStop_AKS.TabStop = false;
            this.textBoxStop_AKS.Text = "Конец шага:";
            // 
            // textBoxStartStep_AKS
            // 
            this.textBoxStartStep_AKS.Location = new System.Drawing.Point(15, 64);
            this.textBoxStartStep_AKS.Name = "textBoxStartStep_AKS";
            this.textBoxStartStep_AKS.Size = new System.Drawing.Size(130, 22);
            this.textBoxStartStep_AKS.TabIndex = 2;
            // 
            // textBoxEndStep_AKS
            // 
            this.textBoxEndStep_AKS.Location = new System.Drawing.Point(170, 64);
            this.textBoxEndStep_AKS.Name = "textBoxEndStep_AKS";
            this.textBoxEndStep_AKS.Size = new System.Drawing.Size(130, 22);
            this.textBoxEndStep_AKS.TabIndex = 3;
            // 
            // buttonResult_AKS
            // 
            this.buttonResult_AKS.BackColor = System.Drawing.Color.Green;
            this.buttonResult_AKS.Location = new System.Drawing.Point(756, 29);
            this.buttonResult_AKS.Name = "buttonResult_AKS";
            this.buttonResult_AKS.Size = new System.Drawing.Size(100, 65);
            this.buttonResult_AKS.TabIndex = 2;
            this.buttonResult_AKS.Text = "Выполнить";
            this.buttonResult_AKS.UseVisualStyleBackColor = false;
            this.buttonResult_AKS.Click += new System.EventHandler(this.buttonResult_AKS_Click);
            // 
            // buttonSave_AKS
            // 
            this.buttonSave_AKS.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_AKS.Location = new System.Drawing.Point(862, 29);
            this.buttonSave_AKS.Name = "buttonSave_AKS";
            this.buttonSave_AKS.Size = new System.Drawing.Size(100, 65);
            this.buttonSave_AKS.TabIndex = 3;
            this.buttonSave_AKS.Text = "Сохранить";
            this.buttonSave_AKS.UseVisualStyleBackColor = false;
            this.buttonSave_AKS.Click += new System.EventHandler(this.buttonSave_AKS_Click);
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_AKS.Location = new System.Drawing.Point(968, 29);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(100, 65);
            this.buttonHelp_AKS.TabIndex = 4;
            this.buttonHelp_AKS.Text = "Справка";
            this.buttonHelp_AKS.UseVisualStyleBackColor = false;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            // 
            // chartResult_AKS
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult_AKS.ChartAreas.Add(chartArea3);
            this.chartResult_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult_AKS.Legends.Add(legend3);
            this.chartResult_AKS.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AKS.Name = "chartResult_AKS";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult_AKS.Series.Add(series3);
            this.chartResult_AKS.Size = new System.Drawing.Size(693, 395);
            this.chartResult_AKS.TabIndex = 7;
            this.chartResult_AKS.Text = "chart1";
            // 
            // panelMidle_AKS
            // 
            this.panelMidle_AKS.Controls.Add(this.chartResult_AKS);
            this.panelMidle_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidle_AKS.Location = new System.Drawing.Point(389, 158);
            this.panelMidle_AKS.Name = "panelMidle_AKS";
            this.panelMidle_AKS.Size = new System.Drawing.Size(693, 395);
            this.panelMidle_AKS.TabIndex = 2;
            // 
            // textBoxResult_AKS
            // 
            this.textBoxResult_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_AKS.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_AKS.Multiline = true;
            this.textBoxResult_AKS.Name = "textBoxResult_AKS";
            this.textBoxResult_AKS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AKS.Size = new System.Drawing.Size(383, 374);
            this.textBoxResult_AKS.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panelMidle_AKS);
            this.Controls.Add(this.panelLeft_AKS);
            this.Controls.Add(this.panelTop_AKS);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 22 | Агафонов К. С.";
            this.panelTop_AKS.ResumeLayout(false);
            this.panelLeft_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.PerformLayout();
            this.groupBoxInput_AKS.ResumeLayout(false);
            this.groupBoxInput_AKS.PerformLayout();
            this.groupBoxOutput_AKS.ResumeLayout(false);
            this.groupBoxOutput_AKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AKS)).EndInit();
            this.panelMidle_AKS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop_AKS;
        private System.Windows.Forms.GroupBox groupBoxInput_AKS;
        private System.Windows.Forms.GroupBox groupBoxTask_AKS;
        private System.Windows.Forms.TextBox textBoxTask_AKS;
        private System.Windows.Forms.Panel panelLeft_AKS;
        private System.Windows.Forms.GroupBox groupBoxOutput_AKS;
        private System.Windows.Forms.TextBox textBoxEndStep_AKS;
        private System.Windows.Forms.TextBox textBoxStartStep_AKS;
        private System.Windows.Forms.TextBox textBoxStop_AKS;
        private System.Windows.Forms.TextBox textBoxStart_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
        private System.Windows.Forms.Button buttonSave_AKS;
        private System.Windows.Forms.Button buttonResult_AKS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AKS;
        private System.Windows.Forms.Panel panelMidle_AKS;
        private System.Windows.Forms.TextBox textBoxResult_AKS;
    }
}

