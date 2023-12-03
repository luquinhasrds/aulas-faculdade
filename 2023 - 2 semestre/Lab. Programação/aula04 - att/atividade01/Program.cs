//1. Positivo, Negativo ou Zero?
//Escreva um programa que leia um número do usuário e determine se ele é positivo, negativo ou zero.

while(true){
    Console.WriteLine("Escreva um numero: ");
    double numero = Convert.ToDouble(Console.ReadLine());
    if(numero < 0){
        Console.WriteLine("o numero é negativo.");
    }if(numero > 0){
        Console.WriteLine("o numero é positivo.");
    }if(numero == 0){
        Console.WriteLine("o numero é zero");
    }
}

/*

while(true){
    Console.WriteLine("Escreva um numero: ");
    double numero = Convert.ToDouble(Console.ReadLine());

    switch(numero){
        case 0:
            Console.WriteLine("o numero é zero.");
            break;
        case > 0:
            Console.WriteLine("o numero é positivo.");
            break;
        case < 0:
            Console.WriteLine("o numero é negativo.");
            break;
        default:
        break;
    }
}

*/