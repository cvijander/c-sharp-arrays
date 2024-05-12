// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        string[] nizBr = NapraviNiz(brE);

        int[] nizID = NapraviNizID(brE);


        Console.WriteLine("Stampanje imena");
        StampajClanoveNiza(nizBr);
        Console.WriteLine("Stampanje ID");
        StampajClanoveNiza(nizID);

        string[] r = Prepakivanje(nizBr, nizID);

        StampajClanoveNiza(r);



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
        string[] nizBrojeva = new string[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            Console.WriteLine("Unesite ime ");
            nizBrojeva[i] = (Console.ReadLine());

        }
        return nizBrojeva;
    }

    public static int[] NapraviNizID(int brElemenataParam)
    {
        Random r = new Random();
        int[] nizBrojeva = new int[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {


            nizBrojeva[i] = r.Next(50, 500);

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

    public static string[] Prepakivanje(string[] nizImena, int[] nizID)
    {
        string[] rezultat = new string[nizID.Length*2];
        for (int i = 0,j=1,m=0; i <rezultat.Length;m++, i+=2,j+=2)
        {
            rezultat[i] = nizID[m].ToString();
            rezultat[j] = nizImena[m];

        }
        return rezultat;
    }

    public static void StampajClanoveNiza(int[] niz)
    {
        foreach (int item in niz)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public static void StampajClanoveNiza(string[] niz)
    {
        foreach (string item in niz)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


}

