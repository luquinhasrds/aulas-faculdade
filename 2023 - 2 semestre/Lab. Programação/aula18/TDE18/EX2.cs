/*
class Animal{
    public string? Nome {get; set;}
    public int Idade {get; set;}

    public Animal(string nome, int idade){
        Nome = nome;
        Idade = idade;
    }
    public virtual string emitirSom(){
        return "som de um animal";
    }
}

class Cachorro : Animal{
    public Cachorro(string nome, int idade) : base(nome, idade){
        Console.WriteLine($"Um novo cachorro chamado {nome} foi criado!");
    }
    public override string emitirSom(){
        return $"o {Nome} esta latindo!!";
    }
}

class Gato : Animal{
    public Gato(string nome, int idade) : base(nome, idade){
        Console.WriteLine($"Um novo gato chamado {nome} foi criado!");
    }
    public override string emitirSom(){
        return $"o {Nome} esta miando";
    }
}
*/