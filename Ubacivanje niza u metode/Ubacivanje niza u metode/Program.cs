internal class Program
{
    private static void Main(string[] args)
    {
        int[] nizBrojeva = new int[3] { 1, 2, 3 };

        Ispisi(nizBrojeva);

    }


        public static void Ispisi(int[] brojParam)
        {
           foreach (int promenljiva in brojParam)
        {
            Console.WriteLine(promenljiva + 2);
        }
    }
    }
