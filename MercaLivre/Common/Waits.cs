using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using System;

namespace MercadoLivre.Common
{
    public class Waits
    {
        public SeleniumBase _seleniumBase;

        public Waits(SeleniumBase seleniumBase)
        {
            _seleniumBase = seleniumBase;
        }

        public void WaitVisible(By elemento)
        {
            WebDriverWait wait = new WebDriverWait(_seleniumBase.Driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(elemento));
        }
    }
}
