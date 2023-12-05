public class Livro : ItemBiblioteca{  //CLASSE COM HERANÇA 
    public string? Autor { get; set; }  //AUTOR
    public Livro(int id, string titulo, string autor, string descricaoInterna) : base(id, titulo){  //CONSTRUTOR TRAZENDO A HERANCA
        this.Autor = autor;
        DescricaoInterna = descricaoInterna;
    }
    public void ExibirDescricaoInterna(){  //METODO PARA EXIBIR DESCRIÇÃO DO LIVRO
        Console.WriteLine(DescricaoInterna);
    }
}  //FECHAMENTO DA CLASSE
