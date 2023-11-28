using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CorridaDeCachorros;



public class Corredor4 : Corredor3
{
    public Corredor4(string nomeDeCorredores) : base(nomeDeCorredores)
    {
    }

    public Corredor4(int posicaoCorredor) : base(posicaoCorredor)
    {
    }

    public override void Mover()
    {
        int distanciaPercorrida = Random.Next(2, 4);
        _distanciaPercorrida += (distanciaPercorrida * 0.1);
    }
}
