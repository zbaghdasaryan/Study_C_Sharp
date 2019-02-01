using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Site_JSON_Serialize
{
    static class JsonReader
    {
        public static string GetJsonData(string URL)
        {
            WebClient web = new WebClient();

            StreamReader stream = new StreamReader(web.OpenRead(URL));

            return stream.ReadToEnd();

            //WebRequest request = WebRequest.Create(URL);

        }
        public static Company[] GetCompanies(string URL)
        {
            string content = GetJsonData(URL);
            Company[] company = JsonConvert.DeserializeObject<Company[]>(content);
            return company;
        }

    }
}
