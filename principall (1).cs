using System;

class Program
{
    static void Main()
    {
        var destino1 = new Destino("Punta Cana", "Samana", 323.2);

        decimal precioPorKm = 10m;
        decimal precioBoleto = (decimal)destino1.DistanciaKm * precioPorKm;

        Console.WriteLine("Info Destino:");
        Console.WriteLine($"Nombre: {destino1.NombreDestino}");
        Console.WriteLine($"Descripcion: {destino1.Descripcion}");
        Console.WriteLine($"Distancia: {destino1.DistanciaKm} km");
        Console.WriteLine($"Precio del boleto: ${precioBoleto}");
        var autobus = new Bus(23);
        Console.WriteLine($"Asientos disponibles en el autobús: {autobus.AsientosDisponibles}");
    }
}





