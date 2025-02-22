using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio2
    {
        // Compara calificaciones de dos grupos y muestra las mejores
        public static void Show()
        {
            Console.WriteLine("Ejercicio 2\n");
            
            Random rnd = new Random();
            float[] gradesA = new float[5], gradesB = new float[5], gradesBest = new float[5];
            for(int i = 0; i < 5; i++)
            {
                gradesA[i] = rnd.Next(5, 11);
                gradesB[i] = rnd.Next(5, 11);
                
                // Guarda la mejor calificación entre ambos grupos
                gradesBest[i] = Math.Max(gradesA[i], gradesB[i]);
                
                // Muestra las calificaciones de ambos grupos y la mejor de cada alumno
                Console.WriteLine("Calificacion Grupo A " + (i+1) + ": " + gradesA[i]);
                Console.WriteLine("Calificacion Grupo B " + (i+1) + ": " + gradesB[i]);
                Console.WriteLine("Mejor Calificacin " + (i+1) + ": " + gradesBest[i] + "\n");
            }
        }
    }
}