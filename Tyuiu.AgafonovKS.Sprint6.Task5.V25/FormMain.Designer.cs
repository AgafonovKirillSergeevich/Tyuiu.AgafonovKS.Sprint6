
namespace Tyuiu.AgafonovKS.Sprint6.Task5.V25
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_AKS = new System.Windows.Forms.Panel();
            this.groupBoxTask_AKS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_AKS = new System.Windows.Forms.TextBox();
            this.panelLeft_AKS = new System.Windows.Forms.Panel();
            this.groupBoxResult_AKS = new System.Windows.Forms.GroupBox();
            this.panelMidle_AKS = new System.Windows.Forms.Panel();
            this.chartResult_AKS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonResult_AKS = new System.Windows.Forms.Button();
            this.buttonOpen_AKS = new System.Windows.Forms.Button();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.dataGridViewResult_AKS = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop_AKS.SuspendLayout();
            this.groupBoxTask_AKS.SuspendLayout();
            this.panelLeft_AKS.SuspendLayout();
            this.groupBoxResult_AKS.SuspendLayout();
            this.panelMidle_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AKS
            // 
            this.panelTop_AKS.Controls.Add(this.buttonHelp_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonOpen_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonResult_AKS);
            this.panelTop_AKS.Controls.Add(this.groupBoxTask_AKS);
            this.panelTop_AKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AKS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AKS.Name = "panelTop_AKS";
            this.panelTop_AKS.Size = new System.Drawing.Size(800, 114);
            this.panelTop_AKS.TabIndex = 0;
            // 
            // groupBoxTask_AKS
            // 
            this.groupBoxTask_AKS.Controls.Add(this.textBoxTask_AKS);
            this.groupBoxTask_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxTask_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_AKS.Name = "groupBoxTask_AKS";
            this.groupBoxTask_AKS.Size = new System.Drawing.Size(390, 114);
            this.groupBoxTask_AKS.TabIndex = 0;
            this.groupBoxTask_AKS.TabStop = false;
            this.groupBoxTask_AKS.Text = "Условие:";
            // 
            // textBoxTask_AKS
            // 
            this.textBoxTask_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_AKS.Location = new System.Drawing.Point(3, 18);
            this.textBoxTask_AKS.Multiline = true;
            this.textBoxTask_AKS.Name = "textBoxTask_AKS";
            this.textBoxTask_AKS.Size = new System.Drawing.Size(384, 93);
            this.textBoxTask_AKS.TabIndex = 0;
            this.textBoxTask_AKS.TabStop = false;
            this.textBoxTask_AKS.Text = "Прочитать данные из файла InPutFileTask5V25.txt. Вывести в dataGridView.Дан списо" +
    "к из чисел. Вывести все элементы, равные 0. Построить диаграмму по этим значения" +
    "м";
            // 
            // panelLeft_AKS
            // 
            this.panelLeft_AKS.Controls.Add(this.groupBoxResult_AKS);
            this.panelLeft_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AKS.Location = new System.Drawing.Point(0, 114);
            this.panelLeft_AKS.Name = "panelLeft_AKS";
            this.panelLeft_AKS.Size = new System.Drawing.Size(382, 336);
            this.panelLeft_AKS.TabIndex = 1;
            // 
            // groupBoxResult_AKS
            // 
            this.groupBoxResult_AKS.Controls.Add(this.dataGridViewResult_AKS);
            this.groupBoxResult_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_AKS.Name = "groupBoxResult_AKS";
            this.groupBoxResult_AKS.Size = new System.Drawing.Size(382, 336);
            this.groupBoxResult_AKS.TabIndex = 0;
            this.groupBoxResult_AKS.TabStop = false;
            this.groupBoxResult_AKS.Text = "Вывод данных:";
            // 
            // panelMidle_AKS
            // 
            this.panelMidle_AKS.Controls.Add(this.chartResult_AKS);
            this.panelMidle_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidle_AKS.Location = new System.Drawing.Point(382, 114);
            this.panelMidle_AKS.Name = "panelMidle_AKS";
            this.panelMidle_AKS.Size = new System.Drawing.Size(418, 336);
            this.panelMidle_AKS.TabIndex = 2;
            // 
            // chartResult_AKS
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_AKS.ChartAreas.Add(chartArea5);
            this.chartResult_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartResult_AKS.Legends.Add(legend5);
            this.chartResult_AKS.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AKS.Name = "chartResult_AKS";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_AKS.Series.Add(series5);
            this.chartResult_AKS.Size = new System.Drawing.Size(418, 336);
            this.chartResult_AKS.TabIndex = 0;
            this.chartResult_AKS.Text = "chart1";
            // 
            // buttonResult_AKS
            // 
            this.buttonResult_AKS.BackColor = System.Drawing.Color.Green;
            this.buttonResult_AKS.Location = new System.Drawing.Point(393, 27);
            this.buttonResult_AKS.Name = "buttonResult_AKS";
            this.buttonResult_AKS.Size = new System.Drawing.Size(125, 65);
            this.buttonResult_AKS.TabIndex = 1;
            this.buttonResult_AKS.Text = "Выполнить";
            this.buttonResult_AKS.UseVisualStyleBackColor = false;
            this.buttonResult_AKS.Click += new System.EventHandler(this.buttonResult_AKS_Click);
            // 
            // buttonOpen_AKS
            // 
            this.buttonOpen_AKS.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOpen_AKS.Location = new System.Drawing.Point(524, 27);
            this.buttonOpen_AKS.Name = "buttonOpen_AKS";
            this.buttonOpen_AKS.Size = new System.Drawing.Size(125, 65);
            this.buttonOpen_AKS.TabIndex = 2;
            this.buttonOpen_AKS.Text = "Открыть файл";
            this.buttonOpen_AKS.UseVisualStyleBackColor = false;
            this.buttonOpen_AKS.Click += new System.EventHandler(this.buttonOpen_AKS_Click);
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_AKS.Location = new System.Drawing.Point(655, 27);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(125, 65);
            this.buttonHelp_AKS.TabIndex = 3;
            this.buttonHelp_AKS.Text = "Справка";
            this.buttonHelp_AKS.UseVisualStyleBackColor = false;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            // 
            // dataGridViewResult_AKS
            // 
            this.dataGridViewResult_AKS.AllowUserToAddRows = false;
            this.dataGridViewResult_AKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AKS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column,
            this.Column2});
            this.dataGridViewResult_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_AKS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_AKS.Name = "dataGridViewResult_AKS";
            this.dataGridViewResult_AKS.ReadOnly = true;
            this.dataGridViewResult_AKS.RowHeadersVisible = false;
            this.dataGridViewResult_AKS.RowHeadersWidth = 51;
            this.dataGridViewResult_AKS.RowTemplate.Height = 24;
            this.dataGridViewResult_AKS.Size = new System.Drawing.Size(376, 315);
            this.dataGridViewResult_AKS.TabIndex = 0;
            this.dataGridViewResult_AKS.TabStop = false;
            // 
            // Column
            // 
            this.Column.FillWeight = 300F;
            this.Column.HeaderText = "№";
            this.Column.MinimumWidth = 100;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 140;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 300F;
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMidle_AKS);
            this.Controls.Add(this.panelLeft_AKS);
            this.Controls.Add(this.panelTop_AKS);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 25 | Агафонов К. С.";
            this.panelTop_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.PerformLayout();
            this.panelLeft_AKS.ResumeLayout(false);
            this.groupBoxResult_AKS.ResumeLayout(false);
            this.panelMidle_AKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AKS;
        private System.Windows.Forms.GroupBox groupBoxTask_AKS;
        private System.Windows.Forms.TextBox textBoxTask_AKS;
        private System.Windows.Forms.Panel panelLeft_AKS;
        private System.Windows.Forms.GroupBox groupBoxResult_AKS;
        private System.Windows.Forms.Panel panelMidle_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
        private System.Windows.Forms.Button buttonOpen_AKS;
        private System.Windows.Forms.Button buttonResult_AKS;
        private System.Windows.Forms.DataGridView dataGridViewResult_AKS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

