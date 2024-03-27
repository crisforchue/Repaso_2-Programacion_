using System;

class Boleto
{
    public Ruta RutaViaje { get; set; }
    public Pasajero PasajeroViaje { get; set; }
    public decimal Precio { get; set; }

    public Boleto(Ruta ruta, Pasajero pasajero, decimal precio)
    {
        RutaViaje = ruta;
        PasajeroViaje = pasajero;
        Precio = precio;
    }

    public void MostrarInformacionBoleto()
    {
        Console.WriteLine($"Ruta: {RutaViaje.NombreRuta}");
        Console.WriteLine($"Pasajero: {PasajeroViaje.Nombre}");
        Console.WriteLine($"Precio del boleto: ${Precio}");
    }
}
