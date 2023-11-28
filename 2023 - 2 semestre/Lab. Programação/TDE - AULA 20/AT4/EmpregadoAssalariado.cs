public class EmpregadoAssalariado : Empregado{
    public override void CalcularSalario(){
        Console.WriteLine($"o empregado assalariado ganha {Salario}");
    }
}