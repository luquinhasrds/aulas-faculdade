// 9. Tarifa de Ônibus
// Crie um programa que determine a tarifa de ônibus a ser paga pelo usuário com base em sua idade. As tarifas são:
// Crianças até 5 anos: grátis
// Crianças de 6 a 12 anos: 50% de desconto
// Adultos de 13 a 59 anos: tarifa completa
// Idosos (60 anos ou mais): grátis



Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

switch(idade){
    case <= 5:
        Console.WriteLine("Tarifa GRATIS");
        break;
    case <= 12:
        Console.WriteLine("Tarifa de ônibus com 50% DE DESCONTO");
        break;
    case <= 59:
        Console.WriteLine("Tarifa COMPLETA");
        break;
    case >= 60:
        Console.WriteLine("Tarifa GRATIS");
        break;
}