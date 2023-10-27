curso c1 = new curso();
    c1.nome = "python";
    c1.duracao = 6;
    c1.professor = "paulo";

curso c2 = new curso();
    c2.nome = "java";
    c2.duracao = 1;
    c2.professor = "welington";

curso c3 = new curso();
    c3.nome = "poesia";
    c3.duracao = 8;
    c3.professor = "bete";

Console.WriteLine($"{c1.nome}, {c1.duracao}, {c1.professor}, {c2.nome}, {c2.duracao}, {c2.professor}, {c3.nome}, {c3.duracao}, {c3.professor},");

class curso{
    public string? nome;
    public double duracao;
    public string? professor;
}