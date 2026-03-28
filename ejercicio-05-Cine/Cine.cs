public class Cine
{
    private string _pelicula = string.Empty;
    public string Pelicula
    {
        get { return _pelicula; }
        set { _pelicula = value; }
    }

    private string _horario = string.Empty;
    public string Horario
    {
        get { return _horario; }
        set { _horario = value; }
    }

    public string ObtenerCartelera()
    {
        return $"La pelicula es {Pelicula} y se transmite a la hora {Horario}";
    }
}
