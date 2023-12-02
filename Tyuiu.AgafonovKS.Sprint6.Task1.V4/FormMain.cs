using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task1.V4.Lib;

namespace Tyuiu.AgafonovKS.Sprint6.Task1.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStartstep_AKS.Text);
                int stopValue = Convert.ToInt32(textBoxEndstep_AKS.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_AKS.Text = "";

                textBoxResult_AKS.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult_AKS.AppendText("|    X    |   f(x)   |" + Environment.NewLine);
                textBoxResult_AKS.AppendText("+---------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5}    |  {1, 6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_AKS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_AKS.AppendText("+---------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-1 Агафонов Кирилл Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
