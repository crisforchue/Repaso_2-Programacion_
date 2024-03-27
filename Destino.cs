using System;

class Destino
{
    public string NombreDestino { get; set; }
    public string Descripcion { get; set; }
    public double DistanciaKm { get; set; }

    public Destino(string nombreDestino, string descripcion, double distanciaKm)
    {
        NombreDestino = nombreDestino;
        Descripcion = descripcion;
        DistanciaKm = distanciaKm;
    }
}
