public class Biblioteca{  //CLASSE
    private List<ItemBiblioteca> Colecao;  //LISTA DE LIVROS

    public Biblioteca(){
        Colecao = new List<ItemBiblioteca>(); //CRIA A LISTA ZERADA DE LIVROS
    }

    public void AdicionarItem(ItemBiblioteca item){  //METODO PARA ADICIONAR LIVRO A BIBLIOTECA
        Colecao.Add(item);
        Console.WriteLine($"_____o livro {item.Titulo} foi adicionado a biblioteca.______");
        Console.WriteLine();
    }
    public void RemoverItem(ItemBiblioteca item){ //METODO PARA REMOVER UM LIVRO DA BIBLIOTECA
        Colecao.Remove(item);
        Console.WriteLine();
        Console.WriteLine($"_____o livro {item.Titulo} foi removido da biblioteca._____");
        Console.WriteLine();
    }

    public void BuscarLivro(string titulo){  //METODO PARA BUSCAR UM LIVRO POR TITULO
        ItemBiblioteca itemencontrado = Colecao.Find(item => item.Titulo == titulo);
        if(itemencontrado != null){
            Console.WriteLine($"[ [{itemencontrado.Id}] | {itemencontrado.Titulo} ]");
        }else{
            Console.WriteLine("nada encontrado!!");
        }
    }
    public void BuscarLivro(int id){ //METODO SOBRECARREGADO PARA BUSCAR UM LIVRO POR ID
        ItemBiblioteca itemencontrado = Colecao.Find(item => item.Id == id);
        if(itemencontrado != null){
            Console.WriteLine($"[ [{itemencontrado.Id}] | {itemencontrado.Titulo} ]");
        }else{
            Console.WriteLine("nada encontrado!!");
        }
    }
} //FECHAMENTO DA CLASSE