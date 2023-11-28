using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorridaDeCachorros;

public class Corredor3 : Corredor2
{
    public Corredor3(string nomeDeCorredores) : base(nomeDeCorredores)
    {
    }

    public Corredor3(int posicaoCorredor) : base(posicaoCorredor)
    {
    }
    public override void Mover()
    {
        int distanciaPercorida = Random.Next(3, 5);
        _distanciaPercorrida += (distanciaPercorida * 0.1);
    }
}
