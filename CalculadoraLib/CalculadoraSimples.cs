namespace CalculadoraLib
{
    public sealed class CalculadoraSimples : ICalculadora
    {
        public int Soma(int numeroEsquerdo, int numeroDireita)
        {
            return numeroEsquerdo + numeroDireita;
        }

        public int Subtracao(int numeroEsquerdo, int numeroDireita)
        {
            return numeroEsquerdo - numeroDireita;
        }

        public int Divisao(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divisor não pode ser zero");

            return dividendo / divisor;
        }

        public int Multiplicacao(int numeroEsquerdo, int numeroDireita)
        {
            return numeroEsquerdo * numeroDireita;
        }

    }
}