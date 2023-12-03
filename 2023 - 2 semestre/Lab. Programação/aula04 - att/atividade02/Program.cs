//2. Dia da Semana
//Peça ao usuário para inserir um número de 1 a 7. Seu programa deve exibir o dia da semana correspondente,
//onde 1 é domingo e 7 é sábado. Se o número estiver fora desse intervalo, exiba uma mensagem de erro.

while(true){
    Console.WriteLine("digite um numero de 1 a 7..");
    double numero = Convert.ToDouble(Console.ReadLine());

    switch(numero){
        case 1:
            Console.WriteLine("Domingo");
            break;
        case 2:
            Console.WriteLine("Segunda-feira");
            break;
        case 3:
            Console.WriteLine("Terça-feira");
            break;
        case 4:
            Console.WriteLine("Quarta-feira");
            break;
        case 5:
            Console.WriteLine("Quinta-feira");
            break;
        case 6:
            Console.WriteLine("Sexta-feira");
            break;
        case 7:
            Console.WriteLine("Sabado");
            break;
        case > 7:
            Console.WriteLine("DIGITE UM NUMERO ENTRE 1 E 7 !!!!");
            continue;
        case < 1:
            Console.WriteLine("DIGITE UM NUMERO ENTRE 1 E 7 !!!!");
            continue;
        default:
            break;
    }
}