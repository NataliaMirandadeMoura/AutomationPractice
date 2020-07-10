using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.AutomationPractice.Util
{
    public static class WebDriverImplicitWait
    {
        public static IWebElement FindElement(this IWebDriver navegador, By by, int timeoutEmSegundos)
        {
            if (timeoutEmSegundos > 0)
            {
                var espera = new WebDriverWait(navegador, TimeSpan.FromSeconds(timeoutEmSegundos));
                return espera.Until(drv => drv.FindElement(by));
            }
            return navegador.FindElement(by);
        }

        public static IWebElement XpathIsVisible(this IWebDriver navegador, string byXpath, int timeoutEmSegundos)
        {
            try
            {
                if (timeoutEmSegundos > 0)
                {
                    var espera = new WebDriverWait(navegador, TimeSpan.FromSeconds(timeoutEmSegundos));
                    return espera.Until(ExpectedConditions.ElementIsVisible(By.XPath(byXpath)));
                }
                return navegador.FindElement(By.XPath(byXpath));
            }
            catch (Exception ex)
            {
                if (ex is NoSuchElementException || ex is WebDriverTimeoutException)
                {
                    return null;
                }
                throw;
            }
        }

        public static bool VerificarElementoNaoPresente(this IWebDriver navegador, By consulta, int timeoutEmSegundos)
        {
            try
            {
                IWebElement element = navegador.FindElement(consulta);
                var espera = new WebDriverWait(navegador, TimeSpan.FromSeconds(timeoutEmSegundos));
                return espera.Until(ExpectedConditions.StalenessOf(element));
            }
            catch (Exception ex)
            {
                if (ex is NoSuchElementException || ex is WebDriverTimeoutException)
                {
                    return false;
                }
                throw;
            }
        }
    }
}