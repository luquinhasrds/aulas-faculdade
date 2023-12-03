public class Biblioteca{
    private List<ItemBiblioteca> Colecao;

    public Biblioteca(){
        Colecao = new List<ItemBiblioteca>();
    }

    public void AdicionarItem(ItemBiblioteca item){
        Colecao.Add(item);
        Console.WriteLine($"o livro {item.Titulo} foi adicionado a biblioteca.");
    }
    public void RemoverItem(ItemBiblioteca item){
        Colecao.Remove(item);
        Console.WriteLine($"o livro {item.Titulo} foi removido da biblioteca.");
    }

    public void BuscarItemPorTitulo(string titulo){
        ItemBiblioteca itemencontrado = Colecao.Find(item => item.Titulo == titulo);
        if(itemencontrado != null){
            Console.WriteLine(itemencontrado.Id);
        }
    }
    public void BuscarItemPorId(int id){
        ItemBiblioteca itemEncontrado = Colecao.Find(item => item.Id == id);
        if(itemEncontrado != null){
            Console.WriteLine(itemEncontrado.Titulo);
        }else{
            Console.WriteLine("nada encontrado!!");
        }
    }
}