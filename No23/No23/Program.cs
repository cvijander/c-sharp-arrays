// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        bool r= No23(nizBr);
        Console.WriteLine(r);

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

    public static bool No23(int[] a)
    {
        bool dva =false;
        bool tri =false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i]==2)
            {
                dva = true;
            }
            if (a[i]==3 )
            {
                tri = true;
            }
          
        }
        if(dva==true && tri==true)
        {
            return true;
        }
        return false;
         

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




