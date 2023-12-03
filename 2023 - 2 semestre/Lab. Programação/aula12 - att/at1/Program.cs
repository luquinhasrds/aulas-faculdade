Pessoa p1 = new Pessoa();
p1.nome = "lucas";
p1.idade = 21;
p1.cidadeNatal = "torres";
Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.cidadeNatal}");

Pessoa p2 = new Pessoa();
p2.nome = "jose";
p2.idade = 45;
p2.cidadeNatal = "Torresmo";
Console.WriteLine($"{p2.nome}, {p2.idade}, {p2.cidadeNatal}");

class Pessoa{
    public string? nome;
    public int idade;
    public string? cidadeNatal;
}