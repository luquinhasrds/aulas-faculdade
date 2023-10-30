public class Equipe{
    public string? nomeDaEquipe;
    public List<Jogador> jogadores;

    public Equipe(){
        jogadores = new List<Jogador>();
    }

    public int PontosTotal(){
        return jogadores.Sum(jogador => jogador.pontos);
    }

    public void AdicionarJogadores(Jogador jogador){
        if(jogadores.Count < 5){
            jogadores.Add(jogador);
            Console.WriteLine($"Jogador {jogador.nome} adicionado à equipe '{nomeDaEquipe}'.");
        }else{
            Console.WriteLine($"A equipe '{nomeDaEquipe}' já tem 5 jogadores. Não é possível adicionar mais jogadores.");
        }
    }
}