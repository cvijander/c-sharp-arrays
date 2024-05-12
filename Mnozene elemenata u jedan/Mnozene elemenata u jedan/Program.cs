


internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        Console.WriteLine();
        int [] dupli= NapraviDupliManjiNiz(nizBr);
        StampajClanoveNiza(dupli);



    }

    public static int VelicinaNiza()
    {
        bool vrednost = false;
        Console.Write("Koliko elemenata zelite:  ");
        int brElemenata = int.Parse(Console.ReadLine());
        if(brElemenata %2==0)
        {
            brElemenata = brElemenata;

        }
        else if (brElemenata %2 !=0)
        {
            Console.WriteLine("Greska ");
            brElemenata = 0;
        }
        
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
        Random r = new Random();
        int[] nizBrojeva = new int[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            //Console.WriteLine("Unesite ceo broj ");
            nizBrojeva[i] = r.Next(1, 50);

        }
        return nizBrojeva;
    }

    public static int[] NapraviDupliManjiNiz(int[] a)
    {
        int k = 0;
        int[] nizDupli = new int[a.Length/2];
        for (int i = 0; i < nizDupli.Length; i++)
        {
            //Console.WriteLine("Unesite ceo broj ");
            nizDupli[i] = (a[k]/a[k+1]);
            k += 2;
        }
        return nizDupli;
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


}

