using System;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios;

namespace Program
{
    class Menu
    {
        public int option; // Variable que guarda el ejercicio que el usuario quiere ver
        
        // Muestra el menu en consola
        public void Show()
        {
            Console.WriteLine("Ejercicios De Arreglos\n");
            do
            {
                Ejercicios();
                if(option == 8) { return; }
            }while(true);
        }
        
        // Despliega en el menu los ejercicios
        public void Ejercicios()
        {
            Thread.Sleep(500);
            Console.WriteLine("Elija un ejercicio\n");
            Console.Write("1. Ejercicio 1      ");
            Console.Write("2. Ejercicio 2        ");
            Console.Write("3. Ejercicio 3      ");
            Console.WriteLine("4. Ejercicio4\n");
            Console.Write("5. Ejercicio 5      ");
            Console.Write("6. Ejercicio 6        ");
            Console.Write("7. Ejercicio 7      ");
            Console.WriteLine("8. Salir\n");
            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1: Ejercicio1.Show(); break;
                case 2: Ejercicio2.Show(); break;
                case 3: Ejercicio3.Show(); break;
                case 4: Ejercicio4.Show(); break;
                case 5: Ejercicio5.Show(); break;
                case 6: Ejercicio6.Show(); break;
                case 7: Ejercicio7.Show(); break;
                default: Console.WriteLine("Elija una opcion entre 1 y 8"); break;
            }
        }
    }
}