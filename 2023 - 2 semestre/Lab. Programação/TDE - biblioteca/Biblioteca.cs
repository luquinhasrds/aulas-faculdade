﻿class Biblioteca{
    public string nome;
    public Livro livro1; 
    public Livro livro2;
    public Livro livro3;

    public void setNome(string nomeParametro){
        nome = nomeParametro;
    }

    public string GetNome(){
        return nome;
    }

    public void AdicionarLivro(Livro livro){
        if(livro1 == null){
            livro1 = livro;
        }else if(livro2 == null){
            livro2 = livro;
        }else if (livro3 == null){
            livro3 = livro;
        }else{
            Console.WriteLine("Biblioteca cheia");
        }
    }

    public int qtdLivrosDisponiveis(){
        int total = 0;
        if(livro1.status){
            total +=1;
        }else if(livro2.status){
            total +=1;
        }else if(livro3.status){
            total +=1;
        }
        return total;
    }

    public Livro BuscarPeloTitulo(string tituloLivro){
        if (livro1.titulo == tituloLivro){
            return livro1;
        }else if (livro3.titulo == tituloLivro){
            return livro2;
        }else if (livro3.titulo == tituloLivro){
            return livro3;
        }else{
            Console.WriteLine("livro nao encontrado");
            return null;
        }
    }
}