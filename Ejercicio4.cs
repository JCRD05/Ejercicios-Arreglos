using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio4
    {
        // Genera dos calificaciones por alumno, selecciona la mejor y la muestra
        public static void Show()
        {
            Console.WriteLine("Ejercicio 4\n");
            
            Random rnd = new Random();
            float[,] grades = new float[10,3];
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    grades[i,j] = rnd.Next(5, 11);
                    
                    // Muestra las calificaciones
                    Console.WriteLine("Calificacion " + (j + 1) + " del alumno " + (i + 1) + ": " + grades[i,j]);
                }
                // Selecciona la mejor calificación
                grades[i,2] = Math.Max(grades[i,0], grades[i,1]);
                
                // Muestra la mejor calificacion de cada alumno
                Console.WriteLine("Mejor Calificacion: " + grades[i,2] + "\n");
            }
        }
    }
}