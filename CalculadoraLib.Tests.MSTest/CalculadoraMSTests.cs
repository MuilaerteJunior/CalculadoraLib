namespace CalculadoraLib.Tests.MSTest
{
    [TestClass]
    public class CalculadoraMSTests
    {
        private readonly CalculadoraSimples _calculadora = new();

        [TestMethod]
        [DataRow(1,2,3)]
        public void TestaSoma(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Soma(numeroEsquerdo, numeroDireita);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(1, 2, -1)]
        public void TestaSubtracao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Subtracao(numeroEsquerdo, numeroDireita);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [DataRow(2, 1 , 2)]
        public void TestaDivisao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Divisao(numeroEsquerdo, numeroDireita);
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestaDivisaoPorZeroException()
        {
            Assert.ThrowsException<ArgumentException>(() => _calculadora.Divisao(5,0));
        }

        [TestMethod]
        [DataRow(1, 2, 2)]
        public void TestaMultiplicacao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Multiplicacao(numeroEsquerdo, numeroDireita);
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}