class CalculadoraArea{
    public double calcularAreaQuadrado(double n1){
        double area = n1*n1;
        return area;
    }
    public double calcularAreaCirculo(double raio){
        double area = Math.PI * Math.Pow(raio, 2);
        return area;
    }
}