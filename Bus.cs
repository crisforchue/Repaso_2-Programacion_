using System;

class Bus
{
    public int AsientosTotales { get; }
    public int AsientosOcupados { get; private set; }
    public int AsientosDisponibles => AsientosTotales - AsientosOcupados;

    public Bus(int asientosTotales)
    {
        AsientosTotales = asientosTotales;
    }

    // Método para reservar un asiento
    public void ReservarAsiento()
    {
        if (AsientosOcupados < AsientosTotales)
        {
            AsientosOcupados++;
            Console.WriteLine("Asiento reservado correctamente.");
        }
        else
        {
            Console.WriteLine("Lo siento, no hay asientos disponibles.");
        }
    }
}
