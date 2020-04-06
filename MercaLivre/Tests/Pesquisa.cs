using MercadoLivre.Common;
using MercadoLivre.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace MercadoLivre.Tests
{
    [TestClass]
    public class Pesquisa : SeleniumBase
    {
        [TestMethod]
        [TestCategory("Mercado Livre - Pesquisa")]
        public void PesquisaPlaystation()
        {
            MetodosPesquisa pesquisa = new MetodosPesquisa(this);
            MetodosResultados resultados = new MetodosResultados(this);
            string ps4 = "Playstation 4";
            pesquisa.Pesquisar(ps4);
            resultados.RetornoPesquisa(ps4);
            Assert.IsTrue(Driver.FindElement(ElementosResultados.ItemPesquisado(ps4)).Displayed);
        }
        [TestMethod]
        [TestCategory("Mercado Livre - Pesquisa")]
        public void PesquisaTelevisao()
        {
            Waits wait = new Waits(this);
            Driver.FindElement(By.CssSelector("form > input[name='as_word']")).SendKeys("Televisão Samsung");
            Driver.FindElement(By.CssSelector("form > button[type='submit']")).Click();
            wait.WaitVisible(By.CssSelector("img[src*='https']"));
            // Seletores por css tem a função de "parenteamento"
            // assim deixando os elementos sendo mais fáceis de serem localizados (:nth-child(1))
            Assert.IsTrue(Driver.FindElement(By.CssSelector("ul:nth-child(1) img[src*='https']")).Displayed);
        }
        [TestMethod]
        [TestCategory("Mercado Livre - Pesquisa")]
        public void PesquisaMascara()
        {
            string textoPesquisado = "Mascara";
            Waits wait = new Waits(this);
            Driver.FindElement(By.CssSelector("form > input[name='as_word']")).SendKeys(textoPesquisado);
            Driver.FindElement(By.CssSelector("form > button[type='submit']")).Click();
            wait.WaitVisible(By.CssSelector("img[src*='https']"));
            Assert.IsTrue(Driver.FindElement(By.CssSelector("ul img[src*='https']")).Displayed);
        }
    }
}
