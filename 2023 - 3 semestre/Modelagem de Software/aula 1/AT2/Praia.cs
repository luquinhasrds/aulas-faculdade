public class Praia{
    public string? nome { get; set; }
    public string localização { get; set; }
    public int temperaturaAgua { get; set; }
    public string tipoAreia { get; set; }

    public Praia(string nome, string localização, int temperaturaAgua, string tipoAreia){
        this.nome = nome;
        this.localização = localização;
        this.temperaturaAgua = temperaturaAgua;
        this.tipoAreia = tipoAreia;
    }

    public void InformacoesPraia(){
        Console.WriteLine($"Nome: {nome}\nLocalização: {localização}\nTemperatura da agua: {temperaturaAgua}\nTipo de areia: {tipoAreia}");
    }
}
