// Jogadores //
Jogador j1 = new Jogador();
j1.nome = "Jorge";
j1.nickName = "Jorginhoda12";
j1.Jogar();
j1.ExibirPontos();

Jogador j2 = new Jogador();
j2.nome = "Pedro";
j2.nickName = "matadordeonça";
j2.Jogar();
j2.ExibirPontos();

Jogador j3 = new Jogador();
j3.nome = "Mario";
j3.nickName = "OdoArmario";
j3.Jogar();
j3.ExibirPontos();

Jogador j4 = new Jogador();
j4.nome = "Diojines";
j4.nickName = "Senijoid";
j4.Jogar();
j4.ExibirPontos();

Jogador j5 = new Jogador();
j5.nome = "Jean";
j5.nickName = "Destruidor";
j5.Jogar();
j5.ExibirPontos();

Jogador j6 = new Jogador();
j6.nome = "Klaiton";
j6.nickName = "AirtonSena";
j6.Jogar();
j6.ExibirPontos();

Jogador j7 = new Jogador();
j7.nome = "Leonardo";
j7.nickName = "CabecaDeCaixaD'agua";
j7.Jogar();
j7.ExibirPontos();

Jogador j8 = new Jogador();
j8.nome = "Joel";
j8.nickName = "OGerente";
j8.Jogar();
j8.ExibirPontos();

Jogador j9 = new Jogador();
j9.nome = "Andreia";
j9.nickName = "BocaDeCaçapa";
j9.Jogar();
j9.ExibirPontos();

Jogador j10 = new Jogador();
j10.nome = "Julia";
j10.nickName = "CabeçaDeRolon";
j10.Jogar();
j10.ExibirPontos();

//=========================================//

// Equipes //

// equipe1
Equipe equipe1 = new Equipe ();
equipe1.nomeDaEquipe = "Pelotas";

// Adicionar jogadores //
equipe1.AdicionarJogadores(j1);
equipe1.AdicionarJogadores(j2);
equipe1.AdicionarJogadores(j3);
equipe1.AdicionarJogadores(j4);
equipe1.AdicionarJogadores(j5);

// equipe2
Equipe equipe2 = new Equipe ();
equipe2.nomeDaEquipe = "Mar Azul";

// Adicionar jogadores //
equipe2.AdicionarJogadores(j6);
equipe2.AdicionarJogadores(j7);
equipe2.AdicionarJogadores(j8);
equipe2.AdicionarJogadores(j9);
equipe2.AdicionarJogadores(j10);

//===========================================//

// Crie o campeonato
Campeonato meuCampeonato = new Campeonato();
meuCampeonato.NomeCampeonato = "Ribeirão Preto";
meuCampeonato.AdicionarEquipe(equipe1);
meuCampeonato.AdicionarEquipe(equipe2);

// Inicie a partida e mostre a classificação
meuCampeonato.IniciarPartida(equipe1, equipe2);
meuCampeonato.Classificacao();