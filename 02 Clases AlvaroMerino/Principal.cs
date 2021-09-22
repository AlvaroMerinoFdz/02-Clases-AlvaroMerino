using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha elegido manejar fechas");
                        ManejarFechas.menu();

                        break;
                    case 2:
                        Console.WriteLine("Ha elegido CLASE LIBROS");
                        menuLibros();
                        break;
                    case 3:
                        Console.WriteLine("Ha elegido ALQUILER AEROPUERTO");

                        break;
                    case 4:
                        Console.WriteLine("SALIR...");
                        break;
                }
            } while (opcion!=4);
            
           
            


            
        }

        public static Libro addLibro()
        {
            Libro libro = new Libro();
            Console.WriteLine("Introduca el titulo del libro");
            libro.Titulo = Console.ReadLine();
            Console.WriteLine("Introduca el autor del libro");
            libro.Autor = Console.ReadLine();
            Console.WriteLine("Introduca el estilo del libro");
            libro.Estilo = Console.ReadLine();
            Console.WriteLine("Introduca la editorial  del libro");
            libro.Editorial = Console.ReadLine();
            return libro;
        }
        private static void menuLibros()
        {
            ArrayList listaLibros = new ArrayList();
            int opcion;
            bool valido;
            do
            {
                do
                {
                    Console.WriteLine("Menú de Opciones");
                    Console.WriteLine("Introduzca una opción");
                    Console.WriteLine("1. Insertar Libro");
                    Console.WriteLine("2. Ver listado de libros");
                    Console.WriteLine("3. Modificar libro");
                    Console.WriteLine("4. Eliminar libro");
                    Console.WriteLine("5. Volver al menú principal");
                    Console.WriteLine("Introduzca la opcion");
                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion >= 6) valido = false;
                    if (!valido) Console.WriteLine("Introduzca una opcion válida");
                } while (!valido);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha elegido añadir libro");
                        Libro libro = addLibro();
                        
                        listaLibros.Add(libro);
                        break;
                    case 2:
                        Console.WriteLine("Mostrando listado de libros");
                        for (int i = 0; i < listaLibros.Count; i++)
                        {
                            Console.WriteLine(i + " " + listaLibros[i]);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Modificando libro");
                        Console.WriteLine("Introduzca el número del libro que desea modificar");
                        int numero;
                        do
                        {
                            Console.WriteLine("Introduzca el número del libro que deseas modificar");
                            valido = int.TryParse(Console.ReadLine(), out numero);
                            if (numero > listaLibros.Count-1) valido = false;
                            if (!valido) Console.WriteLine();
                        } while (!valido);

                        Libro libro1 = addLibro();
                        listaLibros[numero] = libro1;
                        break;
                    case 4:
                        Console.WriteLine("Eliminando libro");
                        do
                        {
                            Console.WriteLine("Introduzca el número del libro que deseas eliminar");
                            valido = int.TryParse(Console.ReadLine(), out numero);
                            if (numero > listaLibros.Count-1) valido = false;
                            if (!valido) Console.WriteLine();
                        } while (!valido);
                        listaLibros.RemoveAt(numero);
                        break;
                    case 5:
                        Console.WriteLine("SALIR...");
                        break;
                }
            } while (opcion != 5);

        }
    }
}
