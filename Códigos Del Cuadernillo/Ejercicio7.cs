namespace ejercicio_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E, F, G, H,I, J, K, L;
            double TPM1,TPM2,TPM3,TPM4, TPM11, TPM22, TPM33, TPM44, TPM111, TPM222,
                TPM333, TPM444,TPMU,TPMD,TPMT,TPMC,DT, D1, D2, D3;
            Console.WriteLine("prendas vendias el priar dia");
            Console.WriteLine("prendas vendidas del modelo 1");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 2");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 3");
            C  = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 4");
            D = int.Parse(Console.ReadLine());
            TPM1 = (A * 50) - (A * 30);
            TPM2 = (B * 70) - (B * 60);
            TPM3 = (C * 200) - (C * 160);
            TPM4 = (D * 150) - (D * 120);
            D1 = TPM1 + TPM2 + TPM3 + TPM4;
            Console.WriteLine("prendas vendias el segundo dia");
            Console.WriteLine("prendas vendidas del modelo 1");
            E = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 2");
            F = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 3");
            G = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 4");
            H = int.Parse(Console.ReadLine());
            TPM11 = (E * 50) - (E * 30);
            TPM22 = (F * 70) - (F * 60);
            TPM33 = (G * 200) - (G * 160);
            TPM44 = (H * 150) - (H * 120);
            D2 = TPM11 + TPM22 + TPM33 + TPM44;
            Console.WriteLine("prendas vendias el tercer dia");
            Console.WriteLine("prendas vendidas del modelo 1");
            I = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 2");
            J = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 3");
            K = int.Parse(Console.ReadLine());
            Console.WriteLine("prendas vendidas del modelo 4");
            L = int.Parse(Console.ReadLine());
            TPM111 = (I * 50) - (I * 30);
            TPM222 = (J * 70) - (J * 60);
            TPM333 = (K * 200) - (K * 160);
            TPM444 = (L * 150) - (L * 120);
            D3 = TPM111 + TPM222 + TPM333 + TPM444;
            TPMU = TPM1 + TPM11 + TPM111;
            TPMD = TPM2 + TPM22 + TPM222;
            TPMT = TPM3 + TPM33 + TPM333;
            TPMC = TPM4 + TPM44 + TPM444;
            DT = D1 + D2 + D3;
            Console.WriteLine("GANANCIAS DEL MODELO 1 ES: " + TPMU);
            Console.WriteLine("GANANCIAS DEL MODELO 2 ES: " + TPMD);
            Console.WriteLine("GANANCIAS DEL MODELO 3 ES: " + TPMT);
            Console.WriteLine("GANANCIAS DEL MODELO 4 ES: " + TPMC);
            Console.WriteLine("GANANCIA TOTAL DE LOS 3 DIAS ES: " + DT); 
            Console.ReadKey();
        }
    }
}