public class Ninja
{
    private string _arteMarcial = string.Empty;
    public string ArteMarcial

    {
        get { return _arteMarcial; }
        set { _arteMarcial = value; }
    }

    private string _arma = string.Empty;
    public string Arma
    {
        get { return _arma; }
        set { _arma = value; }
    }

    private int _fuerza;
    public int Fuerza
    {
        get { return _fuerza; }
        set { _fuerza = value; }
    }

    private int _salto;
    public int Salto
    {
        get { return _salto; }
        set { _salto = value; }
    }


    public void saltar(int multiplicador)
    {
        Console.WriteLine(Salto * multiplicador);
    }

    public void ataque()
    {
        Console.WriteLine($"Este ninja practica {ArteMarcial} y usa {Arma}");


    }
}
