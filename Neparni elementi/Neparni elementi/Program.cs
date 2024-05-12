
// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);
        Console.WriteLine();
        int[] p = PomnoziSaDva(nizBr);
        Console.WriteLine();
        StampajClanoveNiza(p);

       

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



    public static int[] NapraviNiz(int brElemenataParam)
    {
        bool nesto = false;

        int[] nizBrojeva = new int[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            do
            {
                Console.WriteLine("Unesite ceo broj ");
                int broj = int.Parse(Console.ReadLine());
                if (broj % 2 != 0)
                {
                    nizBrojeva[i] = broj;
                    nesto = true;
                }
                else
                {
                    Console.WriteLine("Greska ");
                    nesto = false;
                }

            } while (nesto ==false);
            
            

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

    public static int[] PomnoziSaDva(int[] z)
    {
        int[] novi = new int[z.Length];
        for (int i = 0; i < novi.Length; i++)
        {
            novi[i] = z[i] * 2;
        }
        return novi;
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


}

