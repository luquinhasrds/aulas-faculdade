public class ArmazenamentoEmArquivos : IRepositorioDeDados {
    public void Salvar(){
        Console.WriteLine("Salvando em arquivos!");
    }
    public string Carregar(){
        return "Carregando no arquivo!";
    }
}