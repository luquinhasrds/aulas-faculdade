public class Biblioteca{
    private List<ItemBiblioteca> Colecao;

    public Biblioteca(){
        Colecao = new List<ItemBiblioteca>();
    }

    public void AdicionarItem(ItemBiblioteca item){
        Colecao.Add(item);
        Console.WriteLine($"_____o livro {item.Titulo} foi adicionado a biblioteca.______");
        Console.WriteLine();
    }
    public void RemoverItem(ItemBiblioteca item){
        Colecao.Remove(item);
        Console.WriteLine();
        Console.WriteLine($"_____o livro {item.Titulo} foi removido da biblioteca._____");
        Console.WriteLine();
    }

    public void BuscarLivro(string titulo){
        ItemBiblioteca itemencontrado = Colecao.Find(item => item.Titulo == titulo);
        if(itemencontrado != null){
            Console.WriteLine($"[ [{itemencontrado.Id}] | {itemencontrado.Titulo} ]");
        }else{
            Console.WriteLine("nada encontrado!!");
        }
    }
    public void BuscarLivro(int id){
        ItemBiblioteca itemencontrado = Colecao.Find(item => item.Id == id);
        if(itemencontrado != null){
            Console.WriteLine($"[ [{itemencontrado.Id}] | {itemencontrado.Titulo} ]");
        }else{
            Console.WriteLine("nada encontrado!!");
        }
    }
}