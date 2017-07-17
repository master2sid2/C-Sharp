using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogParser.Base;
using LogParser.GUI;
using LogParser.Logic;

namespace LogParser
{
    public partial class MainForm : Form
    {
        private PreviewForm previewWindow = new PreviewForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            previewWindow.Show();
        }

        private void OpenFileBottun_Click(object sender, EventArgs e)
        {
            FileOperations.OpenFile(previewWindow);
        }

        private void Bottun_Click(object sender, EventArgs e)
        {
            if (StateElements.PreviewWindowState)
            {
                StateElements.PreviewWindowState = false;
                previewWindow.Visible = StateElements.PreviewWindowState;
                ShowHideBottun.Text = "Показать окно";
            }
            else
            {
                StateElements.PreviewWindowState = true;
                previewWindow.Visible = StateElements.PreviewWindowState;
                ShowHideBottun.Text = "Спрятать окно";
            }
        }
    }
}
