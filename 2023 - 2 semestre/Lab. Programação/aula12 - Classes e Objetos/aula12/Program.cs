/*
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



Produto p1 = new Produto();
    p1.nome = "escada";
    p1.preco = 35.90;
    p1.categoria = "serviços";

Produto p2 = new Produto();
    p2.nome =  "liquidificador";
    p2.preco = 105.99;
    p2.categoria = "sei la";

Produto p3 = new Produto();
    p3.nome =  "batata";
    p3.preco = 5.99;
    p3.categoria = "verdura";

Mercado mercado = new Mercado();
mercado.nome = "Max";
mercado.endereco = "Avenida 1 2 3 4";
mercado.produto1 = p1;  
mercado.produto2 = p2;
mercado.produto3 = p3;
Console.WriteLine($"{mercado.nome}{mercado.endereco}{mercado.produto1.nome}{mercado.produto2.nome}{mercado.produto3.nome}");

class Produto{
    public string? nome;
    public double preco;
    public string? categoria;
}

class Mercado{
    public string? nome;
    public string? endereco;
    public Produto produto1;
    public Produto produto2;
    public Produto produto3;
}

*/

estudante e1 = new estudante();
    e1.nome = "lucas";
    e1.idade = 21;
estudante e2 = new estudante();
    e2.nome = "rafael";
    e2.idade = 23;

estudante e3 = new estudante();
    e3.nome = "julio";
    e3.idade = 42;

turma t1 = new turma();
    t1.numeroTurma = 325;
    t1.estudante1 = e1;
    t1.estudante2 = e2;
    t1.estudante3 = e3;

Console.WriteLine($"{t1.numeroTurma}, {t1.estudante1.nome}, {t1.estudante2.nome}, {t1.estudante3.nome}");
class estudante
{
    public string? nome;
    public int idade;
}

class turma
{
    public int numeroTurma;
    public estudante estudante1;
    public estudante estudante2;
    public estudante estudante3;
}

