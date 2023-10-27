/*
Console.WriteLine("Digite um numero para ver a tabuada:");
int numero = Convert.ToInt32(Console.ReadLine());

for (int n = 1; n<=10; n++){
    int resultado = numero * n;
    Console.WriteLine($"o resultado de {numero} * {n} = {resultado}");
}

--------------------------------------------------

int soma = 0;
for (int i=0; i<=10; i++){
    soma = soma + i;
}
Console.WriteLine(soma);

------------------------------------------------------


---------------------------------------------
int numero = 0;
while(numero <= 5){
    Console.WriteLine(numero);
    numero ++;
}
--------------------------------------------------


-------------------------------------------------------
int numero_secreto = 8;
int palpite;
do{
    Console.WriteLine("digite um numero:");
    palpite = Convert.ToInt32(Console.ReadLine());
}while(palpite != numero_secreto);
Console.WriteLine("parabens voce adivinhou ");

----------------------------------------------------------

*/

#------------------------------------------------------------
int num;
do{
    Console.WriteLine("Informe um número maior que 5");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Você digitou o número {num} ");
} while (num > 5);
#------------------------------------------------------------
