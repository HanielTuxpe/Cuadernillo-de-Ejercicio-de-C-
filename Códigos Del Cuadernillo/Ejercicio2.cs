using System;
namespace Ejercicio2
{
    class program
    {
        static void Main (string[]args)
        {
            //Declaración de variables
            double np = 0, cc = 0, tp = 0, tg = 0, p = 0;;
            //Entrada
            Console.WriteLine("Calcule la cantidad de pan que genera al día y la ganancia");
            Console.WriteLine("¿Cuántos panes caben en una charola?");
            np = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántas charolas meten al horno por día?");
            cc = double.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuánto cuesta el pan por pieza?");
            p = double.Parse(Console.ReadLine());
            //Proceso
            tp = np * cc;
            tg = tp * p;
            //salida
            Console.WriteLine("El total de produccion de panes en un dia es de: " + tp);
            Console.WriteLine("La ganancia total por la venta de" + np + "panes en un dia es de: $" + tg);
            Console.ReadKey();
        }
    }
}
