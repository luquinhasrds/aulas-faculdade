class Equipe{
    public string? nomeDaEquipe;
    public List<Jogador> jogadores;

    public int PontosTotal(){
        return jogadores.Sum(jogador => jogador.Pontos);
    }

    public void adicionarJogador(Jogador jogador){
        if(jogadores.Count < 5){
            jogadores.Add(jogador);
        }else{
            Console.WriteLine($"A equipe '{nomeDaEquipe}' já tem 5 jogadores. Não é possível adicionar mais jogadores.");
        }
    }
}