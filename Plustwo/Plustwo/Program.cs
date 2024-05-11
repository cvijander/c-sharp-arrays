internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Unosimo za prvi niz");
        int brE1 = VelicinaNiza();
        int[] nizBr1 = NapraviNiz(brE1);

        StampajClanoveNiza(nizBr1);

        Console.WriteLine("Unosimo drugi niz");
        int brE2 = VelicinaNiza();
        int[] nizBr2 = NapraviNiz(brE2);

        StampajClanoveNiza(nizBr2);

        Console.WriteLine("Sabiranje dva niza ");
        int[] veliki= PlusTwo(nizBr1, nizBr2);
        StampajClanoveNiza(veliki);



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

    public static int [] PlusTwo(int[] niz1 , int[] niz2)
    {
        int velicina = (niz1.Length + niz2.Length);
        int[] nizVeliki = new int[velicina];
        for (int i = 0; i < niz1.Length; i++)
        {
            nizVeliki[i] = niz1[i];
        }
        for (int j = niz1.Length,m=0; j < nizVeliki.Length;m++, j++)
        {
            nizVeliki[j] = niz2[m];
        }
        return nizVeliki;
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

