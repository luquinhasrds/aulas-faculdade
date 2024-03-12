public class Voo{
    public string companhiaAerea { get; set; }
    public string origem { get; set; }
    public string destino { get; set; }
    public string dataPartida { get; set; }
    public int precoPassagem { get; set; }

    public Voo(string companhiaAerea, string origem, string destino, string dataPartida, int precoPassagem){
        this.companhiaAerea = companhiaAerea;
        this.origem = origem;
        this.destino = destino;
        this.dataPartida = dataPartida;
        this.precoPassagem = precoPassagem;
    }

    public void informacoesVoo(){
        Console.WriteLine($"Companhia aerea: {companhiaAerea}\nOrigem: {origem}\nDestino: {destino}\nData de partida: {dataPartida}\nPreço passagem: {precoPassagem}");
    }

}