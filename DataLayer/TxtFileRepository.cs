using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using System.IO;

namespace DataLayer
{
    public class TxtFileRepository : IRepository
    {
        public List<Result> LoadData()
        {
            throw new NotImplementedException();
        }

        public void SaveData(List<string> results)
        {
            string[] lines = new string[results.Count];
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Results.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

        }
    }
}
