
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Niz a");
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);
        Console.WriteLine();

        int broj=  MaxTriple(nizBr);
        
        Console.WriteLine(broj);

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

    public static int[] MiddleWay(int[] a, int[] b)
    {
        int sredinaA = a.Length / 2;
        int sredinaB = b.Length / 2;
        int[] nizC = new int[2] { a[sredinaA], b[sredinaB] };
        return nizC;
    }

    public static int MaxTriple(int[] a)
    {
        int max = 0;
        int prvi = a[0];
        int zadnji = a[a.Length-1];
        int srednji = a[a.Length / 2];
        if(a.Length %2 !=0)
        {
            if (prvi > zadnji && prvi > srednji)
            {
                max=prvi;
            }
            else if(zadnji > prvi && zadnji >srednji)
            {
               max= zadnji;
            }
            else
            {
               max= srednji;
            }
        }
        return max;

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



    public static int[] MakeMiddle(int[] a)
    {


        int[] nizC = new int[2] { a[(a.Length / 2) - 1], a[(a.Length / 2)] };


        return nizC;
    }

    public static int[] MakeMiddle1(int[] a)
    {


        int[] nizC = new int[1] { a[a.Length / 2] };


        return nizC;
    }

    public static int[] Sredina(int[] a)
    {
        int[] n = new int[a.Length];
        if (a.Length % 2 == 0)
        {
            n = MakeMiddle(a);

        }
        else if (a.Length % 2 != 0)
        {
            n = MakeMiddle1(a);

        }
        return n;

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





