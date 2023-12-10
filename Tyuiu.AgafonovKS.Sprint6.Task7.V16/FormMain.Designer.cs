
namespace Tyuiu.AgafonovKS.Sprint6.Task7.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_AKS = new System.Windows.Forms.Panel();
            this.buttonHelp_AKS = new System.Windows.Forms.Button();
            this.buttonSave_AKS = new System.Windows.Forms.Button();
            this.buttonResult_AKS = new System.Windows.Forms.Button();
            this.buttonOpen_AKS = new System.Windows.Forms.Button();
            this.panelTask_AKS = new System.Windows.Forms.Panel();
            this.groupBoxTask_AKS = new System.Windows.Forms.GroupBox();
            this.textBoxTask_AKS = new System.Windows.Forms.TextBox();
            this.panelLeft_AKS = new System.Windows.Forms.Panel();
            this.groupBoxInPut_AKS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_AKS = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight_AKS = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_AKS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_AKS = new System.Windows.Forms.DataGridView();
            this.saveFileDialog_AKS = new System.Windows.Forms.SaveFileDialog();
            this.toolTip_AKS = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_AKS = new System.Windows.Forms.OpenFileDialog();
            this.panelTop_AKS.SuspendLayout();
            this.panelTask_AKS.SuspendLayout();
            this.groupBoxTask_AKS.SuspendLayout();
            this.panelLeft_AKS.SuspendLayout();
            this.groupBoxInPut_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_AKS)).BeginInit();
            this.panelRight_AKS.SuspendLayout();
            this.groupBoxOutPut_AKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_AKS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_AKS
            // 
            this.panelTop_AKS.Controls.Add(this.buttonHelp_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonSave_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonResult_AKS);
            this.panelTop_AKS.Controls.Add(this.buttonOpen_AKS);
            this.panelTop_AKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_AKS.Location = new System.Drawing.Point(0, 0);
            this.panelTop_AKS.Name = "panelTop_AKS";
            this.panelTop_AKS.Size = new System.Drawing.Size(800, 85);
            this.panelTop_AKS.TabIndex = 0;
            // 
            // buttonHelp_AKS
            // 
            this.buttonHelp_AKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_AKS.Image = global::Tyuiu.AgafonovKS.Sprint6.Task7.V16.Properties.Resources.information;
            this.buttonHelp_AKS.Location = new System.Drawing.Point(643, 18);
            this.buttonHelp_AKS.Name = "buttonHelp_AKS";
            this.buttonHelp_AKS.Size = new System.Drawing.Size(149, 55);
            this.buttonHelp_AKS.TabIndex = 3;
            this.toolTip_AKS.SetToolTip(this.buttonHelp_AKS, "Сведения о программе");
            this.buttonHelp_AKS.UseVisualStyleBackColor = true;
            this.buttonHelp_AKS.Click += new System.EventHandler(this.buttonHelp_AKS_Click);
            this.buttonHelp_AKS.MouseEnter += new System.EventHandler(this.buttonHelp_AKS_MouseEnter);
            // 
            // buttonSave_AKS
            // 
            this.buttonSave_AKS.Enabled = false;
            this.buttonSave_AKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_AKS.Image = global::Tyuiu.AgafonovKS.Sprint6.Task7.V16.Properties.Resources.page_save;
            this.buttonSave_AKS.Location = new System.Drawing.Point(287, 14);
            this.buttonSave_AKS.Name = "buttonSave_AKS";
            this.buttonSave_AKS.Size = new System.Drawing.Size(119, 59);
            this.buttonSave_AKS.TabIndex = 2;
            this.toolTip_AKS.SetToolTip(this.buttonSave_AKS, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_AKS.UseVisualStyleBackColor = true;
            this.buttonSave_AKS.Click += new System.EventHandler(this.buttonSave_AKS_Click);
            this.buttonSave_AKS.MouseEnter += new System.EventHandler(this.buttonSave_AKS_MouseEnter);
            // 
            // buttonResult_AKS
            // 
            this.buttonResult_AKS.Enabled = false;
            this.buttonResult_AKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult_AKS.Image = global::Tyuiu.AgafonovKS.Sprint6.Task7.V16.Properties.Resources.page_white_go;
            this.buttonResult_AKS.Location = new System.Drawing.Point(149, 11);
            this.buttonResult_AKS.Name = "buttonResult_AKS";
            this.buttonResult_AKS.Size = new System.Drawing.Size(125, 62);
            this.buttonResult_AKS.TabIndex = 1;
            this.toolTip_AKS.SetToolTip(this.buttonResult_AKS, "Выполнить обработку данных");
            this.buttonResult_AKS.UseVisualStyleBackColor = true;
            this.buttonResult_AKS.Click += new System.EventHandler(this.buttonResult_AKS_Click);
            this.buttonResult_AKS.MouseEnter += new System.EventHandler(this.buttonResult_AKS_MouseEnter);
            // 
            // buttonOpen_AKS
            // 
            this.buttonOpen_AKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_AKS.Image = global::Tyuiu.AgafonovKS.Sprint6.Task7.V16.Properties.Resources.folder_page_white;
            this.buttonOpen_AKS.Location = new System.Drawing.Point(9, 8);
            this.buttonOpen_AKS.Name = "buttonOpen_AKS";
            this.buttonOpen_AKS.Size = new System.Drawing.Size(129, 66);
            this.buttonOpen_AKS.TabIndex = 0;
            this.toolTip_AKS.SetToolTip(this.buttonOpen_AKS, "Открыть файл\r\nВыберите нужный файл для обработки ");
            this.buttonOpen_AKS.UseVisualStyleBackColor = true;
            this.buttonOpen_AKS.Click += new System.EventHandler(this.buttonOpen_AKS_Click);
            // 
            // panelTask_AKS
            // 
            this.panelTask_AKS.Controls.Add(this.groupBoxTask_AKS);
            this.panelTask_AKS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_AKS.Location = new System.Drawing.Point(0, 85);
            this.panelTask_AKS.Name = "panelTask_AKS";
            this.panelTask_AKS.Size = new System.Drawing.Size(800, 110);
            this.panelTask_AKS.TabIndex = 1;
            // 
            // groupBoxTask_AKS
            // 
            this.groupBoxTask_AKS.Controls.Add(this.textBoxTask_AKS);
            this.groupBoxTask_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_AKS.Name = "groupBoxTask_AKS";
            this.groupBoxTask_AKS.Size = new System.Drawing.Size(800, 110);
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
            this.textBoxTask_AKS.ReadOnly = true;
            this.textBoxTask_AKS.Size = new System.Drawing.Size(794, 89);
            this.textBoxTask_AKS.TabIndex = 0;
            this.textBoxTask_AKS.Text = resources.GetString("textBoxTask_AKS.Text");
            // 
            // panelLeft_AKS
            // 
            this.panelLeft_AKS.Controls.Add(this.groupBoxInPut_AKS);
            this.panelLeft_AKS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_AKS.Location = new System.Drawing.Point(0, 195);
            this.panelLeft_AKS.Name = "panelLeft_AKS";
            this.panelLeft_AKS.Size = new System.Drawing.Size(403, 255);
            this.panelLeft_AKS.TabIndex = 2;
            // 
            // groupBoxInPut_AKS
            // 
            this.groupBoxInPut_AKS.Controls.Add(this.dataGridViewInPut_AKS);
            this.groupBoxInPut_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_AKS.Name = "groupBoxInPut_AKS";
            this.groupBoxInPut_AKS.Size = new System.Drawing.Size(403, 255);
            this.groupBoxInPut_AKS.TabIndex = 0;
            this.groupBoxInPut_AKS.TabStop = false;
            this.groupBoxInPut_AKS.Text = "Ввод:";
            // 
            // dataGridViewInPut_AKS
            // 
            this.dataGridViewInPut_AKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_AKS.ColumnHeadersVisible = false;
            this.dataGridViewInPut_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_AKS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewInPut_AKS.Name = "dataGridViewInPut_AKS";
            this.dataGridViewInPut_AKS.ReadOnly = true;
            this.dataGridViewInPut_AKS.RowHeadersVisible = false;
            this.dataGridViewInPut_AKS.RowHeadersWidth = 51;
            this.dataGridViewInPut_AKS.RowTemplate.Height = 24;
            this.dataGridViewInPut_AKS.Size = new System.Drawing.Size(397, 234);
            this.dataGridViewInPut_AKS.TabIndex = 0;
            this.dataGridViewInPut_AKS.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(403, 195);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 255);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelRight_AKS
            // 
            this.panelRight_AKS.Controls.Add(this.groupBoxOutPut_AKS);
            this.panelRight_AKS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_AKS.Location = new System.Drawing.Point(413, 195);
            this.panelRight_AKS.Name = "panelRight_AKS";
            this.panelRight_AKS.Size = new System.Drawing.Size(387, 255);
            this.panelRight_AKS.TabIndex = 4;
            // 
            // groupBoxOutPut_AKS
            // 
            this.groupBoxOutPut_AKS.Controls.Add(this.dataGridViewOutPut_AKS);
            this.groupBoxOutPut_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_AKS.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_AKS.Name = "groupBoxOutPut_AKS";
            this.groupBoxOutPut_AKS.Size = new System.Drawing.Size(387, 255);
            this.groupBoxOutPut_AKS.TabIndex = 0;
            this.groupBoxOutPut_AKS.TabStop = false;
            this.groupBoxOutPut_AKS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_AKS
            // 
            this.dataGridViewOutPut_AKS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_AKS.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_AKS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_AKS.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOutPut_AKS.Name = "dataGridViewOutPut_AKS";
            this.dataGridViewOutPut_AKS.ReadOnly = true;
            this.dataGridViewOutPut_AKS.RowHeadersVisible = false;
            this.dataGridViewOutPut_AKS.RowHeadersWidth = 51;
            this.dataGridViewOutPut_AKS.RowTemplate.Height = 24;
            this.dataGridViewOutPut_AKS.Size = new System.Drawing.Size(381, 234);
            this.dataGridViewOutPut_AKS.TabIndex = 0;
            this.dataGridViewOutPut_AKS.TabStop = false;
            // 
            // openFileDialog_AKS
            // 
            this.openFileDialog_AKS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRight_AKS);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft_AKS);
            this.Controls.Add(this.panelTask_AKS);
            this.Controls.Add(this.panelTop_AKS);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 16 | Агафонов К. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_AKS.ResumeLayout(false);
            this.panelTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.ResumeLayout(false);
            this.groupBoxTask_AKS.PerformLayout();
            this.panelLeft_AKS.ResumeLayout(false);
            this.groupBoxInPut_AKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_AKS)).EndInit();
            this.panelRight_AKS.ResumeLayout(false);
            this.groupBoxOutPut_AKS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_AKS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_AKS;
        private System.Windows.Forms.Panel panelTask_AKS;
        private System.Windows.Forms.Panel panelLeft_AKS;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelRight_AKS;
        private System.Windows.Forms.Button buttonOpen_AKS;
        private System.Windows.Forms.Button buttonHelp_AKS;
        private System.Windows.Forms.Button buttonSave_AKS;
        private System.Windows.Forms.Button buttonResult_AKS;
        private System.Windows.Forms.GroupBox groupBoxTask_AKS;
        private System.Windows.Forms.TextBox textBoxTask_AKS;
        private System.Windows.Forms.GroupBox groupBoxInPut_AKS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_AKS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_AKS;
        private System.Windows.Forms.ToolTip toolTip_AKS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_AKS;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_AKS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_AKS;
    }
}

