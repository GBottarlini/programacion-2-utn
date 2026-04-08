public interface ITraccion
{
    int ObtenerReduccionHP();
    int ObtenerKilometros();
    string ObtenerTipo();
}

public class RuedaCaucho : ITraccion
{
    public int ObtenerReduccionHP()
    {
        return 1;
    }
    public int ObtenerKilometros()
    {
        return 100;
    }
    public string ObtenerTipo()
    {
        return "Rueda de Caucho";
    }
}

public class Oruga : ITraccion
{
    public int ObtenerReduccionHP()
    {
        return 3;
    }
    public int ObtenerKilometros()
    {
        return 400;
    }
    public string ObtenerTipo()
    {
        return "Oruga";
    }

    public string ObtenerTemperatura()
    {
        return "Sensor Meke-M0 indica 24C";
    }

}

public class Robot
{
    public string NroSerie {get; set;} = "KT-2020-P";
    public int PotenciaBase {get; set; } = 10;
    public ITraccion? SistemaTraccion {get; set;}

    public void MostrarDatos()
    {
        Console.WriteLine($"Numero Serie: {NroSerie}");

        if (SistemaTraccion is null)
        {
            Console.WriteLine("No hay sistema de traccion asignado.");
            return;
        }

        int potenciaFinal = PotenciaBase - SistemaTraccion.ObtenerReduccionHP();
        Console.WriteLine($"Potencia Final: {potenciaFinal} hp");

        Console.WriteLine($"Tipo de traccion: {SistemaTraccion.ObtenerTipo()}");
        Console.WriteLine($"Distancia maxima: {SistemaTraccion.ObtenerKilometros()} km");

        if (SistemaTraccion is Oruga)
        {
            Oruga orugaEnchufada = (Oruga)SistemaTraccion;
            Console.WriteLine($"{orugaEnchufada.ObtenerTemperatura()}");
        }


    }
}
