public class Livro : ItemBiblioteca{
    public string? Autor { get; set; }
    public Livro(int id, string titulo, string autor, string descricaoInterna) : base(id, titulo){
        this.Autor = autor;
        DescricaoInterna = descricaoInterna;
    }
    public void ExibirDescricaoInterna(){
        Console.WriteLine(DescricaoInterna);
    }
}