using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithHTMLData
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = @"https://staff.am/en/companies?CompaniesFilter%5BkeyWord%5D=&CompaniesFilter%5Bindustries%5D=&CompaniesFilter%5Bindustries%5D%5B%5D=2&CompaniesFilter%5Bemployees_number%5D=&CompaniesFilter%5Bsort_by%5D=&CompaniesFilter%5Bhas_job%5D=";

            HtmlWeb hw = new HtmlWeb();
           
            HtmlDocument htmlDocument = hw.Load(URL);

           HtmlNodeCollection nc= htmlDocument.DocumentNode.SelectNodes("//div[@class='company-action company_inner_right']/a");

            List<string> urrlist = new List<string>();
            foreach (var item in nc)
            {
               string t= item.Attributes["href"].Value;
                urrlist.Add("https://staff.am"+t);
            }
        }
    }
}
