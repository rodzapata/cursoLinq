using System;
using System.Collections.Generic;

Console.WriteLine("Clase personalizada");

var queryPersona = ObtenerPersonas().Where(p => p.Edad>38)
        .Select(p => p);

foreach (var p in queryPersona)
{
    Console.WriteLine($"{p.Nombre}, {p.Edad} años");
}

static IEnumerable<Persona> ObtenerPersonas()
{
    yield return new Persona { Nombre = "rodney", Edad = 50 };
    yield return new Persona { Nombre = "Cecilia", Edad = 37 };
}


class Persona
{
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }
}
