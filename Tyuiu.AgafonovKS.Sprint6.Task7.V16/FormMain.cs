using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task7.V16.Lib;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task7.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_AKS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_AKS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpen_AKS_Click(object sender, EventArgs e)
        {
            openFileDialog_AKS.ShowDialog();
            openFile = openFileDialog_AKS.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPut_AKS.RowCount = rows;
            dataGridViewInPut_AKS.ColumnCount = columns;
            dataGridViewOutPut_AKS.RowCount = rows;
            dataGridViewOutPut_AKS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_AKS.Columns[i].Width = 50;
                dataGridViewOutPut_AKS.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_AKS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonResult_AKS.Enabled = true;
        }

        private void buttonSave_AKS_Click(object sender, EventArgs e)
        {
            saveFileDialog_AKS.FileName = "OutPutFileTask7.csv";
            saveFileDialog_AKS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_AKS.ShowDialog();

            string path = saveFileDialog_AKS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_AKS.RowCount;
            int columns = dataGridViewOutPut_AKS.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPut_AKS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPut_AKS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSave_AKS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AKS.ToolTipTitle = "Сохранить файл";
        }

        private void buttonResult_AKS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AKS.ToolTipTitle = "Открыть файл";
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonHelp_AKS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_AKS.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_AKS.RowCount = 50;
            dataGridViewOutPut_AKS.RowCount = 50;

            dataGridViewInPut_AKS.ColumnCount = 50;
            dataGridViewOutPut_AKS.ColumnCount = 50;

            panelLeft_AKS.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_AKS.Columns[i].Width = 25;
                dataGridViewOutPut_AKS.Columns[i].Width = 25;
            }
        }

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_AKS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_AKS.Enabled = true;
        }
    }
}
