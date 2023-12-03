Biblioteca biblioteca1 = new Biblioteca(); //cria a biblioteca
Biblioteca biblioteca2 = new Biblioteca(); //cria a biblioteca


Livro livro1 = new Livro(1, "O Senhor Dos Aneis", "J.R.R", "Ação e ficção.");
Livro livro2 = new Livro(2, "Harry Potter e a Pedra Filosofal", "J.K", "Bruxos.");
Livro livro3 = new Livro(3, "Dom Quixote", "Seu João", "nao sei do que se trata o livro.");


biblioteca1.AdicionarItem(livro1);
biblioteca1.AdicionarItem(livro2);
biblioteca2.AdicionarItem(livro3);

biblioteca1.BuscarLivro(2);
biblioteca1.BuscarItemPorTitulo("O Senhor Dos Aneis");

livro1.ExibirDescricaoInterna();
livro2.ExibirDescricaoInterna();

biblioteca2.RemoverItem(livro3);