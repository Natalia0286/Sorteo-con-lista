using System;
using System.Collections.Generic;

namespace Sorteo_con_lista
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> concursantes = new List<string>();
            Console.WriteLine("Bienvenido al sorteo!");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un participante: ");
            string participante=Console.ReadLine();
            Console.WriteLine("");

            while(!participante.ToLower().Equals("salir")){
                 
                 concursantes.Add(participante);
                 Console.Write("Ingrese a otro participante: ");
                 Console.WriteLine("");
                 participante = Console.ReadLine();
                 Console.WriteLine("");

            }

            Console.WriteLine("Los participantes del sorteo son: ");
            foreach(string item in concursantes){
                    Console.WriteLine(item);
            }

            
            Random random = new Random();
            int ganador = random.Next(0, (concursantes.Count));

            Console.WriteLine("");
            Console.WriteLine("El ganador/a del sorteo es: {0}!", concursantes[ganador]);
            
            
        }
    }
}
