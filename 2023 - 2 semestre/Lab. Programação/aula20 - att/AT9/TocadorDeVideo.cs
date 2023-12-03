public class TocadorDeVideo : Ireproduzir{
    public void Reproduzir(string nome){
        Console.WriteLine("o video esta reproduzindo");
    }
    public void Parar(string nome){
        Console.WriteLine("o video esta parando");
    }
    public void Pausar(string nome){
        Console.WriteLine("o video esta parando.");
    }
}