class Jogador{
    public string? Nome;
    public string? NickName;
    public int Pontos;

    public void Jogar(){
        Random rand = new Random();
        Pontos = rand.Next(1, 101);
    }
}
