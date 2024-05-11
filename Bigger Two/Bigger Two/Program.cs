// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Niz 1");
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        Console.WriteLine("Niz 2");
        int brE2 = VelicinaNiza();
        int[] nizBr2 = NapraviNiz(brE2);

        StampajClanoveNiza(nizBr2);

       int [] r=  BiggerTwo(nizBr, nizBr2);

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

    public static int[] BiggerTwo(int[]a , int[] b)
    {
        
        int sumaA = 0;
        int sumaB = 0;

        for (int i = 0; i < a.Length; i++)
        {
            sumaA += a[i];
        }

        for (int j = 0; j < b.Length; j++)
        {
            sumaB += b[j];
        }
        
        if (sumaA > sumaB)
        {
            Console.WriteLine($"Stampamo elemente niza a cija je suma: {sumaA}  ");
            return a;
        }
         else
        {
            Console.WriteLine($"Stampamo elemente niza b cija je suma: {sumaB}  ");
            return b;
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

    public static void StampajClanoveNiza(int[] niz)
    {
        foreach (int item in niz)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }


}

