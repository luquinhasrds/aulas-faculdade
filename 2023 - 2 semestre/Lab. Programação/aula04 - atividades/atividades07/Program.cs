// 7. Meses do Ano
// Peça ao usuário para inserir um número de 1 a 12.
// Exiba o mês correspondente ao número. Se o número estiver fora desse intervalo, mostre uma mensagem de erro.



while(true){
    Console.WriteLine("Digite um mes (1-12)");
    double mes = Convert.ToDouble(Console.ReadLine());

    switch(mes){
        case 0:
            Console.WriteLine("somente numeros entre 1 e 12");
            break;
        case 1:
            Console.WriteLine("Janeiro");
            break;
        case 2:
            Console.WriteLine("Fevereiro");
            break;
        case 3:
            Console.WriteLine("Março");
            break;
        case 4:
            Console.WriteLine("Abril");
            break;
        case 5:
            Console.WriteLine("maio");
            break;
        case 6:
            Console.WriteLine("Junho");
            break;
        case 7:
            Console.WriteLine("Julho");
            break;
        case 8:
            Console.WriteLine("Agosto");
            break;
        case 9:
            Console.WriteLine("Setembro");
            break;
        case 10:
            Console.WriteLine("Outubro");
            break;
        case 11:
            Console.WriteLine("Novembro");
            break;
        case 12:
            Console.WriteLine("Dezembro");
            break;
        case > 12:
            Console.WriteLine("somente numeros entre 1 e 12");
            break;
        default:
            break;
    }
}