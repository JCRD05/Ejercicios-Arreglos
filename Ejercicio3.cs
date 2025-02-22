using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio3
    {
        // Genera calificaciones de 5 alumnos con 3 parciales cada uno, calcula el promedio  y muestra las calificaciones y promedios
        public static void Show()
        {
            Console.WriteLine("Ejercicio 3\n");
            
            Random rnd = new Random();
            float[,] grades = new float[5,4];
            float sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    grades[i,j] = rnd.Next(5, 11);
                    sum += grades[i,j];
                    
                    Console.WriteLine("Calificación " + (j + 1) + " del alumno " + (i + 1) + ": " + grades[i,j]);
                }
                grades[i,3] = sum / 3; // Guarda el promedio en la última columna
                
                Console.WriteLine("Calificación Final del alumno " + (i + 1) + ": " + grades[i,3] + "\n");
            }
        }
    }
}