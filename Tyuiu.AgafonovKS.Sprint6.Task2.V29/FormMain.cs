using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task2.V29.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task2.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartstep_AKS.Text);
                int stopStep = Convert.ToInt32(textBoxEndstep_AKS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_AKS.Titles.Add("График функции");
                this.chartResult_AKS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_AKS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_AKS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_AKS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-23-1 Агафонов Кирилл Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonResult_AKS_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_AKS.BackColor = Color.Blue;
        }

        private void buttonResult_AKS_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_AKS.BackColor = Color.Green;
        }

        private void buttonResult_AKS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_AKS.BackColor = Color.Blue;
        }
    }
}
