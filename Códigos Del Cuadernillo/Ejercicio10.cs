namespace ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char E;
            double PDP,CDM = 0;
            Console.WriteLine("PAQUETERIA HUEJUTLA");
            Console.WriteLine("LUGAR DE EMVIO");
            E = char.Parse(Console.ReadLine());
            Console.WriteLine("PESO DEL PAQUETE");
            PDP = double.Parse(Console.ReadLine());
            if (E == 'L' || E == 'l' || E == 'G' || E == 'g' || E == 'M' || E == 'm' || E == 'Q' || E == 'q')
            {
                switch (E)
                {
                    case 'L':
                    case 'l':
                        CDM = PDP * 15;
                        break;
                    case 'G':
                    case 'g':
                        CDM = PDP * 20;
                        break;
                    case 'M':
                    case 'm':
                        CDM = PDP * 25;
                        break;
                    case 'Q':
                    case 'q':
                        CDM = PDP * 10;
                        break;
                }
                Console.WriteLine("PRECIO DE EMVIO DEL PAQUE: " + CDM + " PESOS");
            }
            else
            {
                Console.WriteLine("VERIFICAR EL LUGAR DE EMVIO");
            }
            Console.ReadKey();
        }
    }
}