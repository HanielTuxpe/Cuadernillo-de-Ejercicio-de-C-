using System;
namespace Ejercicio4
{
    class program
    {
        static void Main (string[]args)
        {
            //Declaración de variables
            double d = 0, t = 0, op = 0;
            //Entrada
            Console.WriteLine("Ofertas del menú del día: ");
            Console.WriteLine("1 = Antojitos mexicanos");
            Console.WriteLine("2 = Milanesa de res|Bistec a la mexicana|Pollo a la crema");
            Console.WriteLine("3 = Comida especial del día");
            op = double.Parse(Console.ReadLine());
            //Proceso
            if(op == 1 || op == 2 || op == 3)
            {
                switch (op)
                {
                    case 1: d = (35 * 8) / 100; t = 35 - d; break;
                    case 2: d = (40 * 5) / 100; t = 40 - d; break;
                    case 3: d = (50 * 10) / 100; t = 50 - d; break;
                    default: break;
                }
                //salida
                Console.WriteLine("El descuento es de: $" + d);
                Console.WriteLine("El precio de su orden es de: $" + t);
            }
            else
            {
                Console.WriteLine("Elija una opción correcta");
            }
            Console.ReadKey();
        }
    }
}