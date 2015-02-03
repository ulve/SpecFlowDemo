using Acceptanstest.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceptanstest.Pages
{
    public static class Översikt
    {
        public static string Uri = "http://localhost:52139/BillableHours";

        public static string Html
        {
            get
            {
                return Ie.Driver.PageSource;
            }
        }
    }
}
