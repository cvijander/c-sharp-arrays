// See https://aka.ms/new-console-template for more information
Console.WriteLine();

int duplikat = 0;
int[] nizDuplikata;
int index = 0;


int brojE =  BrojElemenata();
int [] niz=  NapraviNiz(brojE);
nizDuplikata = new int[niz.Length];
Stampaj(niz);
Console.WriteLine();
Console.WriteLine();


/*
foreach (int vrednost in niz)
{
    bool ima = false;

    foreach (int vrednostPonovljenih in nizDuplikata)
    {
        if (vrednostPonovljenih == vrednost)
        {
            ima = true;
        }
    }

    if (!ima)
    {
        nizDuplikata[duplikat] = vrednost;
        duplikat++;
    }
}
Console.WriteLine("Duplikat je " + duplikat);
*/

for (int m = 0; m < niz.Length; m++)   // 5 
{
    bool nesto = false;
    for (int n = 0; n < nizDuplikata.Length; n++)   //25 
    {
        if (niz[m] == nizDuplikata[n])
        {
            nesto = true;
        }
    }
    if(!nesto)
    {
        nizDuplikata[duplikat] = niz[m];
        duplikat++;
    }
}

Stampaj(nizDuplikata);


Console.WriteLine("Broj razlicitih brojeva je " + duplikat);



static int BrojElemenata()
{
    Console.WriteLine("Koliko zelite elemenata ? ");
    int brojElemenata = int.Parse(Console.ReadLine());
    return brojElemenata;
}

 int[] NapraviNiz(int broj)
{

    int prekidniBroj = 999;
    int[] niz = new int[broj];
    for (int i = 0; i < niz.Length; i++)
    {
        Console.Write("Unesite broj (999 je za prekid unosa ako zelite ranije ) ");
        int unos = int.Parse(Console.ReadLine());
        if (prekidniBroj ==unos)
        {
            break;
        }
        else
        {
            niz[i] = unos;
            index++;
        }
       
    }

    return niz;
}



static void Stampaj(int[] a)
{
    foreach (int broj in a)
    {
        Console.Write(broj +" " );
    }
}


