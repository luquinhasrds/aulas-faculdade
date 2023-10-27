Produto p1 = new Produto();
    p1.nome = "escada";
    p1.preco = 35.90;
    p1.categoria = "serviços";

Console.WriteLine($"{p1.nome}, {p1.preco}, {p1.categoria}");

class Produto{
    public string? nome;
    public double preco;
    public string? categoria;
}