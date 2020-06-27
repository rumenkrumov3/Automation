using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace DemoQA.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
      
        protected Actions Builder { get; set; }

        public void Initialize()
        {
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("-headless");

            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));         

            //Driver = new RemoteWebDriver(new Uri("http://192.168.1.190:4444/wd/hub"), options);

            Builder = new Actions(Driver);

            Driver.Manage().Window.Maximize();
        }
    }
}
