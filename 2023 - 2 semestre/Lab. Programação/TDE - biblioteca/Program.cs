Livro livro1 = new Livro();
livro1.titulo = "codigo da vinci";
livro1.autor = "dan brown";
livro1.status = true;

Livro livro2 = new Livro();
livro2.titulo = "inferno";
livro2.autor = "dan brown";
livro2.status = false;
2
Livro livro3 = new Livro();
livro3.titulo = "inferno";
livro3.autor = "George orwell";
livro3.status = false;

Biblioteca biblioteca = new Biblioteca();
biblioteca.AdicionarLivro(livro1);
biblioteca.AdicionarLivro(livro2);
biblioteca.AdicionarLivro(livro3);

int LivrosDisponiveis = biblioteca.qtdLivrosDisponiveis();

Console.WriteLine("Livros disponiveis:");