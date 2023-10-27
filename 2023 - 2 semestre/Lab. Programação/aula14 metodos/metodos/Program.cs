/*
Pessoa pessoa = new Pessoa();
pessoa.Saudacao("Pele", "18/02/2002");
*/


Calculadora calculadora =  new Calculadora();
//int resultado = calculadora.Somar(2, 2);
//Console.WriteLine(resultado);
Console.WriteLine(calculadora.Somar(2, 2));
//int resultado2 = calculadora.Somar(10, 5, 5);
//Console.WriteLine(resultado2);
Console.WriteLine(calculadora.Somar(5, 5, 5));
//int resultado3 = calculadora.Somar(10.2, 10.3);
//Console.WriteLine(resultado3);
Console.WriteLine(calculadora.Somar(10.2, 10.3));


Console.WriteLine(calculadora.Subtrair(3, 3));
Console.WriteLine(calculadora.Mult(2, 5));

Mensagem m1 = new Mensagem();
m1.Exibir();

Quadrado q1 = new Quadrado();
q1.numero = 2;
q1.CalcularQuadrado();