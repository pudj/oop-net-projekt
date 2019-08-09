using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IRepository
    {
        List<Result> LoadData();
        void SaveData(List<string> results);
    }
}
