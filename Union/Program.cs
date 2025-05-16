Console.WriteLine("Uniones en Linq");

string[] nombres={"rodney","cecilia"};
string[] apellidos={"zapata","cantillo"};

/*
Console.WriteLine("---syntax query sql");
var nombresApellidos = (from n in nombres
                    select n).Union(apellidos);
*/

System.Console.WriteLine("---syntax arrow funtion");
var nombresApellidos = nombres.Select(n => n).Union(apellidos);

foreach (var item in nombresApellidos)
{
    System.Console.WriteLine(item);
}
