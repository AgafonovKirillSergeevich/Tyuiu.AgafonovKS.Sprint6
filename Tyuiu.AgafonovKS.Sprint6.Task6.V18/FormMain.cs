using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AgafonovKS.Sprint6.Task6.V18.Lib;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task6.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;

        private void buttonResult_AKS_Click(object sender, EventArgs e)
        {
            textBoxOutPut_AKS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_AKS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AKS.ShowDialog();
            openFilePath = openFileDialogTask_AKS.FileName;
            textBoxInPut_AKS.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_AKS.Text = groupBoxOutPut_AKS.Text + " " + openFileDialogTask_AKS.FileName;
            buttonResult_AKS.Enabled = true;
        }

        private void buttonHelp_AKS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
