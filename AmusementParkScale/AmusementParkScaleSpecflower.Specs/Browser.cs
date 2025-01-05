using Gherkin.Ast;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.tests
{
    public class BrowserOperations
    {
        private IWebDriver webDriver;

        public BrowserOperations(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public void InitBrowser()
        {
            webDriver.Manage().Window.Maximize();
        }
        public string Title
        {
            get { return webDriver.Title; }
        }
        public IWebDriver WebDriver
        {
            get { return webDriver; }
        }
        public void Goto(string url)
        {
            webDriver.Url = url;
        }
        public void Close()
        {
            webDriver.Quit();
        }
    }
}
