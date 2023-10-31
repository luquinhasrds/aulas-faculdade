// Jogadores //
Jogador j1 = new Jogador();
j1.nome = "Jorge";
j1.nickName = "Jorginhoda12";

Jogador j2 = new Jogador();
j2.nome = "Pedro";
j2.nickName = "matadordeonça";

Jogador j3 = new Jogador();
j3.nome = "Mario";
j3.nickName = "OdoArmario";

Jogador j4 = new Jogador();
j4.nome = "Diojines";
j4.nickName = "Senijoid";

Jogador j5 = new Jogador();
j5.nome = "Jean";
j5.nickName = "Destruidor";

Jogador j6 = new Jogador();
j6.nome = "Klaiton";
j6.nickName = "AirtonSena";

Jogador j7 = new Jogador();
j7.nome = "Leonardo";
j7.nickName = "CabecaDeCaixaD'agua";

Jogador j8 = new Jogador();
j8.nome = "Joel";
j8.nickName = "OGerente";

Jogador j9 = new Jogador();
j9.nome = "Andreia";
j9.nickName = "BocaDeCaçapa";

Jogador j10 = new Jogador();
j10.nome = "Julia";
j10.nickName = "CabeçaDeRolon";

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

// Cria o campeonato
Campeonato meuCampeonato = new Campeonato();
meuCampeonato.NomeCampeonato = "Ribeirão Preto";
meuCampeonato.AdicionarEquipe(equipe1);
meuCampeonato.AdicionarEquipe(equipe2);

// Inicia a partida e mostra a classificação
meuCampeonato.IniciarPartida(equipe1, equipe2);
meuCampeonato.Classificacao();