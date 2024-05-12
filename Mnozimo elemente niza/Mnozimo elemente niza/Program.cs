// See https://aka.ms/new-console-template for more information
//
//
// 


int b=   KolikoElemenata();

int[] niz= NapraviNiz(b);

Console.WriteLine("Stampamo obican");
Stampaj(niz);

int [] niz2= PomnozenoSaDva(niz);
Console.WriteLine("Stampamo sa dva");
Stampaj(niz2);

int [] niz3=  PomnozenoSaTri(niz);

Console.WriteLine("Stampamo sa tri");
Stampaj(niz3);


static int KolikoElemenata()
{
    Console.WriteLine("Koliko elemenata ");
    int broj = int.Parse(Console.ReadLine());
    return broj;
}

static int[] NapraviNiz(int broj )
{
    Random ran =new Random();
    int[] niz = new int[broj];
    for ( int i = 0;i<niz.Length;i++)
    {

        
        niz[i]=ran.Next(0,50);

    }

    return niz;
}

static int[] PomnozenoSaDva(int[] niz)
{
    int[] nizDva= new int[niz.Length];
    for ( int i = 0;i<nizDva.Length;i++)
    {
        nizDva[i] = niz[i] * 2;
    }
    return nizDva;
}

static int[] PomnozenoSaTri(int[] niz)
{
    int[] nizTri = new int[niz.Length];
    for (int i = 0; i < nizTri.Length; i++)
    {
        nizTri[i] = niz[i] * 3;
    }
    return nizTri;
}

static void Stampaj(int[] niz)
{
    foreach (int broj in niz)
    {
        Console.WriteLine(broj +" ");
    }
    Console.WriteLine();
}


