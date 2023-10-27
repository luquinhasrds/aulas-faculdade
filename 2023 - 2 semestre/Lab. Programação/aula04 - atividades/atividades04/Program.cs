// 4. Ano Bissexto
// Peça ao usuário para inserir um ano e determine se é um ano bissexto ou não.
    
    Console.WriteLine("digite um ano: ");
    double ano = Convert.ToDouble(Console.ReadLine());

    if(ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0){
        Console.WriteLine("o ano é bissexto.");
    }else{
        Console.WriteLine("O ano nao é bissexto.");
    }