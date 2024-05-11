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

        Console.WriteLine("Stampamo velki niz ");
        int [] velikiZbir=   Make2(nizBr,nizBr2);
        StampajClanoveNiza (velikiZbir);

        Console.WriteLine();

        Console.WriteLine("Stampamo  niz od svakog uzmimamo po prvi clan");
        int[] nizOdDva = Make2(nizBr, nizBr2,2);
        StampajClanoveNiza(nizOdDva);

        Console.WriteLine();


        Console.WriteLine("Stampamo  niz koji zavisi da li nas prvi niz ima 2 ili 1 element ili je cak prvi elemetn 0 ");
        int[] nizKojiZavisiOdPrvog = Make23(nizBr, nizBr2);
        StampajClanoveNiza(nizKojiZavisiOdPrvog);

        Console.WriteLine();







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

    public static int[] Make2(int[] a, int[] b)
    {
        int broj = a.Length + b.Length;
        int[] nizV = new int[broj];

        for (int i = 0; i < a.Length; i++)
        {
            nizV[i] = a[i];
        }
        for (int j = a.Length,m=0; j <nizV.Length;m++, j++)
        {
            nizV[j] = b[m];
        }
        return nizV;
        
    }
    public static int[] Make2(int[] a, int[] b, int broj)
    {

        broj = 2;
        int[] nizVeliki = new int[broj];
        nizVeliki[0] = a[0];
        nizVeliki[nizVeliki.Length - 1] = b[0];

        return nizVeliki;
    }

    public static int[] Make23(int[] a, int[] b)
    {
        int[] nizM = new int[2];
        if(a.Length==2)
        {
            nizM[0] = a[0];
            nizM[nizM.Length - 1] = a[1];
            return nizM;
        }
        else if (a[0] == 0 && a.Length == 1)
        {
            nizM[0] = b[0];
            nizM[1] = b[1];
            return nizM;
        }

        else if (a.Length==1) 
        {
            nizM[0] = a[0];
            nizM[nizM.Length - 1] = b[0];
            return nizM;
            
        }
        
        return nizM;
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

