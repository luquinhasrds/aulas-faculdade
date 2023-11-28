public class EmpregadoHorista : Empregado{
    public int HorasTrabalhadas;
    public int SalarioHora = 50;

    public EmpregadoHorista(int horasTrabalhadas){
        this.HorasTrabalhadas = horasTrabalhadas;
    }
    public override void CalcularSalario(){
        Console.WriteLine($"o salario do horista é de {HorasTrabalhadas*SalarioHora}");
    }
}