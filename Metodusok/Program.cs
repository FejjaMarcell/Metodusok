namespace Metodusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            // Írj metódust, mely egy szövegben megkeresi a leghosszabb szót,
            // és annak a hosszaát adja vissza.

            string szoveg = "Ebben a szövegben a leghosszabb szó a leghosszabb.";

            Console.WriteLine(Leghosszabb_szo(szoveg));

            static int Leghosszabb_szo (string szoveg)
            {
                string[] darabok = szoveg.Split(' ');
                int max = 0;
                for (int i = 0; i < darabok.Length; i++)
                {
                    if (darabok[i].Length > darabok[max].Length)
                    {
                        max = i;
                    }
                }
                return darabok[max].Length;
            }


            Console.WriteLine("Osztandó:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Osztó:");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hányados: {Osztas(x, y, out int maradek)}");
            Console.WriteLine($"Maradék: {maradek}");

            static int Osztas(int x, int y, out int maradek)
            {
                maradek = x % y;
                return x / y;
            }
        }
    }
}
