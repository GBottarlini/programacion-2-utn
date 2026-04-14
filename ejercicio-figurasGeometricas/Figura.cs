public abstract class Figura
{
    public string? Nombre { get; set; }
    public string? Color { get; set; }

    public Figura(string nombre, string color)
    {
        this.Nombre = nombre;
        this.Color = color;
    }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}
