public class Circulo : Forma{
    public int Raio;

    public Circulo(int raio){
        this.Raio = raio;
    }

    public override void CalcularArea(){
        Console.WriteLine($"a area do circulo é {Math.PI*(Raio*Raio)}");
    }
}