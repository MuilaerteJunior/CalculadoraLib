<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]


# CalculadoraLib (Simples calculadora)

- Esse é um projeto de calculadora simples desenvolvida com intuito de demonstrar o uso de testes unitários para os frameworks MSTest, nUnit e xUnit. A biblioteca de calculadora pode ser evoluída com uma proposta de operações simples e eficientes de forma direta, caso considerem útil.
- A solução é estruturada da seguinte forma
	-	**CalculadoraLib.Sln**
		- **CalculadoraLib:** Núcleo das operações disponíveis na biblioteca.
		- **CalculadoraLib.Tests.MSTest:** Testes unitários feitos usando o MSTest framework.
		- **CalculadoraLib.Tests.nUnit:**  Testes unitários feitos usando o nUnit framework.
		- **CalculadoraLib.Tests.xUnit:**  Testes unitários feitos usando o xUnit framework.


Como utilizar a biblioteca CalculadoraLib
-------------------

1. Adicione a referência ao projeto CalculadoraLib. 
2. Adicione o namespace CalculadoraLib
3. Instancie um objeto Calculadora e a partir da instância, basta chamar os métodos disponíveis.

**Exemplo:**

```csharp
//Adicionando o using da lib
using CalculadoraLib;

//Instanciando um objeto Calculadora
var calc = new CalculadoraSimples();

//Operação de soma
calc.Soma(2, 1); //Resultado esperado = 3

//Operação de subtração
calc.Subtracao(2, 1); //Resultado esperado = 1

//Operação de multiplicação
calc.Divisao(2, 1); //Resultado esperado = 2

//Operação de divisão
calc.Multiplicacao(2, 1); //Resultado esperado = 2
```

Essa é a melhor calculadora?
-------------------

Analisando o código fonte do projeto você consegue apontar melhorias ou limitações?

<details>Não é prático ficar dependendo de um método com apenas dois parâmetros, e se quisermos somar mais de 2 números? Quão prático essa biblioteca seria? <summary>1ª reflexão</summary>	</details>
<details>Os tipos de dados escolhidos para os campos, são suficientes? Use uma das classes de testes e coloque os dois parâmetros como Int32.MaxValue.<summary>2ª reflexão</summary></details>

Licença
-------

Aplicação disponível sob licença [MIT Licensed](LICENSE).


Sobre o autor 
----------------

Saiba mais sobre os meus projetos por [AQUI](https://github.com/MuilaerteJunior).


Incentivos
------
  
Olá, se gostou do projeto e quiser realizar qualquer contribuição, segue o link para doação. Fica aqui meus agradecimentos antecipados, obrigado!

[![Buy me a coffee](https://www.buymeacoffee.com/assets/img/guidelines/download-assets-sm-1.svg)](https://buymeacoffee.com/muilaertejunior)



<!-- MARKDOWN LINKS & IMAGES -->
[contributors-shield]: https://img.shields.io/github/contributors/MuilaerteJunior/CalculadoraLib.svg?style=for-the-badge
[contributors-url]:  https://github.com/MuilaerteJunior/CalculadoraLib/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/MuilaerteJunior/CalculadoraLib.svg?style=for-the-badge
[forks-url]:  https://github.com/MuilaerteJunior/CalculadoraLib/network/members
[stars-shield]: https://img.shields.io/github/stars/MuilaerteJunior/CalculadoraLib.svg?style=for-the-badge
[stars-url]:  https://github.com/MuilaerteJunior/CalculadoraLib/stargazers
[issues-shield]: https://img.shields.io/github/issues/MuilaerteJunior/CalculadoraLib.svg?style=for-the-badge
[issues-url]:  https://github.com/MuilaerteJunior/CalculadoraLib/issues
[license-shield]: https://img.shields.io/github/license/MuilaerteJunior/CalculadoraLib?style=for-the-badge
[license-url]:  https://github.com/MuilaerteJunior/CalculadoraLib/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/muilaerte-junior/
