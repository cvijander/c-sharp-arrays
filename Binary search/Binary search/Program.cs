// See https://aka.ms/new-console-template for more information


int[] nizBrojeva = new int[5] { 99, 5, 12, 1012, -5 };
int broj = 132;

Console.WriteLine();
Stampaj(nizBrojeva);
Console.WriteLine();

// 12 
// -5     12 
Console.WriteLine("Nakon sortriranje");

Array.Sort(nizBrojeva);

Stampaj(nizBrojeva);


Console.WriteLine("Kljuc je ");

int b= BinarySearch1(nizBrojeva, broj);
Console.WriteLine(b);
Stampaj(nizBrojeva);


static int BinarySearch1(int[]a , int kljuc)
{
    int rez = -1;
    int brojac = 0;
   // int pocetna = a[0];  // vrednost na prvoj pozicij               a[]  --vrednost 
                                                                     
    int indexPrve = 0;
   // int zadnja = a[a.Length - 1];
    int indexZadnje = a.Length - 1; // 5 
    
    int middle = indexPrve+ indexZadnje / 2;  // 3 

    while(indexZadnje >= indexPrve)
    {
        
        brojac++;
        if(kljuc == a[middle])
        {
            rez= kljuc;
            return rez;
            

        }
        else if(kljuc < a[middle])
        {
            indexZadnje = middle - 1;
        }
        else
        {
            indexPrve = middle + 1;
        }
        
        return rez;
    }
    
    return rez;
}

static void Stampaj(int[] a)
{
    foreach (int i in a)
    {
        Console.Write(i +" " );
    }
    Console.WriteLine();
}


