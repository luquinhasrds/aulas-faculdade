public abstract class ItemBiblioteca{    //CLASS
    public int Id { get; set; }   //ID
    public string? Titulo { get; set; }  //TITULO
    protected string? DescricaoInterna { get; set; }  //DESCRIÇÃO

    public ItemBiblioteca(int id, string titulo){   //CONSTRUTOR
        this.Id = id;
        this.Titulo = titulo;
        DescricaoInterna = "descrição";
    }
}  //FECHAMENTO DA CLASSE
