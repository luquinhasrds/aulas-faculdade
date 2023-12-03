public abstract class ItemBiblioteca{
    public int Id { get; set; }
    public string? Titulo { get; set; }
    protected string? DescricaoInterna { get; set; }

    public ItemBiblioteca(int id, string titulo){
        this.Id = id;
        this.Titulo = titulo;
        DescricaoInterna = "descrição";
    }
}