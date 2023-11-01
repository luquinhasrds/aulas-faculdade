public class Jogador{
    public string? nome;
    public string? nickName;
    public int pontos;

    public void Jogar(){
        Random rand = new Random();
        pontos = rand.Next(1, 101);
    }
}