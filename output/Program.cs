﻿using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayer.GetResults.GetData("http://worldcup.sfg.io/teams/results/");
        }
    }
}
