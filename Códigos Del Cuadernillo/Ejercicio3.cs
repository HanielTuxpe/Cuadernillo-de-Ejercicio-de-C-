using System;
namespace Ejercicio3
{
    class program
    {
        static void Main (string[]args)
        {
            //Declaración de variables
            double n = 0;
            //Entrada
            Console.WriteLine("Ingrese un número para verificar que sea multiplo de 14");
            n = double.Parse(Console.ReadLine());
            //Proceso
            if(n == 0)
            {
                Console.WriteLine("Ingrese un número válido");
            }
            else
            {
                if(n % 14 == 0)
                {
                    Console.WriteLine(n + " Es multiplo de 14");
                }
                else
                {
                    Console.WriteLine(n + " no es multiplo de 14");   
                }
            }
            //salida
            Console.ReadKey();
        }
    }
}
