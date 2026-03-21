public class Persona
{
    private string nombre;
    private string apellido;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    // Metodo

    public string Presentarse()
    {
        return $"{Nombre} {Apellido}";
    }
}

// Clase que extiende de persona

public class Visitante : Persona
{
private int dni;
public int DNI
{
    get { return dni; }
    set { dni = value; }
}

}

public class Guardia : Persona
{
    // Escribimos el metodo
    public string Presentarse()
    {
        return "Hola soy " + this.Nombre + " " + this.Apellido + " y soy guardia";
    }

    public string ControlarDocumento(Visitante visitante )
    {
        return "Estoy controlando el documento de " + visitante.Nombre + " " + visitante.Apellido + " con DNI " + visitante.DNI;
    }
}
