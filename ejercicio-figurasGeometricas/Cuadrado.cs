public class Cuadrado : Figura
{
    public double Lado { get; set; }

    public Cuadrado(string nombre, string color, double lado) : base(nombre, color)
    {
        this.Lado = lado;
    }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return Lado * 4;
    }
}
