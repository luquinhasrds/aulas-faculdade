class Campeonato {
    public string? nomeCampeonato;
    public List<Equipe> equipesParticipanetes;

    public void IniciarPartida(List<Equipe> equipes){
        if(equipes.Count < 2){
            Console.WriteLine("O campeonato deve ter pelo menos 2 equipes para iniciar uma partida.");
            return;
        }
        foreach (var equipe in equipes){
            if (equipe.jogadores.Count != 5){
                Console.WriteLine($"A equipe {equipe.nomeDaEquipe} deve ter exatamente 5 jogadores para iniciar a partida.");
            }else{
                Console.WriteLine($"a aprtida vai comecar para a equipe {equipe.nomeDaEquipe}.");
            foreach (var jogador in equipe.jogadores)
                {
                    jogador.Jogar();
                    Console.WriteLine($"Jogador {jogador.Nome} obteve {jogador.Pontos} pontos.");
                }
            }
        }
    }
}