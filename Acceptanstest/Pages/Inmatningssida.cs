using Acceptanstest.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceptanstest.Pages
{
    public static class Inmatningssida 
    {
        public static string Uri = "http://localhost:52139/BillableHours/Create";

        public static string Html
        {
            get
            {
                return Ie.Driver.PageSource;
            }
        }

        public static void GåTill()
        {
            Ie.Driver.Navigate().GoToUrl(Uri);            
        }

        internal static void FyllTid(string tid)
        {
            var element = Ie.Driver.FindElement(By.Id("Tid"));
            element.SendKeys(tid);
        }

        internal static void FyllKund(string kund)
        {
            var element = Ie.Driver.FindElement(By.Id("Kund"));
            element.SendKeys(kund);
        }

        internal static void TryckLäggTill()
        {
            var element = Ie.Driver.FindElement(By.Id("Skicka"));
            element.Submit();
        }

        internal static void FyllKommentar(string kommentar)
        {
            var element = Ie.Driver.FindElement(By.Id("Kommentar"));
            element.SendKeys(kommentar);
        }        
    }
}
