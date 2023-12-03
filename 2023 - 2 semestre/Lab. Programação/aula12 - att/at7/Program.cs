casa casa1 = new casa();
    casa1.quantidadeDeQuartos = 6;
    casa1.numero = 155;
    casa1.cor = "marrom";

Console.WriteLine($"{casa1.quantidadeDeQuartos}, {casa1.numero}, {casa1.cor}");

class casa{
    public int quantidadeDeQuartos;
    public int numero;
    public string cor;
}