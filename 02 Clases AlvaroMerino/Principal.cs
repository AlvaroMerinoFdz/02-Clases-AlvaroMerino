using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _02_Clases_AlvaroMerino.AlquilerPuerto;

namespace _02_Clases_AlvaroMerino
{
    class Principal
    {
        static void Main(string[] args)
        {
            int opcion;
            bool valido;
            do
            {
                do
                {
                    Console.WriteLine("Menú de Opciones");
                    Console.WriteLine("Introduzca una opción");
                    Console.WriteLine("1. Manejar Fechas");
                    Console.WriteLine("2. Clase Libros");
                    Console.WriteLine("3. Alquiler Aeropuerto");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("Introduzca la opcion");
                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion >= 5) valido = false;
                    if (!valido) Console.WriteLine("Introduzca una opcion válida");
                } while (!valido);
                Console.WriteLine("\n");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha elegido manejar fechas");
                        ManejarFechas.menu();

                        break;
                    case 2:
                        Console.WriteLine("Ha elegido CLASE LIBROS");
                        Utiles.menuLibros();
                        break;
                    case 3:
                        Console.WriteLine("Ha elegido ALQUILER PUERTO");
                        Utiles.Puerto();
                        break;
                    case 4:
                        Console.WriteLine("SALIR...");
                        break;
                }
            } while (opcion!=4);   
        }
    }
}
