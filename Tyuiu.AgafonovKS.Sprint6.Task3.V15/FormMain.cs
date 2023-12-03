using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task3.V15.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = { { 33, 28, 31, 19, 4 },
                              { 1, 32, -3, -17, -12 },
                              { 24, -19, 26, 31, -3 },
                              { 30, -16, 29, 28, 8 },
                              { 30, 5, 11, 7, 32} };

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.GetUpperBound(1) + 1;

            dataGridViewMatrix_AKS.ColumnCount = columns;
            dataGridViewMatrix_AKS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_AKS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_AKS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-23-1 Агафонов Кирилл Сергеевич", "Сообщение");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.GetUpperBound(1) + 1;

            dataGridViewMatrix_AKS.ColumnCount = columns;
            dataGridViewMatrix_AKS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_AKS.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_AKS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
