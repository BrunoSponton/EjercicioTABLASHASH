using System;
using System.Collections.Generic;

class EjercicioTABLASHASH
{
    static void Main()
    {
        
        Dictionary<string, string> diccionario = new Dictionary<string, string>();

        diccionario.Add("dog", "perro");
        diccionario.Add("cat", "gato");
        diccionario.Add("house", "casa");
        diccionario.Add("book", "libro");
        diccionario.Add("water", "agua");
        diccionario.Add("computer", "computadora");
        diccionario.Add("food", "comida");
        diccionario.Add("car", "coche");

        string palabra;

        Console.WriteLine("Introduce una palabra en ingles para obtener la traducción en español (dejar vacio para salir):");

        do
        {
            palabra = Console.ReadLine();

            if (!string.IsNullOrEmpty(palabra))
            {
                if (diccionario.ContainsKey(palabra))
                {
                    Console.WriteLine($"La traduccion de '{palabra}' es: {diccionario[palabra]}");
                }
                else
                {
                    Console.WriteLine($"La palabra '{palabra}' no esta en el diccionario.");
                }
            }

        } while (!string.IsNullOrEmpty(palabra));

        Console.WriteLine("Programa finalizado.");
    }
}
