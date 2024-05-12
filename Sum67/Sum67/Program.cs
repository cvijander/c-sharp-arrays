// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        int rez = Sum67(nizBr);
        Console.WriteLine(rez);

        Console.WriteLine("moje resenmje");
        int rez1 = Sum672(nizBr);
        Console.WriteLine(rez1);

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
        int[] nizBrojeva = new int[brElemenataParam];
        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            Console.WriteLine("Unesite ceo broj ");
            nizBrojeva[i] = int.Parse(Console.ReadLine());

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
    public static int  Sum67(int[] a)
    {
        int sum = 0;
        bool sestica = false;
        int indexSestice;
        bool sedmica = true; ;
        int indexSedmice;

        //nadji 6 i7 

        for (int i = 0; i < a.Length; i++)
        {
            if (sedmica)
            {

                if (a[i] == 6)
                {
                    sedmica = false;

                }
                if (a[i] != 6)
                {
                    sum += a[i];

                }
            }
             else  if (a[i] == 7)
            {
                sedmica = true;
               
            }
        }

        return sum;
    }


    public static int Sum672(int[] a)
    {
        int sum = 0;
        bool lokacija = false;
        bool sestica = false;
        int indexSestice=0;
        bool sedmica = true; ;
        int indexSedmice=0;

        //nadji 6 i7 

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 6)
            {
                sestica = true;
                lokacija = true;
                indexSestice = i;
            }
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == 7)
            {
                sestica = true;
                lokacija = true;
                indexSedmice = i;
            }
        }
        if (indexSestice < indexSedmice && indexSestice != 0 && indexSedmice != 0)
        {
            for (int m = 0; m < indexSestice; m++)
            {
                sum += a[m];
            }

            for (int n = indexSedmice + 1; n < a.Length; n++)
            {
                sum += a[n];
            }
        }
        else
        {


            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
        }
        return sum; 
        
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


