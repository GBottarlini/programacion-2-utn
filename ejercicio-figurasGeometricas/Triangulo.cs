public class Triangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public Triangulo(string nombre, string color, double Base, double Altura, double Lado1, double Lado2, double Lado3) : base(nombre, color)
    {
        this.Base = Base;
        this.Altura = Altura;
        this.Lado1 = Lado1;
        this.Lado2 = Lado2;
        this.Lado3 = Lado3;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }
}
