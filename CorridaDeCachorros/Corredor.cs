namespace CorridaDeCachorros;

public class Corredor : BaseModel
{
    protected static readonly Random Random = new();

    protected double _distanciaPercorrida { get; set; }

    public Posicoes Posicao { get; set; }

    public Corredor(int posicaoCorredor) : base()
    {
        Nome = $"Corredor-{posicaoCorredor}";
        _distanciaPercorrida = 0.0;
        Posicao = Posicoes.NaoGanho;
    }
    public Corredor (string nomeDoCorredor)
    {
        Nome = nomeDoCorredor;
        _distanciaPercorrida = 0.0;
        Posicao = Posicoes.NaoGanho;
    }

    public virtual void Mover()
    {
        int distanciaPercorrida = Random.Next(1, 6);

        _distanciaPercorrida += (distanciaPercorrida * 0.1);
    }

    public double DistanciaPercorrida()
    {
        return _distanciaPercorrida;
    }
}
