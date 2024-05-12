﻿// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        int brE = VelicinaNiza();
        int[] nizBr = NapraviNiz(brE);

        StampajClanoveNiza(nizBr);

        int[] noviN= NarneElementeNaNeparnim(nizBr);



        StampajClanoveNiza(noviN);



    }

    public static int VelicinaNiza()
    {
        bool nesto = false;
        int brElemenata = 0;

        do
        {
            
            Console.Write("Koliko elemenata zelite:  ");
            int brojUlaz = int.Parse(Console.ReadLine());
            if (brojUlaz <= 10)
            {
                 brElemenata = brojUlaz;
                nesto = true;
            }
            else
            {
                Console.WriteLine("Greska do 10 elementata ili ako unesete -1 prekida program");
                nesto =false;
            }

        } while (nesto==false);
        

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
            Console.WriteLine("Unesite ceo broj pozitivan   ili -1 za prekid ");
            int broj=int.Parse(Console.ReadLine());
            if(broj >0)
            {
                nizBrojeva[i] = broj;
            }
            else if(broj == -1)
            {
                break;
            }
           

        }
        return nizBrojeva;
    }

    public static int[] NarneElementeNaNeparnim(int[] a)
    {
        int[] n = new int[a.Length];
        for (int i = 1; i < n.Length; i+=2)
        {
            if (a[i] %2 ==0)
            {
                n[i] = a[i];
            }
            
        }
        return n;
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

