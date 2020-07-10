#language: pt
#encoding: iso-8859-1

Funcionalidade: 1 - Realizar Pesquisa
	Como um consumidor
	eu quero fazer uma pesquisa
	a fim de comprar uma roupa

Cenario: 001 - Realizar Pesquisa da peça T-SHIRT
Dado que estou na página inicial
Quando digito o item tshit no campo de busca
E clico no botão de pesquisa
Então tenho o resultado da pesquisa
E quando clico no resultado da pesquisa
E altero a cor do item
E clico no botao para adicionar item no carrinho
E tenho o resultado da pesquisa que contem o Nome, Quantidade e Preco
E clico no botão para retornar para a pagina inicial
E digito o item blouse no campo de busca
E clico no resultado da busca
E clico no botao de adicionar no carrinho
E clico no botao para finalizar a compra
E o resultado deve ser o Nome, Quantidade e Preço de cada item










