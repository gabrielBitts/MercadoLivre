using MercadoLivre.Common;
using OpenQA.Selenium;

namespace MercadoLivre.PageObjects
{
    static class ElementosResultados
    {
        /// <summary>
        /// Item pesquisado é utilizado como localizador de um item informado em testes 
        /// </summary>
        /// <param name="item"></param>
        /// <returns>Retorna o Xpath que contenha o texto informado em "item"</returns>
        public static By ItemPesquisado(string item)
        {
            return By.XPath($"//span[contains(., '{item}')]");
        }
    }

    public class MetodosResultados
    {
        private readonly SeleniumBase selenium;

        public MetodosResultados(SeleniumBase seleniumBase)
        {
            selenium = seleniumBase;
        }

        public void RetornoPesquisa(string item)
        {
            Waits wait = new Waits(selenium);
            wait.WaitVisible(ElementosResultados.ItemPesquisado(item));
        }
    }
}
