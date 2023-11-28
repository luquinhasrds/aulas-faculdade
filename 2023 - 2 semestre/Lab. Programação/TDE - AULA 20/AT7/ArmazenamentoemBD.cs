public class ArmazenamentoemBD : IRepositorioDeDados {
    public void Salvar(){
        Console.WriteLine("salvando no banco de dados");
    }
    public string Carregar(){
        return "carregando no banco de dados";
    }
}