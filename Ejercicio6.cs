using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio6
    {
        // Cuenta números pares e impares en un arreglo de 20 números aleatorios
        public static void Show()
        {
            Console.WriteLine("Ejercicio 6\n");
            
            Random rnd = new Random();
            float[] numbers = new float[20];
            int par = 0, impar = 0;
            
            // Genera números entre 1 y 100
            for(int i = 0; i < 20; i++)
            {
                numbers[i] = rnd.Next(1, 101);
                if ((numbers[i] % 2) == 0) { par++; }
                
                // Muestra los números
                Console.WriteLine(numbers[i]);
            }
            impar = 20 - par;
            
            // Muestra el conteo de pares e impares
            Console.WriteLine("El número de pares fue: " + par + " y el número de impares fue: " + impar);
        }
    }
}