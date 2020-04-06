using MercadoLivre.Common;
using OpenQA.Selenium;

namespace MercadoLivre.PageObjects
{
    static class ElementosPesquisa
    {
        public static readonly By inputPesquisa = By.CssSelector("form > input[name='as_word']");
        public static readonly By botaoPesquisa = By.CssSelector("form > button[type='submit']");
    }

    public class MetodosPesquisa
    {
        private readonly SeleniumBase selenium;

        public MetodosPesquisa(SeleniumBase seleniumBase)
        {
            selenium = seleniumBase;
        }

        /// <summary>
        /// Realiza a pesquisa de um item identificado como o parâmetro "item"
        /// </summary>
        /// <param name="item"></param>
        public void Pesquisar(string item)
        {
            selenium.Driver.FindElement(ElementosPesquisa.inputPesquisa).SendKeys(item);
            selenium.Driver.FindElement(ElementosPesquisa.botaoPesquisa).Click();
        }
    }
}
