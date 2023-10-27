funcionario f1 = new funcionario();
    f1.nome = "carlos";
    f1.salario = 2000;
    f1.cargo = "frentista";

Console.WriteLine($"{f1.nome}, {f1.salario}, {f1.cargo}");

class funcionario{
    public string nome;
    public double salario;
    public string cargo;
}