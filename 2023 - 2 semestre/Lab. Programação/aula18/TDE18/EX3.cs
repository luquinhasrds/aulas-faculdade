class Animal{
    public string? Nome {get; set;}
    public int Idade {get; set;}
    protected int NumeroDePatas {get; private set;}

    public Animal(string nome, int idade, int numeroDePatas){
        Nome = nome;
        Idade = idade;
        NumeroDePatas = numeroDePatas;
    }
    public virtual string emitirSom(){
        return "som de um animal";
    }
    protected void numeroDePatas(){
        Console.WriteLine($"esse animal tem {NumeroDePatas} patas.");
    }
}

class Cachorro : Animal{
    public Cachorro(string nome, int idade) : base(nome, idade, 4){
        Console.WriteLine($"Um novo cachorro chamado {nome} foi criado!");
    }
    public override string emitirSom(){
        numeroDePatas();
        Console.WriteLine($"o {Nome} esta miando");
        return "";
    }
}

class Gato : Animal{
    public Gato(string nome, int idade) : base(nome, idade, 4){

        Console.WriteLine($"Um novo gato chamado {nome} foi criado!");
    }
    public override string emitirSom(){
        numeroDePatas();
        Console.WriteLine($"o {Nome} esta miando");
        return "";
    }
}
