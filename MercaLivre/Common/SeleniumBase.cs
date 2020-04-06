using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;

namespace MercadoLivre.Common
{
    public class SeleniumBase : IDisposable
    {
        public IWebDriver Driver { get; set; }
        protected string baseUrl = "https://www.mercadolivre.com.br/";

        protected SeleniumBase()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            Driver = new ChromeDriver(chromeOptions);
            Driver.Navigate().GoToUrl(baseUrl);
        }

        public void Dispose()
        {
            Driver.Quit();
            Driver.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
