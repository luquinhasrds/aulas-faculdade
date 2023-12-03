estudante e1 = new estudante();
    e1.nome = "eloir";
    e1.curso = "matematica";
    e1.idade = 60;

estudante e2 = new estudante();
    e2.nome = "eloisio";
    e2.curso = "ads";
    e2.idade = 90;

Console.WriteLine($"{e1.nome}, {e1.curso}, {e1.idade}\n{e2.nome}, {e2.curso}, {e2.idade}");

class estudante{
    public string nome;
    public string curso;
    public int idade;
}