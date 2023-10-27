Animal a1 = new Animal();
    a1.especie = "tamandua";
    a1.nome = "bandeira";
    a1.idade = 15;

Animal a2 = new Animal();
    a2.especie = "tartaruga";
    a2.nome = "ninja";
    a2.idade = 50;

Console.WriteLine($"{a1.especie}, {a1.nome}, {a1.idade}\n{a2.especie}, {a2.nome}, {a2.idade}");

class Animal{
    public string especie;
    public string nome;
    public int idade;
}