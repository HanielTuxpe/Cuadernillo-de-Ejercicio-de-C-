using System.Data;
namespace ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, C,E,CB;
            double B,D,F, TT,CA;
            Console.WriteLine("cantidad de poducto 1 ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de poducto 1 ");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("cantidad de poducto 2 ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de poducto 2 ");
            D = double.Parse(Console.ReadLine());

            Console.WriteLine("cantidad de poducto 3 ");
            E = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio de poducto 3 ");
            F = double.Parse(Console.ReadLine());

            Console.WriteLine("CANTIDAD DEL BILLETE");
            CB = int.Parse(Console.ReadLine());

            TT = Math.Round((A * B) + (C * D) + (E * F),2);
            CA = CB - TT;

            Console.WriteLine("total a pagar es de: " + TT);
            Console.WriteLine("el cambio es de: " + CA);
            Console.ReadLine();
        }
    }
}