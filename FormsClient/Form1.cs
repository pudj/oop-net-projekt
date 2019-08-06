using DataLayer;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsClient
{
    public partial class Form1 : Form
    {
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
    }
}
