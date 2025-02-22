using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio7
    {
        // Genera 20 números y muestra su cuadrado y su cubo
        public static void Show()
        {
            Console.WriteLine("Ejercicio 7\n");
            
            Random rnd = new Random();
            float[] numbers = new float[20], squares = new float[20], cubes = new float[20];
            for(int i = 0; i < 20; i++)
            {
                numbers[i] = rnd.Next(1, 20);
                squares[i] = numbers[i] * numbers[i];
                cubes[i] = numbers[i] * squares[i]; // Calcula el cubo usando el cuadrado
                
                // Muestra el número, su cuadrado y su cubo
                Console.WriteLine("Número: " + numbers[i] + " ");
                Console.WriteLine("Cuadrado: " + squares[i] + " ");
                Console.WriteLine("Cubo: " + cubes[i] + "\n");
            }
        }
    }
}