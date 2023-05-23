namespace CalculadoraLib.Tests.nUnit
{
    public class CalculadoraNUnit
    {
        private CalculadoraSimples _calculadora;
        [SetUp]
        public void Setup()
        {
             _calculadora = new CalculadoraSimples();
        }

        [TestCase(1, 2, 3)]
        public void TestaSoma(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Soma(numeroEsquerdo, numeroDireita);
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [TestCase(1, 2, -1)]
        public void TestaSubtracao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Subtracao(numeroEsquerdo, numeroDireita);
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [TestCase(2, 1, 2)]
        public void TestaDivisao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Divisao(numeroEsquerdo, numeroDireita);
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }

        [Test]
        public void TestaDivisaoPorZeroException()
        {
            Assert.Throws<ArgumentException>(() => _calculadora.Divisao(5, 0));
        }


        [TestCase(1, 2, 2)]
        public void TestaMultiplicacao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Multiplicacao(numeroEsquerdo, numeroDireita);
            Assert.That(resultado, Is.EqualTo(resultadoEsperado));
        }
    }
}