using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\Kirya\source\repos\Tyuiu.AgafonovKS.Sprint6\Tyuiu.AgafonovKS.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_AKS.ColumnCount = 2;
            dataGridViewResult_AKS.Columns[0].Width = 20;
            dataGridViewResult_AKS.Columns[1].Width = 50;

            this.chartResult_AKS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_AKS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_AKS.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_AKS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_AKS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_AKS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-1 Агафонов Кирилл Сергеевич", "Сообщение");
        }
    }
}
