class Aluno{
    public string? nome;
    private int nota;

    public int getNota(){
        Random rand = new Random();
        return rand.Next(1, 11);
    }

    public void setNota(int nota){
        this.nota = nota;
    }

    public Aluno(string nome){
        this.nome = nome;
        this.nota = 1;
    }
}