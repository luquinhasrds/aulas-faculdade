// AT2
/*
string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine($"{nome} tem {idade} anos e nota" + nota);



// AT2

string nome = "Paulo";
int idade = 17;
double nota = 7.5;
string mensagem = $"{nome}\n{idade}\n{nota}";
Console.WriteLine(mensagem);



// AT3
Console.WriteLine("Escreva uma letra:");
string letra1 = Console.ReadLine();
Console.WriteLine("Escreva outra letra:");
string letra2 = Console.ReadLine();
Console.WriteLine("Escreva uma letra:");
string letra3 = Console.ReadLine();
Console.WriteLine($"as letras são: {letra3} { letra2} { letra1}");



//AT4

while(true){
    Console.WriteLine("Digite um numero:");
    double numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite outro numero:");
    double numero2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("[1] soma ");
    Console.WriteLine("[2] Multiplicação ");
    Console.WriteLine("[3] Exponenciação ");
    Console.WriteLine("[4] Subtração ");
    Console.WriteLine("[5] Divisão ");
    Console.WriteLine("[6] Modulo ");
    Console.WriteLine("escolha alguma das opções:");
    double opcao = Convert.ToDouble(Console.ReadLine());
    if(opcao == 1){
        double soma = numero1+numero2;
        Console.WriteLine($"A soma dos numeros é {soma}");
    }if(opcao == 2){
        double multiplicacao = numero1*numero2;
        Console.WriteLine($"A multiplicação é {multiplicacao}");
    }if(opcao == 3){
        Console.WriteLine("qual dos numeros e a base?");
        Console.WriteLine($"[1] - {numero1} ou [2] - {numero2}");
        double opcao_expo = Convert.ToDouble(Console.ReadLine());
        while(true){
            if(opcao_expo == 1){
                double resultado = Math.Pow(numero1, numero2);
                Console.WriteLine($"O resultado é {resultado}");
                break;
            }if(opcao_expo == 2){
                double resultado = Math.Pow(numero2, numero1);
                Console.WriteLine($"O resultado é {resultado}");
                break;
            }else{
                Console.WriteLine("Digite um numero correspondente!!!");
                continue;
            }
        }
    }if(opcao == 4){
            double sub = numero1-numero2;
        Console.WriteLine($"A subtração dos numeros é {sub}");
    }if(opcao == 5){
            double divisao = numero1/numero2;
        Console.WriteLine($"A divisão dos numeros é {divisao}");
    }if(opcao == 6){
            double modulo = numero1%numero2;
        Console.WriteLine($"O modulo dos numeros é {modulo}");
    }
}



//AT 5

//bhaskara = (-b +- raiz(delta))/2*a
//delta = b**2 - 4*a*c

double a = 1;
double b = 12;
double c = -13;

double r_delta = Math.Sqrt(b*b-4*a*c);

double x1 = (-b + r_delta)/(2*a);
double x2 = (-b - r_delta)/(2*a);

Console.WriteLine($"Raiz (x1) = {x1}");
Console.WriteLine($"Raiz (x2) = {x2}");

*/

//AT6

while (true){
    Console.WriteLine("Digite o seu nome:");
    String nome = Console.ReadLine();
    Console.WriteLine("Digite a sua senha:");
    int senha = Convert.ToInt32(Console.ReadLine());

    if(nome == "maria" || nome == "admin" && senha == 123 ){
        Console.WriteLine("Login feito com sucesso");
        break;
    }else{
        Console.WriteLine("Login inválido");
    }
}

/*

//AT7

Console.WriteLine("Digite um numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite outro numero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

string verifica1 = numero1 % 2 == 0 ? "par" : "ímpar";
string verifica2 = numero2 % 2 == 0 ? "par" : "ímpar";

Console.WriteLine($"o primeiro numero é {verifica1} e o segundo numero é {verifica2}");

*/