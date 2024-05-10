using System;

internal class Program
{
    private static void Main(string[] args)
    {

         int brojElemenataNiza=  BrojClanova();

         int[] nizBr = NapraviNiz(brojElemenataNiza);

          int sumaElemenata= NapraviSumu(nizBr);
       

        IspisClanovaNiza(nizBr);      
        


        double ariSredina=   IzracunavanjeArSredine(nizBr, sumaElemenata);
        Console.WriteLine($"Sredina je {ariSredina}");

        int max = NadjiMax(nizBr);
        Console.WriteLine( "Najveci broj je " +max );
    }




    public static int BrojClanova()
    {
        Console.Write("Unesite koliko zelite da imate clanova niza: ");
        int brojElemenataNiza = int.Parse(Console.ReadLine());
        return brojElemenataNiza;
    }

    public static int[] NapraviNiz(int brojElemenataNiza)
    {
        int[] nizBrojeva = new int[brojElemenataNiza];

        for (int i = 0; i < nizBrojeva.Length; i++)
        {
            Console.Write($"Unesite element  niza na poziciji {i + 1} : ");
            nizBrojeva[i] = int.Parse(Console.ReadLine());
            //suma += nizBrojeva[i];
        }

        Console.WriteLine("Niz je napunjen ");
        return nizBrojeva;
    }

    public static int NapraviSumu(int[] nizElemenata)
    {
        int suma = 0;
        
        for (int i = 0; i < nizElemenata.Length; i++)
        {
           suma += nizElemenata[i];
        }
        Console.WriteLine($"Nasa suma je {suma}");
        return suma;
    }



    public static void IspisClanovaNiza(int[] nizBrojeva)
    {
        Console.WriteLine();
        Console.WriteLine("Metoda koja vrsi ispis clanova niza ");
        foreach (int broj in nizBrojeva)
        {
            Console.Write(broj + " ");
        }
        Console.WriteLine();
        
    }

    public static double IzracunavanjeArSredine(int[] niz, int s)
    {
        Console.WriteLine("Izracunavamo aritmeticku sredinu ");
        double sredina = 0;
          sredina= s / (double)niz.Length;
        return sredina;
    }

    public static int NadjiMax (int[] niz)
    {
        int max = niz[0];
        foreach (int broj in niz)
        {
            if(max < broj)
            {
                max=broj;
            }
        }
        
        return max;
    }
}