// See https://aka.ms/new-console-template for more information


int[] nizBrojeva = new int[5] { 11, 9 ,87,55,105};

int brojKojiTrazim = 55;

int rez=   PronadjiElement(nizBrojeva, brojKojiTrazim);
Console.WriteLine(rez);



static int PronadjiElement(int[] a , int broj)
{
    int rezultatVracanja=-1;
    for (int i = 0; i < a.Length; i++)
    {
        if (broj == a[i])
        {
            Console.WriteLine($"Nasli smo {broj} i nalazi se na mestu   {(i + 1)}   tj  index  + {i} ");
            rezultatVracanja = i;
            break;

        }
        else

        {
            Console.WriteLine("Nismo nasli -1");
            rezultatVracanja = -1;

        }
    }
    return rezultatVracanja;
}