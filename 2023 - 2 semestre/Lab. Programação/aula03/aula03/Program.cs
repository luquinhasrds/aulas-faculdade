// Convertendo String //

/*
double num1 = 10.3;
string s1 = num1.ToString();
Console.WriteLine(s1);

double num1 = 10.3;
double num2 = (int)num1;


//entrada de dados//
Console.WriteLine("informe o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"o seu nome é {nome}");
Console.WriteLine("informe a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sua idade é {idade}");
*/


Console.WriteLine("informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"a soma de x e y é {x+y}");
// double divisao = (double)x/y;
// Console.WriteLine($"a divição de x e y é {divisao}");

Console.WriteLine($"rais quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"potenia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"valor minimo entre x e y = {Math.Min(x, y)}");
double valor = Math.PI;
