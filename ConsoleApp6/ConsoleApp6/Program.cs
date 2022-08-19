using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;

namespace SSOM_POC
{
    internal class Program
    {
        static string url = "https://singhiqindia.sharepoint.com/sites/axisbank/hrpolicies";
        static void Main(string[] args)
        {
            _GetsiteProp();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
        static void _GetsiteProp()
        {
           SPSite @site= new SPSite(url);
            SPWeb @web= @site.OpenWeb();
            Console.WriteLine(@web.Title);
            @web.Dispose();
            @site.Dispose();
        }
    }
}
