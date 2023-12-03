// 5. Calculadora Básica
// Escreva um programa que peça ao usuário dois números e uma operação
// (soma, subtração, multiplicação, divisão). Use uma estrutura switch para realizar a operação escolhida e exiba o resultado.
while(true){
    Console.WriteLine("------------------------------------");
    Console.WriteLine("DIGITE UM NUMERO: ");
    double n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("DIGITE OUTRO NUMERO: ");
    double n2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Escolha a opção que desejar: ");
    Console.WriteLine("[1] soma ");
    Console.WriteLine("[2] Subtração ");
    Console.WriteLine("[3] Multiplicação ");
    Console.WriteLine("[4] Divisão ");
    Console.WriteLine("------------------------------------");
    double opcao = Convert.ToDouble(Console.ReadLine());
    switch(opcao){
        case 1:
            double soma = n1+n2;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado de {n1}+{n2} = {soma}");
            Console.WriteLine("------------------------------------");
            break;
        case 2:
            double sub = n1-n2;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado de {n1}-{n2} = {sub}");
            break;
        case 3:
            double mult = n1*n2;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado de {n1}*{n2} = {mult}");
            break;
        case 4:
            double div = n1/n2;
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"O resultado de {n1}/{n2} = {div}");
            break;
        default:
            break;
    }
}