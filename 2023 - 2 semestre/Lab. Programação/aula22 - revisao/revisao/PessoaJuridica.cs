
//haranca
//polimorfismo
//encapsulamento
//abstração



public class PessoaJuridica : Pessoa{
    public string? Cnpj {get; set;}

    public PessoaJuridica(){
        NumeroConta = 1111;
    }
    
    public void AbrirConta(){
        Console.WriteLine("ABRINDO CONTA!");
    }

    public void FecharConta(){
        Console.WriteLine("FECHANDO CONTA!!!");
    }
    public override void Salvar(){
        Console.WriteLine("salvando pessoa juridica");
    }

    public override void Excluir(){
        Console.WriteLine("excluido pessoa juridica");
    }
}