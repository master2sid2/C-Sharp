using System;
using System.Linq;
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
            StateElements.InverseCheckBox = false;
            StateElements.RegisterCheckBox = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            previewWindow.Show();
        }

        private void OpenFileBottun_Click(object sender, EventArgs e)
        {
            FileOperations.OpenFile(previewWindow);
        }
        private void SaveBottun_Click(object sender, EventArgs e)
        {
            FileOperations.SaveFile(previewWindow);
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

        private void RegisterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegisterCheckBox.Checked)
            {
                StateElements.RegisterCheckBox = true;
            }
            else
            {
                StateElements.RegisterCheckBox = false;
            }
            Filter.setFilter(previewWindow, InputTextBox.Text);
            previewWindow.setText(Filter.getFilteredText());
        }

        private void InvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (InvertCheckBox.Checked)
            {
                StateElements.InverseCheckBox = true;
            }
            else
            {
                StateElements.InverseCheckBox = false;
            }
            Filter.setFilter(previewWindow, InputTextBox.Text);
            previewWindow.setText(Filter.getFilteredText());
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter.setFilter(previewWindow, InputTextBox.Text);
            previewWindow.setText(Filter.getFilteredText());
        }
    }
}
