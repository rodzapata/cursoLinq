using Mystructure;
using System;
using System.Linq;

Console.WriteLine("Estructura de archivos");

List<Producto> prod = new List<Producto>()
{
    new Producto{Codigo="1010", Descripcion="PC", Costo=15000} ,
    new Producto{Codigo="1011", Descripcion="portatil", Costo=13000} ,
    new Producto{Codigo="1012", Descripcion="mouse", Costo=13} ,
    new Producto{Codigo="1013", Descripcion="impresora", Costo=200} ,
};

var productoFiltado = prod.Select(p => p);
foreach (var item in productoFiltado)
{
    Console.WriteLine($"Codigo: {item.Codigo} Descripcion: {item.Descripcion} Costo: {item.Costo}");
}