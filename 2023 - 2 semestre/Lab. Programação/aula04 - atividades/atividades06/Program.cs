// 6. Avaliação de Notas
// Solicite ao usuário que insira uma nota (0-100). Classifique a nota nas seguintes categorias:
// A (90-100)
// B (80-89)
// C (70-79)
// D (60-69)
// F (0-59)


while(true){
    Console.WriteLine("digite sua nota (0-100): ");
    double numero = Convert.ToDouble(Console.ReadLine());

    switch(numero){
        case < 0:
            Console.WriteLine("NUMERO MENOR QUE 0 !!!");
            break;
        case <= 59:
            Console.WriteLine("F");
            break;
        case <= 69:
            Console.WriteLine("D");
            break;
        case <= 79:
            Console.WriteLine("C");
            break;
        case <= 89:
            Console.WriteLine("B");
            break;
        case <= 100:
            Console.WriteLine("A");
            break;
        case > 100:
            Console.WriteLine("NUMERO MAIS QUE 100!!!");
            break;
        default:
            break;
    }
}