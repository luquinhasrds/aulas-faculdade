class ConversorTemperatura{
    public double temperaturaCelcius;
    public void ConverterParaFahrenheit(){
        double resultado = (temperaturaCelcius * 1.8) + 32;
        Console.WriteLine(resultado);
    }
}