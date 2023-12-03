carro c1 = new carro();
    c1.marca = "ford";
    c1.ano = 1995;
    c1.modelo = "escort";

carro c2 = new carro();
    c2.marca = "porche";
    c2.ano = 2023;
    c2.modelo = "cayenne";

carro c3 = new carro();
    c3.marca = "bmw";
    c3.ano = 2023;
    c3.modelo = "x6r";

Console.WriteLine($"{c1.marca}, {c1.ano}, {c1.modelo}. \n{c2.marca}, {c2.ano}, {c2.modelo}. \n{c3.marca}, {c3.ano}, {c3.modelo}.");

class carro{
    public string marca;
    public double ano;
    public string modelo;
}