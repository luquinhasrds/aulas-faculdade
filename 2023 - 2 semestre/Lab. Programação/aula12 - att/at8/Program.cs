time t1 = new time();
    t1.nome = "gremio";
    t1.cidade = "porto alegre";
    t1.anoFundacao = 1950;

time t2 = new time();
    t2.nome = "internacional";
    t2.cidade = "porto alegre";
    t2.anoFundacao = 2000;

Console.WriteLine($"{t1.nome}, {t1.cidade}, {t1.anoFundacao}\n{t2.nome}, {t2.cidade}, {t2.anoFundacao}");

class time{
    public string nome;
    public string cidade;
    public int anoFundacao;
}