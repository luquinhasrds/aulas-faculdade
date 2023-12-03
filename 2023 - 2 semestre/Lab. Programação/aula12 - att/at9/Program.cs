smartphone t1 = new smartphone();
    t1.marca = "sansung";
    t1.modelo = "m52";
    t1.anoLancamento = 2020;

Console.WriteLine($"{t1.marca}, {t1.modelo}, {t1.anoLancamento}");

class smartphone{
    public string marca;
    public string modelo;
    public int anoLancamento;
}