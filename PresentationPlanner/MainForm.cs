using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PresentationPlanner.BL;

namespace PresentationPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxPresentationSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPresentationSource_Click(object sender, EventArgs e)
        {
            //Диалог выбора папки Source
            FolderBrowserDialog sourceFolderBrowserDialog = new FolderBrowserDialog();
            DialogResult dialogresult = sourceFolderBrowserDialog.ShowDialog();
            sourceFolderBrowserDialog.Description = "Выберите путь к папке c презентациями";
            string folderName = "";
            if (dialogresult == DialogResult.OK)
            {
                folderName = sourceFolderBrowserDialog.SelectedPath;
            }
            textBoxPresentationSource.Text = folderName;
        }

        private void btnStartPresentation_Click(object sender, EventArgs e)
        {
            FileManager manager = new FileManager();
            manager.Start(textBoxPresentationSource.Text, textBoxPowerPointSource.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPowerPointSource.Text = openFileDialog.FileName;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
