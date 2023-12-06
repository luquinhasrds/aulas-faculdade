//fAZ A CRIAÇÃO DAS BIBLIOTECAS
Biblioteca biblioteca1 = new Biblioteca();
Biblioteca biblioteca2 = new Biblioteca();

//FAZ A CRIAÇÃO DOS LIVROS
Livro livro1 = new Livro(1, "O Senhor Dos Aneis", "J.R.R", "Ação e ficção.");  
Livro livro2 = new Livro(2, "Harry Potter e a Pedra Filosofal", "J.K", "Bruxos.");
Livro livro3 = new Livro(3, "Dom Quixote", "Seu João", "nao sei do que se trata o livro.");

//ADICIONA OS LIVROS EM SUAS RESPECTIVAS BIBLIOTECAS
biblioteca1.AdicionarItem(livro1);
biblioteca1.AdicionarItem(livro2);
biblioteca2.AdicionarItem(livro3);

//FAZA BUSCA CHAMANDO O METODO "BuscarLivro" PODENDO SER USADO COMO ARGUMENTO UM "ID" OU O TITULO DO LIVRO
biblioteca1.BuscarLivro(2);
biblioteca1.BuscarLivro("O Senhor Dos Aneis");

livro1.ExibirDescricaoInterna();
livro2.ExibirDescricaoInterna();

biblioteca2.RemoverItem(livro3);