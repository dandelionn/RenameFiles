using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenameFiles
{
    public partial class MainForm : Form
    {
        BackgroundWorker _backgroundWorker;
        public MainForm()
        {
            InitializeComponent();

            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.ProgressChanged += _backgroundWorker_ProgressChanged;
            _backgroundWorker.DoWork += _backgroundWorker_DoWork;
        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Tuple<string, string, string> renameData = (Tuple<string, string, string>) e.Argument;
            RenameFiles(renameData.Item1, renameData.Item2, renameData.Item3);
        }

        private void _backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            labelPercentage.Text = e.ProgressPercentage + "%";
        }

        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelPercentage.Text = "Done!";
            buttonRename.Enabled = true;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(textBoxInputDir.Text) && Directory.Exists(textBoxOutputDir.Text))
            {
                buttonRename.Enabled = false;
                Tuple<string, string, string> renameData = new Tuple<string, string, string>(textBoxInputDir.Text, textBoxOutputDir.Text, textBoxOutputPrefix.Text);
               // RenameFiles(textBoxInputDir.Text, textBoxOutputDir.Text, textBoxOutputPrefix.Text);
                _backgroundWorker.RunWorkerAsync(renameData);
            }
        }

        long start_index = 10000000000000000;
        private void RenameFiles(string inputDir, string outputDir, string prefix)
        {
            long i = 0;
            IEnumerable<string> files = Directory.EnumerateFiles(inputDir);
            foreach(string file in files)
            {
                File.Copy(file, Path.Combine(outputDir, prefix + (start_index + i).ToString() + Path.GetExtension(file)));
                i++;

                _backgroundWorker.ReportProgress( (int) ((i * 100) / files.LongCount()));
            }
        }

        private void buttonSetInputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBroserDialog = new FolderBrowserDialog();
            if(folderBroserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputDir.Text = folderBroserDialog.SelectedPath;
            }
        }

        private void buttonSetOutputDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBroserDialog = new FolderBrowserDialog();
            if (folderBroserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputDir.Text = folderBroserDialog.SelectedPath;
            }
        }

        private void buttonOpenInputDir_Click(object sender, EventArgs e)
        {
            if(Directory.Exists(textBoxInputDir.Text))
            {
                Process.Start(textBoxInputDir.Text);
            }
        }

        private void buttonOpenOutputDir_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxInputDir.Text))
            {
                Process.Start(textBoxOutputDir.Text);
            }
        }
    }
}
