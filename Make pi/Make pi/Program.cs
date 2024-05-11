// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        // int [] nizPi=  MakePi();
        // StampajClanoveNiza(nizPi);

        int[] niz1 = MakePi(nizBr);
        StampajClanoveNiza(niz1);
        

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

    public static int[] MakePi()
    {
       int[] novi = new int[3] { 3,1,4};
        return novi;
    }

    public static int[] MakePi(int[] niz)
    {
        int prva;
        int indexPrve;
        int druga;
        int indexDruge;
        int treca;
        int indexTrece;

        int[] nizPi = new int[3];
        for (int i =0; i<niz.Length;i++)
        {
            if (niz[i] ==3 || niz[i] ==1 || niz[i] ==4)
            {
                Console.WriteLine("Sadrzi sve brojeve");
                if (niz[i]==3)
                {
                    Console.WriteLine($"Nasao sam {niz[i]} na lokaciji {i}");
                    prva = niz[i];
                    indexPrve = i;
                    nizPi[0] = niz[indexPrve];
                }
                if (niz[i] == 1)
                {
                    Console.WriteLine($"Nasao sam {niz[i]} na lokaciji {i}");
                    druga = niz[i];
                    indexDruge = i;
                    nizPi[1] = niz[indexDruge];
                }
                if (niz[i] == 4)
                {
                    Console.WriteLine($"Nasao sam {niz[i]} na lokaciji {i}");
                    treca = niz[i];
                    indexTrece = i;
                    nizPi[2] = niz[indexTrece];
                }
                
            }
        }


        return nizPi;
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

