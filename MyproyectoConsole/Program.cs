using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Curso de LINQ");
        Console.WriteLine("Method Syntax");

        string[] arrayPersonas={"rodney","cecilia"};
        List<string> listPersonas = new  List<string>{"zapata","cantillo"};

/*
        static IEnumerable<string> ListPersonas()
        {
            yield return "palacio";
            yield return "colon";
        }
*/
/*
        System.Console.WriteLine(" --- metodo SQL ---");
        var queryPersona= from p in listPersonas
                    select p;
*/

        System.Console.WriteLine(" --- metodo arrow Fuction ---");
        var queryPersona = listPersonas.Select(p => p );
/*
        System.Console.WriteLine(" --- metodo arrow Fuction IEnumerable---");
        var queryPersona = ListPersonas().Select(p => p );
*/
        foreach (var pa in queryPersona)
        {
            System.Console.WriteLine(pa);
        }
   }
}