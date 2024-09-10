namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxAnstallda = 10;
            string[] namn = new string[MaxAnstallda];
            int[] lon = new int[10];

            Console.WriteLine("Ange antal anställda att mata in: (Max 10)");
            int antalAnstallda = Convert.ToInt32(Console.ReadLine());

            for (int c = 0; c < antalAnstallda; c++)
            {
                Console.WriteLine("Ange namn:");
                namn[c] = Console.ReadLine();

                Console.WriteLine("Ange lön:");
                lon[c] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Tryck på valfri tangent på tangentbordet för att skriva ut registret");
            Console.ReadKey();

            for (int c = 0; c < antalAnstallda; c++)
            {
                Console.WriteLine(namn[c] +" " + "Lön = " + lon[c] +"kr");
            }

            Console.ReadKey();  
        }
    }
}
