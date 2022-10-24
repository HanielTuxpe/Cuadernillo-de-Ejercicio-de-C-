using System;
namespace Ejercicio5
{
    class program
    {
        static void Main (string[]args)
        {
            //Declaración de variables
            double d = 0, t = 0, op = 0, p = 365.55, st = 0, nb = 0;
            //Entrada
            Console.WriteLine("Ofertas del menú del día: ");
            Console.WriteLine("1 = Estudiante | 2 = Adulto | 3 =  Niño");
            op = double.Parse(Console.ReadLine());
            //Proceso
            if(op == 1 || op == 2 || op == 3)
            {
                Console.WriteLine("¿Cuántos boletos va a comprar?");
                nb = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: d = (p * 8) / 100; st = p - d; t = nb * st; break;
                    case 2: d = 0; st = p - d; t = nb * st; break;
                    case 3: d = (p * 50) / 100; st = p - d; t = nb * (p - d); break;
                    default: break;
                }
                st = Math.Round(st, 2);
                t = Math.Round(t, 2);
                //salida
                Console.WriteLine("El descuento es de: $" + d);
                Console.WriteLine("El precio del boleto con descuento incluido es de: $" + st);
                Console.WriteLine("El total a pagar por " + nb + " boletos es de: $" + t);
            }
            else
            {
                Console.WriteLine("Elija una opción correcta");
            }
            Console.ReadKey();
        }
    }
}