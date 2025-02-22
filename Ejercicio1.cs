using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio1
    {
        // Genera 5 calificaciones aleatorias, calcula el promedio y las muestra
        public static void Show()
        {
            Console.WriteLine("Ejercicio 1\n");
            
            Random rnd = new Random();
            float[] grades = new float[6];
            float sum = 0;
            for(int i = 0; i < 5; i++)
            {
                grades[i] = rnd.Next(5, 11); // Genera calificación entre 5 y 10
                sum += grades[i];
                
                // Muestra las calificaciones
                Console.WriteLine("Calificacion " + (i+1) + ": " + grades[i]);
            }
            grades[5] = sum / 5; // Calcula el promedio
            
            // Muestra el promedio
            Console.WriteLine("Calificacion Final: " + grades[5] + "\n");
        }
    }
}