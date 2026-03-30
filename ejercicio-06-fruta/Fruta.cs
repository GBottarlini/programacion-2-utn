public class Fruta
{
    private string _color = string.Empty;
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    private double _peso;
    public double Peso
    {
        get { return _peso; }
        set { _peso = value; }
    }

    private bool _esEstacional;
    public bool EsEstacional
    {
        get { return _esEstacional; }
        set { _esEstacional = value; }
    }


    public bool esComestible()
    {
        if (Peso < 200 && EsEstacional)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public Fruta()
    {

    }

    public Fruta( string color, double peso, bool esEstacional)
    {
        this.Color = color;
        this.Peso = peso;
        this.EsEstacional = esEstacional;
    }

}
