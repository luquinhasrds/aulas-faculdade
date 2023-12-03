filme f1 = new filme();
    f1.titulo = "a volta dos que nao foram";
    f1.diretor = "pedro coelho";
    f1.anoLancamento = 1500;

Console.WriteLine($"{f1.titulo}, {f1.diretor}, {f1.anoLancamento}");

class filme{
    public string titulo;
    public string diretor;
    public int anoLancamento;
}