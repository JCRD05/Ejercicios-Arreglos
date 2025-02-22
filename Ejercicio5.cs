using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio5
    {
        // Genera ventas de 100 clientes y muestra el total de ingresos
        public static void Show()
        {
            Console.WriteLine("Ejercicio 5\n");
            
            Random rnd = new Random();
            float[] sales = new float[100];
            float sum = 0;
            for(int i = 0; i < 100; i++)
            {
                sales[i] = rnd.Next(100, 1001); // Genera un gasto aleatorio entre $100 y $1000
                sum += sales[i];
                Console.WriteLine("El cliente " + (i+1) + " gasto: $" + sales[i]);
            }
            Console.WriteLine("El ingreso total fue de: " + "$" + sum);
        }
    }
}