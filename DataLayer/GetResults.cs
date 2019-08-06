using DataLayer.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class GetResults
    {
        
        public static List<Result> GetData(string url) {
            var client = new RestClient();
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("User-Agent", "Nothing");
            IRestResponse<List<Result>> results = client.Execute<List<Result>>(request);
            return results.Data;
        }
    }
}
