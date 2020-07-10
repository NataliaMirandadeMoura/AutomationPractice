using NUnit.Framework;
using Projeto.AutomationPractice.Util;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Projeto.AutomationPractice.Passos
{
    [Binding]
    public class AutomationPracticeSteps
    {
        private readonly ElementosDaPagina _elementosDaPagina;
        public AutomationPracticeSteps()
        {
            var navegador = TestRunSingleBrowserHooks.RetornarDriver(Config.URL_PAGINA);
            _elementosDaPagina = new ElementosDaPagina(navegador);
        }

        [Given(@"que estou na página inicial")]
        public void DadoQueEstouNaPaginaInicial()
        {
            var paginaInicial = _elementosDaPagina.pagina.Displayed;
            Assert.IsTrue(paginaInicial);
        }

        [When(@"digito o item tshit no campo de busca")]
        public void QuandoDigitoOItemTshitNoCampoDeBusca()
        {
            var campoPesquisa = _elementosDaPagina.campoPesquisa;
            campoPesquisa.Click();
            campoPesquisa.SendKeys("T-SHIRT");
        }
        [When(@"clico no botão de pesquisa")]
        public void QuandoClicoNoBotaoDePesquisa()
        {
            var botaoSubmit = _elementosDaPagina.botaoSubmit;
            botaoSubmit.Click();
        }

        [Then(@"tenho o resultado da pesquisa")]
        public void EntaoTenhoOResultadoDaPesquisa()
        {
            var resultadoDaPesquisa = _elementosDaPagina.resultadoTSHIRT.Displayed;
            Assert.IsTrue(resultadoDaPesquisa);
        }
        [Then(@"quando clico no resultado da pesquisa")]
        public void EntaoQuandoClicoNoResultadoDaPesquisa()
        {
            var resultadoDaPesquisa = _elementosDaPagina.resultadoTSHIRT;
            resultadoDaPesquisa.Click();
        }

        [Then(@"altero a cor do item")]
        public void EntaoAlteroACorDoItem()
        {
            var opcaoAzul = _elementosDaPagina.corAzul;
            opcaoAzul.Click();
        }

        [Then(@"clico no botao para adicionar item no carrinho")]
        public void EntaoClicoNoBotaoParaAdicionarItemNoCarrinho()
        {
            var botaoAdicionarNoCarrinho = _elementosDaPagina.botaoAdicionarNoCarrinho;
            botaoAdicionarNoCarrinho.Click();
        }

        [Then(@"tenho o resultado da pesquisa que contem o Nome, Quantidade e Preco")]
        public void EntaoTenhoOResultadoDaPesquisaQueContemONomeQuantidadeEPreco()
        {
            string nome = "Faded Short Sleeve T-shirts";
            string quantidade = "1";
            string preco = "$16.51";

            Assert.AreEqual(nome, "Faded Short Sleeve T-shirts");
            Assert.AreEqual(quantidade, "1");
            Assert.AreEqual(preco, "$16.51");
        }

        [Then(@"clico no botão para retornar para a pagina inicial")]
        public void EntaoClicoNoBotaoParaRetornarParaAPaginaInicial()
        {
            var botaoReturnToShopping = _elementosDaPagina.botaoContinueShopping;
            botaoReturnToShopping.Click();
        }

        [Then(@"digito o item blouse no campo de busca")]
        public void EntaoDigitoOItemBlouseNoCampoDeBusca()
        {
            var campoPesquisa = _elementosDaPagina.campoPesquisa;
            campoPesquisa.Clear();
            campoPesquisa.SendKeys("Blouse");

            var botaoPesquisar = _elementosDaPagina.botaoSubmit;
            botaoPesquisar.Click();
        }

        [Then(@"clico no resultado da busca")]
        public void EntaoClicoNoResultadoDaBusca()
        {
            var itemBlouse = _elementosDaPagina.resultadoBlouse;
            itemBlouse.Click();
        }

        [Then(@"clico no botao de adicionar no carrinho")]
        public void EntaoClicoNoBotaoDeAdicionarNoCarrinho()
        {
            var botaoAdicionarNoCarrinho = _elementosDaPagina.botaoAdicionarNoCarrinho;
            botaoAdicionarNoCarrinho.Click();
        }

        [Then(@"clico no botao para finalizar a compra")]
        public void EntaoClicoNoBotaoParaFinalizarACompra()
        {
            var botaoFinalizarCompra = _elementosDaPagina.botaoFecharCompra;
            botaoFinalizarCompra.Click();
        }
        [Then(@"o resultado deve ser o Nome, Quantidade e Preço de cada item")]
        public void EntaoOResultadoDeveSerONomeQuantidadeEPrecoDeCadaItem()
        {
           string nomeItemTshirt = "Faded Short Sleeve T-shirts";
           string quantidadeItemTshirt = "1";
           string precoItemTshirt = "$16.51";
           string nomeItemBlouse = "Blouse";
           string quantidadeItemBlouse = "1";
           string precoItemBlouse = "$27.00";

            var itemTshirtNome = _elementosDaPagina.itemTshirtNome.Displayed;
            var itemTshirtQuantidade = _elementosDaPagina.itemTshirtQuantidade.Displayed;
            var itemTshirtPreco = _elementosDaPagina.itemTshirtPreco.Displayed;
            var itemBlouseNome = _elementosDaPagina.itemBlouseNome.Displayed;
            var itemBlouseQuantidade = _elementosDaPagina.itemBlouseQuantidade.Displayed;
            var itemBlousePreco = _elementosDaPagina.itemBlousePreco.Displayed;

            Assert.IsTrue(itemTshirtNome);
            Assert.IsTrue(itemTshirtQuantidade);
            Assert.IsTrue(itemTshirtPreco);
            Assert.IsTrue(itemBlouseNome);
            Assert.IsTrue(itemBlouseQuantidade);
            Assert.IsTrue(itemBlousePreco);

            Assert.AreEqual(nomeItemTshirt, itemTshirtNome);
            Assert.AreEqual(quantidadeItemTshirt, itemTshirtQuantidade);
            Assert.AreEqual(precoItemTshirt, itemTshirtPreco);
            Assert.AreEqual(nomeItemBlouse, itemBlouseNome);
            Assert.AreEqual(quantidadeItemBlouse, itemBlouseQuantidade);
            Assert.AreEqual(precoItemBlouse, itemBlousePreco);
        }
    }
}