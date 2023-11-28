public class TocadorDeMusica : Ireproduzir{
    public void Reproduzir(string nome){
        Console.WriteLine($"a musica {nome} esta reproduzindo");
    }
    public void Parar(string nome){
        Console.WriteLine($"a musica {nome} esta parando");
    }
    public void Pausar(string nome){
        Console.WriteLine($"a musica {nome} esta parando.");
    }
}