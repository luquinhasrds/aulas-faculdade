Usuario usuario1 = new Usuario();
    usuario1.nome = "Pele";
    usuario1.endereco = "Rua da rosas";
    usuario1.telefone = "5998625304";
Usuario usuario2 = new Usuario();
    usuario2.nome = "Romario";
    usuario2.endereco = "Rua da ";
    usuario2.telefone = "5998625304";

Livro livro1 = new Livro();
    livro1.titulo = "Biografia De Maradona";
    livro1.autor = "Roberto carlos";
    livro1.anoPublicacao = 2010;
Livro livro2 = new Livro();
    livro2.titulo = "Biografia De Neymar";
    livro2.autor = "Roberto";
    livro2.anoPublicacao = 2020;

Emprestimo emprestimo1 = new Emprestimo();
    emprestimo1.usuario = usuario1;
    emprestimo1.livro = livro1;
    emprestimo1.dataEmprestimo = DateTime.Now;
    emprestimo1.dataDevolucao = DateTime.Now.AddMonths(1);
    livro1.disponivel = false;
Emprestimo emprestimo2 = new Emprestimo();
    emprestimo2.usuario = usuario2;
    emprestimo2.livro = livro2;
    emprestimo2.dataEmprestimo = new DateTime(2018, 02, 19);
    emprestimo2.dataDevolucao = emprestimo2.dataEmprestimo.AddMonths(3);
    livro2.disponivel = false;
Console.WriteLine($"Usuario: {emprestimo2.usuario.nome}\nLivro: {emprestimo2.livro.titulo}\nData de emprestimo: {emprestimo2.dataEmprestimo}\nData de devolução: {emprestimo2.dataDevolucao}");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"Usuario: {emprestimo1.usuario.nome}\nLivro: {emprestimo1.livro.titulo}\nData de emprestimo: {emprestimo1.dataEmprestimo}\nData de devolução: {emprestimo1.dataDevolucao}");




class Livro{
    public string? titulo;
    public string? autor;
    public int anoPublicacao;
    public bool disponivel;
}

class Usuario{
    public string? nome;
    public string? endereco;
    public string? telefone;
}

class Emprestimo{
    public Usuario usuario;
    public Livro livro;
    public DateTime dataEmprestimo;
    public DateTime dataDevolucao;
}