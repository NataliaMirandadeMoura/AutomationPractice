using OpenQA.Selenium;
using Projeto.AutomationPractice.Util;

public abstract class PaginaBase
{
    public IWebDriver _navegador;

    protected PaginaBase(IWebDriver navegador)
    {
        _navegador = navegador;
    }
    protected IWebElement RetornarPorCss(string cssSelector) => _navegador.FindElement(By.CssSelector(cssSelector), 5);
    protected IWebElement RetornarElementoPorNome(string nome) => _navegador.FindElement(By.Name(nome), 10);

    public IWebElement RetornarElementoPorId(string id) => _navegador.FindElement(By.Id(id), 10);

    public IWebElement RetornarElementoPorXpath(string Xpath) => _navegador.XpathIsVisible(Xpath, 10);

    protected IWebElement RetornarElementoPorClass(string classe) => _navegador.FindElement(By.ClassName(classe), 10);

    protected bool RetornarNaoElementoXpath(string Xpath) => _navegador.VerificarElementoNaoPresente(By.XPath(Xpath), 10);

}
