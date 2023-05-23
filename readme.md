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

- Esse � um projeto de calculadora simples desenvolvida com intuito de demonstrar o uso de testes unit�rios para os frameworks MSTest, nUnit e xUnit. A biblioteca de calculadora pode ser evolu�da com uma proposta de opera��es simples e eficientes de forma direta, caso considerem �til.
- A solu��o � estruturada da seguinte forma
	-	**CalculadoraLib.Sln**
		- **CalculadoraLib:** N�cleo das opera��es dispon�veis na biblioteca.
		- **CalculadoraLib.Tests.MSTest:** Testes unit�rios feitos usando o MSTest framework.
		- **CalculadoraLib.Tests.nUnit:**  Testes unit�rios feitos usando o nUnit framework.
		- **CalculadoraLib.Tests.xUnit:**  Testes unit�rios feitos usando o xUnit framework.


Como utilizar a biblioteca CalculadoraLib
-------------------

1. Adicione a refer�ncia ao projeto CalculadoraLib. 
2. Adicione o namespace CalculadoraLib
3. Instancie um objeto Calculadora e a partir da inst�ncia, basta chamar os m�todos dispon�veis.

**Exemplo:**

```csharp
//Adicionando o using da lib
using CalculadoraLib;

//Instanciando um objeto Calculadora
var calc = new CalculadoraSimples();

//Opera��o de soma
calc.Soma(2, 1); //Resultado esperado = 3

//Opera��o de subtra��o
calc.Subtracao(2, 1); //Resultado esperado = 1

//Opera��o de multiplica��o
calc.Divisao(2, 1); //Resultado esperado = 2

//Opera��o de divis�o
calc.Multiplicacao(2, 1); //Resultado esperado = 2
```

Essa � a melhor calculadora?
-------------------

Analisando o c�digo fonte do projeto voc� consegue apontar melhorias ou limita��es?

<details>N�o � pr�tico ficar dependendo de um m�todo com apenas dois par�metros, e se quisermos somar mais de 2 n�meros? Qu�o pr�tico essa biblioteca seria? <summary>1� reflex�o</summary>	</details>
<details>Os tipos de dados escolhidos para os campos, s�o suficientes? Use uma das classes de testes e coloque os dois par�metros como Int32.MaxValue.<summary>2� reflex�o</summary></details>

Licen�a
-------

Aplica��o dispon�vel sob licen�a [MIT Licensed](LICENSE).


Sobre o autor 
----------------

Saiba mais sobre os meus projetos por [AQUI](https://github.com/MuilaerteJunior).


Incentivos
------
  
Ol�, se gostou do projeto e quiser realizar qualquer contribui��o, segue o link para doa��o. Fica aqui meus agradecimentos antecipados, obrigado!

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
