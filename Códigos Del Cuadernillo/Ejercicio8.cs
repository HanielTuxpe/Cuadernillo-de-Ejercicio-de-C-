namespace ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NA = 0;
            double CB = 0;
            Console.WriteLine("NUMERO DE ALUMNOS: ");
            NA = int.Parse(Console.ReadLine());
            if (NA >= 150)
            {
                CB = 70;
                Console.WriteLine("EL COSTO DEL  VOLETO POR ALUMNO ES: " + CB);
            }
            else 
                if (NA <= 100 && NA > 90 )
            {
                CB = 80;
                Console.WriteLine("EL COSTO DEL  VOLETO POR ALUMNO ES: " + CB);
            }
            else 
                if (NA <= 90 && NA > 30)
            {
                CB = 90;
                Console.WriteLine("EL COSTO DEL  VOLETO POR ALUMNO ES: " + CB);
            }
            else 
               if (NA <= 30 && NA > 0)
            {
                CB = 5000;
                Console.WriteLine("EL COSTO DEL AUTOBUS ES: " + CB);
            }
            else 
                if (NA <= 0)
            {
                Console.WriteLine("verificar la cantidad de alumnos");
            }
            Console.ReadKey();
        }
    }
}