using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        // Medimos con List<int>
        Stopwatch swList = Stopwatch.StartNew();
        long memoriaAntesList = GC.GetTotalMemory(true);
        var lista = GenerarParesConLista();
        long memoriaDespuesList = GC.GetTotalMemory(true);
        swList.Stop();

        Console.WriteLine("📦 List<int>:");
        Console.WriteLine($"⏱ Tiempo: {swList.ElapsedMilliseconds} ms");
        Console.WriteLine($"💾 Memoria usada: {(memoriaDespuesList - memoriaAntesList) / 1024} KB");
        Console.WriteLine($"🔢 Primeros 5: {string.Join(", ", lista.Take(5))}\n");

        // Medimos con yield return
        Stopwatch swYield = Stopwatch.StartNew();
        long memoriaAntesYield = GC.GetTotalMemory(true);
        var secuencia = GenerarParesConYield().Take(5).ToList(); // Forzamos la ejecución de solo 5 elementos
        long memoriaDespuesYield = GC.GetTotalMemory(true);
        swYield.Stop();

        Console.WriteLine("📤 yield return:");
        Console.WriteLine($"⏱ Tiempo: {swYield.ElapsedMilliseconds} ms");
        Console.WriteLine($"💾 Memoria usada: {(memoriaDespuesYield - memoriaAntesYield) / 1024} KB");
        Console.WriteLine($"🔢 Primeros 5: {string.Join(", ", secuencia)}");
    }

    static List<int> GenerarParesConLista()
    {
        List<int> pares = new List<int>();
        for (int i = 0; i < 1_000_000; i++)
        {
            if (i % 2 == 0)
                pares.Add(i);
        }
        return pares;
    }

    static IEnumerable<int> GenerarParesConYield()
    {
        for (int i = 0; i < 1_000_000; i++)
        {
            if (i % 2 == 0)
                yield return i;
        }
    }
}

