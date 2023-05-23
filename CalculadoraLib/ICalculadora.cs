namespace CalculadoraLib
{
    public interface ICalculadora
    {
        int Divisao(int dividendo, int divisor);
        int Multiplicacao(int numeroEsquerdo, int numeroDireita);
        int Soma(int numeroEsquerdo, int numeroDireita);
        int Subtracao(int numeroEsquerdo, int numeroDireita);
    }
}