Console.WriteLine("select Many IEnumerable");
static IEnumerable<string> Sucursal()
{
    yield return "Barranquilla";
    yield return "soledad";
    yield return "bogota";
}

static IEnumerable<string> UndNegocio()
{
    yield return "mantenimiento";
    yield return "proyectos";
    yield return "servicios";
    yield return "montages";
}

//armamos el Linq de Sql
/*
System.Console.WriteLine("----Query con SQL------");
var unirSucursalUndNegocio = from s in Sucursal()
                             from u in UndNegocio()
                             select new {Sucursal= s, UnidadNegocio =u};
*/                             

System.Console.WriteLine("----Query con ArrowFuction------");
var unirSucursalUndNegocio = Sucursal().SelectMany(
            suc => UndNegocio()
            .Select(und => 
            new {sucursal=suc, undnegocio=und})
         );

foreach (var unir in unirSucursalUndNegocio)
{
    System.Console.WriteLine(unir);
}