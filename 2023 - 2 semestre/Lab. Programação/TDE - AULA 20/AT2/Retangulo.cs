public class Retangulo : Forma{
    public int base1;
    public int altura;

    public Retangulo(int Base1, int Altura){
        this.base1 = Base1;
        this.altura = Altura;
    }
    public override void CalcularArea(){
        Console.WriteLine($"a area do retangulo é {base1*altura}");
    }
}