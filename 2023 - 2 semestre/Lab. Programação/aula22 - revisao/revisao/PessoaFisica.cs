public class PessoaFisica : Pessoa, Ipessoa{
    public string? Cpf {get; set;}
    public int Rg {get; set;}

    public PessoaFisica(){
        NumeroConta = 0000;
    }

    public void AbrirConta(){
        Console.WriteLine("ABRINDO CONTA!");
    }

    public void FecharConta(){
        Console.WriteLine("FECHANDO CONTA!!!");
    }

    public void Salvar(string algum){
        Console.WriteLine("salvando " + algum);
    }

    public override void Excluir(){
        Console.WriteLine("Exvcluindo pessoa fisica");
    }
}