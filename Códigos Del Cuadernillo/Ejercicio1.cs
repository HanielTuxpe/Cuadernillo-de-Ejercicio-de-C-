using System;
namespace Ejercicio1
{
    class program
    {
        static void Main (string[]args)
        {
            //Declaración de variables
            int nt = 0, t = 0;
            //Entrada
            Console.WriteLine("Calcule el precio de total por una conpra de tamales");
            Console.WriteLine("¿Cuántos tamales va a comprar?");
            nt = int.Parse(Console.ReadLine());
            //Proceso
            if(nt <= 100)
            {
                t = nt * 10;
            }
            else
            {
                if(nt > 100 & nt <= 200)
                {
                    t = nt * 8;
                }
                else
                {
                    t = nt * 6;
                }
            }
            Console.WriteLine("El total a pagar por " + nt + " tamales es de: " + t);
            //salida
            Console.ReadKey();
        }
    }
}