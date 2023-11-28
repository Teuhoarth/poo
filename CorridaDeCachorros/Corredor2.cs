
namespace CorridaDeCachorros;

public class Corredor2 : Corredor
{
    public Corredor2(string nomeDeCorredores) : base(nomeDeCorredores)
    {
    }

    public Corredor2(int posicaoCorredor) : base(posicaoCorredor)
    {
    }

    public override void Mover()
    {
        int distanciaPercorrida = Random.Next(0, 7);
        _distanciaPercorrida += (distanciaPercorrida * 0.1);
    }

}
