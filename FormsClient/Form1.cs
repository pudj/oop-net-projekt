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
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await GetDataTask();   

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
           // List<string> results = new List<string>();
           var selectedTeam = ResultBox.SelectedItem.ToString();
            // foreach (var item in results)
            // {
            //     results.Add(selectedTeam);
            // }
            //  txtrepo.SaveData(results);
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Results.txt")))
            {
                outputFile.WriteLine($"Naziv: { selectedTeam }");
            }
            MessageBox.Show("Podaci spremljeni u MyDocuments.");

        }
    }
}
