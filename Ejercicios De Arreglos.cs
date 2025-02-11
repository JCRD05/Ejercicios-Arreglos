using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program 
{
    // Método para preguntar si el usuario desea revisar otro ejercicio
    static bool Exit()
    {
        string opt;
        do
        {
            Console.WriteLine("¿Desea checar otro ejercicio? s/n\n");
            opt = Console.ReadLine();
            opt = opt.ToLower(); // Convierte la entrada a minúsculas para evitar errores
            if (opt == "s")
                return true;
            else if (opt == "n")
                return false;
            else 
                Console.WriteLine("Introduzca una opción correcta");
        } while (opt != "s" && opt != "n");
        return false;
    }
    
    // Genera 5 calificaciones aleatorias, calcula el promedio y las muestra
    static void Ejercicio1()
    {
        Random rnd = new Random();
        float[] grades = new float[6];
        float sum = 0;
        for(int i = 0; i < 5; i++)
        {
            grades[i] = rnd.Next(5, 11); // Genera calificación entre 5 y 10
            sum += grades[i];
        }
        grades[5] = sum / 5; // Calcula el promedio
        
        // Muestra las calificaciones y el promedio
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Calificación " + (i+1) + " " + grades[i] + "\n");
        }
        Console.WriteLine("Calificación Final " + grades[5] + "\n");
    }
    
    // Compara calificaciones de dos grupos y muestra las mejores
    static void Ejercicio2()
    {
        Random rnd = new Random();
        float[] gradesA = new float[5], gradesB = new float[5], gradesBest = new float[5];
        for(int i = 0; i < 5; i++)
        {
            gradesA[i] = rnd.Next(5, 11);
            gradesB[i] = rnd.Next(5, 11);
            
            // Guarda la mejor calificación entre ambos grupos
            gradesBest[i] = Math.Max(gradesA[i], gradesB[i]);
        }
        
        // Muestra las calificaciones de ambos grupos y la mejor de cada alumno
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Calificación Grupo A" + (i+1) + " " + gradesA[i] + "\n");
            Console.WriteLine("Calificación Grupo B" + (i+1) + " " + gradesB[i] + "\n");
            Console.WriteLine("Mejor Calificación " + (i+1) + " " + gradesBest[i] + "\n");
        }
    }
    
    // Genera calificaciones de 5 alumnos con 3 notas cada uno y calcula el promedio
    static void Ejercicio3()
    {
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
            }
            grades[i,3] = sum / 3; // Guarda el promedio en la última columna
        }
        
        // Muestra las calificaciones y promedios
        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Calificación " + (j + 1) + " del alumno " + (i + 1) + " " + grades[i,j] + "\n");
            }
            Console.WriteLine("Calificación Final del alumno " + (i + 1) + " " + grades[i,3] + "\n");
        }
    }
    
    // Genera dos calificaciones por alumno, selecciona la mejor y la muestra
    static void Ejercicio4()
    {
        Random rnd = new Random();
        float[,] grades = new float[10,3];
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                grades[i,j] = rnd.Next(5, 11);
            }
            // Selecciona la mejor calificación
            grades[i,2] = Math.Max(grades[i,0], grades[i,1]);
        }
        
        // Muestra las calificaciones y la mejor de cada alumno
        for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.WriteLine("Calificación " + (j + 1) + " del alumno " + (i + 1) + " " + grades[i,j] + "\n");
            }
            Console.WriteLine("Mejor Calificación: " + grades[i,2] + "\n");
        }
    }
    
    // Genera ventas de 100 clientes y muestra el total de ingresos
    static void Ejercicio5()
    {
        Random rnd = new Random();
        float[] sales = new float[100];
        float sum = 0;
        for(int i = 0; i < 100; i++)
        {
            sales[i] = rnd.Next(100, 1001); // Genera un gasto aleatorio entre $100 y $1000
            sum += sales[i];
            Console.WriteLine("El cliente " + (i+1) + " gastó: $" + sales[i]);
        }
        Console.WriteLine("El ingreso total fue de: " + "$" + sum);
    }
    
    // Cuenta números pares e impares en un arreglo de 20 números aleatorios
    static void Ejercicio6()
    {
        Random rnd = new Random();
        float[] numbers = new float[20];
        int par = 0, impar = 0;
        for(int i = 0; i < 20; i++)
        {
            numbers[i] = rnd.Next(1, 101); // Genera números entre 1 y 100
            if ((numbers[i] % 2) == 0)
                par++;
            else 
                impar++;
        }
        
        // Muestra los números y el conteo de pares e impares
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine(numbers[i] + "\n");
        }
        Console.WriteLine("El número de pares fue: " + par + " y el número de impares fue: " + impar);
    }
    
    // Genera 20 números y muestra su cuadrado y su cubo
    static void Ejercicio7()
    {
        Random rnd = new Random();
        float[] numbers = new float[20], squares = new float[20], cubes = new float[20];
        for(int i = 0; i < 20; i++)
        {
            numbers[i] = rnd.Next(1, 20);
            squares[i] = numbers[i] * numbers[i];
            cubes[i] = numbers[i] * squares[i]; // Calcula el cubo usando el cuadrado
        }
        
        // Muestra el número, su cuadrado y su cubo
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("Número: " + numbers[i] + " ");
            Console.WriteLine("Cuadrado: " + squares[i] + " ");
            Console.WriteLine("Cubo: " + cubes[i] + "\n");
        }
    }
    
    // Menú principal para seleccionar un ejercicio
    static void Main() 
    {
        int opt = 0;
        do
        {
            Console.WriteLine("Elija un ejercicio\n");
            Console.WriteLine("1 2 3 4 5 6 7");
            opt = Convert.ToInt32(Console.ReadLine());
            
            switch(opt)
            {
                case 1: Ejercicio1(); break;
                case 2: Ejercicio2(); break;
                case 3: Ejercicio3(); break;
                case 4: Ejercicio4(); break;
                case 5: Ejercicio5(); break;
                case 6: Ejercicio6(); break;
                case 7: Ejercicio7(); break;
                default: Console.WriteLine("Elija un ejercicio entre 1 y 7"); break;
            }
        } while (Exit() && (opt >= 1 && opt <= 7)); // Permite repetir hasta que el usuario elija salir
    }
}
