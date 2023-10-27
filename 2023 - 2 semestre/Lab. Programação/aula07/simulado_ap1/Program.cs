do{ //SISTEMA DE REPETIÇÃO

    //PEDE O NOME
    Console.WriteLine("Digite o nome do aluno:");
    string nome = Console.ReadLine();

    //PEDE A IDADE
    Console.WriteLine("Digite a idade: ");
    double idade = Convert.ToDouble(Console.ReadLine());

    //PEDE A ALTURA
    Console.WriteLine("Digite a altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    //PEDE O PESO
    Console.WriteLine("Digite o peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    //CALCULA O IMC 
    double imc = peso / (altura*altura);

    //VE EM QUAL CATEGORIA O IMC CALCULADO SE ENCAIXA
    switch (imc)
    {
        case <= 18:
            Console.WriteLine("baixo peso");
            break;
        case <= 24:
            Console.WriteLine("peso normal");
            break;
        case <= 29:
            Console.WriteLine("Sobrepeso");
            break;
        case <= 34:
            Console.WriteLine("obeso");
            break;
        default:
            break;
    }

    //VE A IDADE DA PESSOA E VE EM QUAL CATEGORIA SE ENCAIXA
    string faixa_etaria;
    if(idade <= 0){
        faixa_etaria = "IMPOSSIVEL";
    }if(idade <= 12){
        faixa_etaria = "Criança";
    }if(idade <= 18){
        faixa_etaria = "Adolecente";
    }if(idade <= 59){
        faixa_etaria = "Adulto";
    }if(idade >= 60){
        faixa_etaria = "Idoso";
    }else{
        faixa_etaria = "ai é complicado";
    }
    
    Console.WriteLine($" {nome}, {idade}, {imc}, {faixa_etaria}");
    //PERGUNTA AO USUARIO SE QUER REPETIR O CODIGO OU CONTINUAR
    Console.WriteLine("Quer calcular IMC de outra pessoa? (s/n)");
    string opcao = Console.ReadLine();
    if (opcao != "s"){
        Console.WriteLine("O programa sera fechado..............");
        break;
    }

}while(true); //SISTEMA DE REPETIÇÃO
