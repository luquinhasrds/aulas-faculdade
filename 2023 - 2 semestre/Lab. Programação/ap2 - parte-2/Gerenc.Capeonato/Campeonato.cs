public class Campeonato
{
    public string NomeCampeonato { get; set; }
    public List<Equipe> EquipesParticipantes { get; set; }

    public Campeonato()
    {
        NomeCampeonato = "";
        EquipesParticipantes = new List<Equipe>();
    }

    public void AdicionarEquipe(Equipe equipe)
    {
        EquipesParticipantes.Add(equipe);
    }

    public void IniciarPartida(Equipe equipe1, Equipe equipe2)
    {
        if (equipe1.jogadores.Count != 5 || equipe2.jogadores.Count != 5)
        {
            Console.WriteLine("As equipes devem ter exatamente 5 jogadores para iniciar a partida.");
            return;
        }

        foreach (var jogador in equipe1.jogadores)
        {
            jogador.Jogar();
        }

        foreach (var jogador in equipe2.jogadores)
        {
            jogador.Jogar();
        }

        // Exiba a classificação após a partida
        List<Equipe> classificacao = Classificacao();
        Console.WriteLine("Classificação após a partida:");

        for (int i = 0; i < classificacao.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {classificacao[i].nomeDaEquipe}: {classificacao[i].PontosTotal()} pontos");
        }
    }

    public List<Equipe> Classificacao()
    {
        // Ordena as equipes com base na pontuação total em ordem decrescente
        List<Equipe> equipesClassificadas = EquipesParticipantes.OrderByDescending(equipe => equipe.PontosTotal()).ToList();
        return equipesClassificadas;
    }
}
