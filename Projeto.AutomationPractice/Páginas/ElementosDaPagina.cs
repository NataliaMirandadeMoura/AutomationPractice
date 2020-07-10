using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

class ElementosDaPagina : PaginaBase
{
    //Campos da tela
    public IWebElement campoPesquisa => RetornarElementoPorId("search_query_top");

    //Logo da página
    public IWebElement pagina => RetornarElementoPorId("search_query_top");

    //Botões
    public IWebElement botaoSubmit => RetornarElementoPorNome("submit_search");
    public IWebElement botaoAdicionarNoCarrinho => RetornarElementoPorNome("Submit");
    public IWebElement botaoContinueShopping => RetornarElementoPorXpath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span");
    public IWebElement botaoRetornarParaHome => RetornarElementoPorXpath("/html/body/div/div[2]/div/div[1]/a");
    public IWebElement botaoFecharCompra => RetornarElementoPorXpath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a");

    //Resultados da pesquisa
    public IWebElement resultadoTSHIRT => RetornarElementoPorXpath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div");
    public IWebElement resultadoBlouse => RetornarElementoPorXpath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li/div/div[1]/div");

    //Cor da T-SHIRT
    public IWebElement corAzul => RetornarElementoPorId("color_14");

    //Resultados da T-SHIRT e BLOUSE
    public IWebElement itemTshirtNome => RetornarElementoPorXpath("/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr[1]/td[2]/p");
    public IWebElement itemTshirtQuantidade => RetornarElementoPorNome("quantity_1_2_0_0");
    public IWebElement itemTshirtPreco => RetornarElementoPorId("total_product_price_1_2_0");
    public IWebElement itemBlouseNome => RetornarElementoPorXpath("/html/body/div/div[2]/div/div[3]/div/div[2]/table/tbody/tr[2]/td[2]/p/a");
    public IWebElement itemBlouseQuantidade => RetornarElementoPorNome("quantity_2_7_0_0");
    public IWebElement itemBlousePreco => RetornarElementoPorXpath("total_product_price_2_7_0");

    public ElementosDaPagina(IWebDriver navegador) : base(navegador)
    {

    }

}
