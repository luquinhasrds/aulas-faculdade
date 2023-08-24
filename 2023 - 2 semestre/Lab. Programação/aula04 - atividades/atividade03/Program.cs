// 3. Faixas Etárias
// Crie um programa que leia a idade do usuário e categorize-a nas seguintes faixas etárias:
// Criança (0-12 anos)
// Adolescente (13-18 anos)
// Adulto (19-59 anos)
// Idoso (60 anos ou mais)


while(true){
    Console.WriteLine("digite sua idade: ");
    double numero = Convert.ToDouble(Console.ReadLine());

    switch(numero){
        case <= 0:
            Console.WriteLine("IMPOSSIVEL");
            break;
        case <= 12:
            Console.WriteLine("Criança");
            break;
        case <= 18:
            Console.WriteLine("Adolecente");
            break;
        case <= 59:
            Console.WriteLine("Adulto");
            break;
        case <= 60:
            Console.WriteLine("Idoso");
            break;
        default:
            break;
    }
}