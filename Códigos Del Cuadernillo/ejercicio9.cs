namespace ejercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char A;
            double PK = 0, KR, B = 0;
            int CP;
            Console.WriteLine("TIPOS DE AUTOBUS");
            Console.WriteLine("H");
            Console.WriteLine("N");
            Console.WriteLine("R");
            Console.WriteLine("TIPO DE AUTOBUS");
            A = char.Parse(Console.ReadLine());
            Console.WriteLine("CANTIDA DE PERSONAS");
            CP = int.Parse(Console.ReadLine());
            if (CP < 15)
            {
                Console.WriteLine("EL AUTOBUS NO PUEDE SALIR");
            }
            else
            if (A == 'H' || A == 'h' || A == 'N' || A == 'n' || A == 'R' || A == 'r')
            {
                Console.WriteLine("KILOMETROS RECORRIDOS");
                KR = double.Parse(Console.ReadLine());
                switch (A)
                {

                    case 'H':
                    case 'h':
                        PK = 6 * KR;
                        B = CP * PK;
                        break;
                    case 'N':
                    case 'n':
                        PK = 8 * KR;
                        B = CP * PK;
                        break;
                    case 'R':
                    case 'r':
                        PK = 9 * KR;
                        B = CP * PK;
                        break;
                }
                Console.WriteLine("COSTO TOTAL POR PERSONA ES: " + PK + " PESOS");
                Console.WriteLine("COSTO TOTAL ES: " + B + " PESOS");                
            }
            else
            {
                Console.WriteLine("verificar el tipo de autobus");
            }
            Console.ReadKey();
        }
    }
}