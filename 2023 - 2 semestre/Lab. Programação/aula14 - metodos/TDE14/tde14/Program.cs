
//AT1
Mensagem m1 = new Mensagem();
m1.Exibir();


//AT2
Quadrado q1 = new Quadrado();
q1.numero = 2;
q1.CalcularEImprimirquadrado();

//AT3
CalculadoraSimples calculadora =  new CalculadoraSimples();
Console.WriteLine(calculadora.Somar(2, 2));
Console.WriteLine(calculadora.Somar(5, 5, 5));

//AT4
Concatenador c1 = new Concatenador();
Console.WriteLine(c1.Concatenar("lucas","rosa"));
Console.WriteLine(c1.Concatenar("lucas", "rosa", "santos" ));

//AT5
ConversorTemperatura convert = new ConversorTemperatura();
convert.temperaturaCelcius = 25;
convert.ConverterParaFahrenheit();


//AT6
Data data = new Data();
data.ano = 2002;
data.mes = 02;
data.dia = 18;
data.imprimirDataFormatada();


//AT7
CalculadoraArea area1 = new CalculadoraArea();
Console.WriteLine(area1.calcularAreaCirculo(5));
Console.WriteLine(area1.calcularAreaQuadrado(5));


//AT8
Tabuada tb1 = new Tabuada();
tb1.numeroBase = 8;
tb1.imprimirTabuada();

