// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        string[] nizBr = NapraviNiz(brE);

        StampajClanoveNizaS(nizBr);

        

    }

    public static int VelicinaNiza()
    {
        Console.Write("Koliko elemenata zelite:  ");
        int brElemenata = int.Parse(Console.ReadLine());
        return brElemenata;
    }

    public static int Promenljiva()
    {
        Console.Write("Unesite promenljivu:  ");
        int promenljiva = int.Parse(Console.ReadLine());
        return promenljiva;
    }



    public static string[] NapraviNiz(int brElemenataParam)
    {
        Random r = new Random();
        
        string [] nizBrojeva = new   string[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            char one = (char)r.Next(65, 90);
            char two = (char)r.Next(65, 90);
            int broj = r.Next(100, 1000);
            string sifra = one+"" + two+""+ broj.ToString();
            nizBrojeva[i] = sifra;

        }
        return nizBrojeva;
    }

    public static bool FirstLast6(int[] nums)
    {
        Console.WriteLine("Proveravamo da li je prvi ili zadnji element = 6 ");
        if (nums[0] == 6 || nums[nums.Length - 1] == 6)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool FirstLast6(int[] nums, int promenljiva)
    {
        Console.WriteLine($"Proveravamo da li je prvi ili zadnji element = {promenljiva} ");
        if (nums[0] == promenljiva || nums[nums.Length - 1] == promenljiva)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int BigDiff(int[] a)
    {
        int max = a[0];
        int min = a[0];

        for (int i = 0; i < a.Length; i++)
        {
            if (max < a[i])
            {
                max = a[i];
            }

            if (min > a[i])
            {
                min = a[i];
            }
        }
        int razlika = max - min;
        return razlika;

    }

    public static void StampajClanoveNiza(int[] niz)
    {
        foreach (int item in niz)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void StampajClanoveNizaS(string[] niz)
    {
        foreach (string item in niz)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


}

