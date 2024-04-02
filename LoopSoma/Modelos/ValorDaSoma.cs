namespace LoopSoma.Modelos;

internal class ValorDaSoma
{
    private int Indice = 13;
    private int K = 0;
    public int Soma = 0;

    public int Somar()
    {
        while (K < Indice)
        {
            K++;
            Soma += K;
        }

        return Soma;
    }
}
