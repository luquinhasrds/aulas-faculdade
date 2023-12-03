public class ArmazenamentoemBD : IRepositoriodedados {
    public void Salvar(string dados){
        Console.WriteLine("salvando no banco de dados");
    }
    public string Carregar(){
        return "carregando no banco de dados";
    }
}