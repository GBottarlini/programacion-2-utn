public class Circulo : Figura
{
    public double Radio { get; set; }

    public Circulo(string nombre, string color, double radio) : base(nombre, color)
    {
        this.Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
