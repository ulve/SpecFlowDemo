using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceptanstest.Driver
{
    public class Ie
    {
        private static IWebDriver _driver = null;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                {
                    _driver = new InternetExplorerDriver();                  
                }

                return _driver;
            }
        }

        public static void TakeScreenshot(string fileName)
        {
            var screenShot = ((ITakesScreenshot)Driver).GetScreenshot();
            screenShot.SaveAsFile(GetFullPath(fileName), ImageFormat.Png);
        }

        private static string GetFullPath(string fileName)
        {
            return Path.Combine(@"c:\temp", fileName) + ".png";
        }

        public static void Initialize()
        {
            _driver = null;
        }

        public static void Close()
        {
            Driver.Close();
        }        
    }
}
