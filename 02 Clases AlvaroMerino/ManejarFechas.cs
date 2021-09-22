using System;
using System.Globalization;

namespace _02_Clases_AlvaroMerino
{
    class ManejarFechas
    {

        public static DateTime introducirFecha()
        {
            bool valido;
            int dia = 0, mes = 0, anio = 0;
            do
            {
                Console.WriteLine("Introduzca el año");
                valido = int.TryParse(Console.ReadLine(), out anio);
                if (!valido) Console.WriteLine("Introduzca el año otra vez");
            } while (!valido);
            do
            {
                Console.WriteLine("Introduzca el mes");
                valido = int.TryParse(Console.ReadLine(), out mes);
                if (mes > 12) valido = false;
                if (!valido) Console.WriteLine("Introduzca el mes otra vez");
            } while (!valido);
            do
            {
                Console.WriteLine("Introduzca el día");
                valido = int.TryParse(Console.ReadLine(), out dia);
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia > 31 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia >= 31 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                else
                {
                    if (dia > 28 || dia <= 0)
                    {
                        valido = false;
                    }
                }
                if (!valido) Console.WriteLine("Introduzca el dia otra vez");
            } while (!valido);




            DateTime fecha = new DateTime(anio, mes, dia);

            return fecha;

        }


        public static void menu()
        {
            bool valido; int opcion;
            DateTime fecha;
            do
            {
                do
                {
                    Console.WriteLine("Menú de Opciones");
                    Console.WriteLine("Introduzca una opción");
                    Console.WriteLine("1. Mostrar dia de la semana");
                    Console.WriteLine("2. Incrementar fecha");
                    Console.WriteLine("3. Diferencia fecha");
                    Console.WriteLine("4. Comparar fechas");
                    Console.WriteLine("5. Mostrar formato largo");
                    Console.WriteLine("6. Volver al menú principal");

                    Console.WriteLine("Introduzca la opcion");
                    valido = int.TryParse(Console.ReadLine(), out opcion);
                    if (opcion >= 7) valido = false;
                    if (!valido) Console.WriteLine("Introduzca una opcion válida");
                } while (!valido);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Mostrando dia de la semana");
                        fecha = introducirFecha();
                        Console.WriteLine("El dia de la semana es: " + fecha.DayOfWeek);
                        break;
                    case 2:
                        Console.WriteLine("Incrementando fecha");
                        fecha = introducirFecha();
                        int numDias;
                        do
                        {
                            Console.WriteLine("Introduzca los dias que desea aumentar");
                            valido = int.TryParse(Console.ReadLine(), out numDias);
                            if (!valido) Console.WriteLine("Introduzca los dias que desea aumentar otra vez");
                        } while (!valido);
                        fecha = fecha.AddDays(numDias);
                        Console.WriteLine("La nueva fecha es " + fecha.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Resta fecha");
                        fecha = introducirFecha();
                        int numeroDias;
                        do
                        {
                            Console.WriteLine("Introduzca los dias que desea restar");
                            valido = int.TryParse(Console.ReadLine(), out numeroDias);
                            if (!valido) Console.WriteLine("Introduzca los dias que desea restar otra vez");
                        } while (!valido);
                        fecha = fecha.AddDays(-numeroDias);
                        Console.WriteLine("La nueva fecha es " + fecha.ToString());
                        break;
                    case 4:
                        Console.WriteLine("Vamos a comparar 2 fechas.");
                        fecha = introducirFecha();
                        DateTime fecha1 = introducirFecha();
                        int resultado = (DateTime.Compare(fecha, fecha1));
                        if (resultado < 0)
                        {
                            Console.WriteLine("La mayor es" + fecha1.ToString());
                        }
                        else if (resultado > 0)
                        {
                            Console.WriteLine("La mayor es" + fecha.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Las dos fechas son iguales...");
                        }
                        break;
                    case 5:
                        fecha = introducirFecha();
                        Console.WriteLine(fecha.ToString("D"), CultureInfo.CreateSpecificCulture("es-MX"));
                        break;
                    case 6:
                        Console.WriteLine("VOLVEMOS AL MENÚ PRINCIPAL");
                        break;
                }
            } while (opcion != 6);

        }

    }
}
