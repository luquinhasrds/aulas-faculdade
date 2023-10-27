class Tabuada{
    public int numeroBase;
    public void imprimirTabuada(){
        Console.WriteLine($"tabuada do numero {numeroBase}");
        for (int i=1; i<=10; i++){
            int resultado = numeroBase*i;
            Console.WriteLine($"{numeroBase} x {i} = {resultado}");
        }
    }
}