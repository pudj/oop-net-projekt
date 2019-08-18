using DataLayer;
using DataLayer.Model;
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

namespace FormsClient
{
    public partial class Form1 : Form
    {
        IRepository txtrepo;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private Task GetDataTask() {
            return Task.Factory.StartNew(() => {
                List<Result> results = new List<Result>();
                results = GetResults.GetData("http://worldcup.sfg.io/teams/results/");
                foreach (var result in results)
                {
                    ResultBox.Items.Add(result.Fifa_Code);
                }
            });
        }

        private void ResultBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveTeam_Click(object sender, EventArgs e)
        {

        }

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            await GetDataTask();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultsLoadedLabel.Text = (e.ProgressPercentage.ToString() + "%");
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            resultsLoadedLabel.Text = "Podaci učitani!";
        }
    }
}
