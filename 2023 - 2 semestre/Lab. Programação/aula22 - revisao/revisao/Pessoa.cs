public abstract class Pessoa{
    public string? Endereco {get; set;}
    public string?Telefone {get; set;}
    public string? Nome {get; set;}

    protected int NumeroConta {get; set;}
    public virtual void Salvar(){
        Console.WriteLine("salvando pessoa");
    }

    public abstract void Excluir();

    public int getNumeroConta(){
        return NumeroConta;
    }
    
    
}