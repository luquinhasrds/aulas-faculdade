public class Aluno{
    public string? nome { get; set; }
    public int matricula { get; set; }
    public int idade { get; set; }
    public string? curso { get; set; }

    public Aluno(string nome, int matricula, int idade, string curso){
        this.nome = nome;
        this.matricula = matricula;
        this.idade = idade;
        this.curso = curso;
    }

    public void MostrarInformacoes(){
        Console.WriteLine($"Nome: {nome}\nMatricula: {matricula}\nIdade: {idade}\nCurso: {curso}");
    }
}