// 10. Temperatura
// Peça ao usuário para inserir uma temperatura. Classifique e exiba a seguinte mensagem:
// Abaixo de 0: “Congelando!”
// 0 a 15: “Frio!”
// 16 a 25: “Clima agradável!”
// 26 a 35: “Calor!”
// Acima de 35: “Muito quente!”


while(true){
    Console.WriteLine("Digite uma temperatura:");
    double temp = Convert.ToDouble(Console.ReadLine());

    switch(temp){
        case < 0:
            Console.WriteLine("CONGELANDO!");
            break;
        case <= 15:
            Console.WriteLine("FRIO!");
            break;
        case <= 25:
            Console.WriteLine("Clima agradavel!");
            break;
        case <= 35:
            Console.WriteLine("Calor!");
            break;
        case > 35:
            Console.WriteLine("MUITO QUENTE!");
            break;
    }
}