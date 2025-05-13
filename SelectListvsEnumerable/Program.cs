using System;
using System.Linq;

Console.WriteLine("comparamos un List tipo string vs Ienumerable tipo string");
List<string> personaList = new List<string>{"rodney","juan miguel","samuel"};
IEnumerable<string> personaEnum = new  List<string>{"zapata","palacio","cantillo"};

var queryList = personaList.Select(p=> p);
var queryIenum = personaEnum.Select(p=> p);

System.Console.WriteLine("-----listado con List -----");
foreach (var pl in queryList)
{
    Console.WriteLine(pl);
}

System.Console.WriteLine("-----listado con IEnumerable -----");
foreach (var pe in queryIenum)
{
    Console.WriteLine(pe);
}

