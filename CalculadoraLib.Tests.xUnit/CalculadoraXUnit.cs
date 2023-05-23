namespace CalculadoraLib.Tests.xUnit
{
    public class CalculadoraXUnit
    {
        private readonly CalculadoraSimples _calculadora = new();

        [Theory]
        [InlineData(1, 2, 3)]
        public void TestaSoma(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Soma(numeroEsquerdo, numeroDireita);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestaSubtracao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Subtracao(numeroEsquerdo, numeroDireita);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        public void TestaDivisao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Divisao(numeroEsquerdo, numeroDireita);
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void TestaDivisaoPorZeroException()
        {
            Assert.Throws<ArgumentException>(() => _calculadora.Divisao(5, 0));
        }

        [Theory]
        [InlineData(1, 2, 2)]
        public void TestaMultiplicacao(int numeroEsquerdo, int numeroDireita, int resultadoEsperado)
        {
            var resultado = _calculadora.Multiplicacao(numeroEsquerdo, numeroDireita);
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}