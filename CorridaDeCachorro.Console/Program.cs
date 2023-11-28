using CorridaDeCachorros;

var corridaDeCachorros = new CorridaDeCachorro();

string exit = "";
while (exit != "exit")
{
    Console.WriteLine("Aperte [1] para adicionar um apostador;\n" +
    "Aperte [2] para adicionar um corredor;\n" +
    "[exit] para sair");
    var texte = Console.ReadLine();
    if (texte == "1")
    {
        Console.WriteLine("Qual o nome do apostador? ");
        var nomeApostador = Console.ReadLine();
        corridaDeCachorros.AdicionarApostador(nomeApostador);

    } else if (texte == "2")
    {
        Console.WriteLine("Qual o nome do corredor? ");
        var nomeCorredor = Console.ReadLine();
        corridaDeCachorros.AdicionarCorredor(nomeCorredor);

    } else if (texte == "3")
    {
        Console.WriteLine("");
    }
    {
        exit = texte;
    } 
} 