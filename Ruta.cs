class Ruta
{
    public string NombreRuta { get; set; }
    public double DistanciaKm { get; set; }

    public Ruta(string nombreRuta, double distanciaKm)
    {
        NombreRuta = nombreRuta;
        DistanciaKm = distanciaKm;
    }
}

