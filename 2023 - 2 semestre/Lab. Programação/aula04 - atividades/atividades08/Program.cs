// 8. Maior Número
// Solicite ao usuário que insira três números. Determine e exiba o maior deles.


Console.WriteLine("digite o primeiro numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o segundo numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("digite o terceiro numero: ");
double n3 = Convert.ToDouble(Console.ReadLine());

/*

double maiornumero = n1;
if(n2 > maiornumero){
    maiornumero = n2;
}if(n3 > maiornumero){
    maiornumero = n3;
}
Console.WriteLine($"{maiornumero} é o maior numero");

*/

// -----  OU  -----


double maiornumero = Math.Max(Math.Max(n1, n2), n3);
Console.WriteLine($"o maior numero é {maiornumero}");