using System.Linq;

public class Program
{
    private static void Main(string[] args)
    {
    /*
        static IEnumerable<string> Personas()
        {
            yield return "rodney";
            yield return "Cecilia Mercedes":
            yield return "samuel David";
            yield return "Juan Miguel";
        }
    */
        Console.WriteLine("curso de linQ");
        Console.WriteLine("query Syntax");
        //Armamos el query

        string[] Personas={"rodney","cecilia"};

        IEnumerable<string> valores=from n in Personas
                    select n;

        /*
        var personas = from p in Personas()
                       select p;
        */
        //ejecutamos el Query a trabez de un ciclo
        foreach (var p in valores)
        {
            Console.WriteLine(p);
        }

    }
}