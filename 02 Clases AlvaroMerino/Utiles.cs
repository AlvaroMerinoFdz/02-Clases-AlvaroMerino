using _02_Clases_AlvaroMerino.AlquilerPuerto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02_Clases_AlvaroMerino
{
    class Utiles
    {
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
        public static void menuLibros()
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
                            if (numero > listaLibros.Count - 1) valido = false;
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
                            if (numero > listaLibros.Count - 1) valido = false;
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
        public static void Puerto()
        {
            Velero velero = new Velero(2,"1",2020,10);
            Alquiler alquiler = new Alquiler("Alvaro Merino","05936482K", new DateTime(2021,09,22), new DateTime(2021, 09, 25), velero);
            Console.WriteLine(alquiler);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");

            EmbarcacionDeportiva embarcacionDeportiva = new EmbarcacionDeportiva(100,"2",1999,12);
            Alquiler alquiler2 = new Alquiler("Alvaro Merino", "05936482K", new DateTime(2021, 09, 28), new DateTime(2021, 10, 2), embarcacionDeportiva);
            Console.WriteLine(alquiler2);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");

            Yate yate = new Yate("3",2005,8,75,3);
            Alquiler alquiler3 = new Alquiler("Alvaro Merino", "05936482K", new DateTime(2021, 08, 28), new DateTime(2021, 9, 2), yate);
            Console.WriteLine(alquiler3);
            Console.WriteLine("Presione una tecla para continuar. ");
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }
    }
}
