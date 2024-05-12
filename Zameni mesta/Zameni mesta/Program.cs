// See https://aka.ms/new-console-template for more information

int[] nizBrojeva = new int[4] { 99, 1, 5, 45 };
Console.WriteLine("Pre pozivanja ");
Console.WriteLine($"Niz je {nizBrojeva[0]} i {nizBrojeva[nizBrojeva.Length-1]}  ");
Console.WriteLine("Pozivamo zameni pozicije ali sa int");
ZameniPozicije(nizBrojeva[0], nizBrojeva[nizBrojeva.Length - 1]);
Console.WriteLine("Nakon toga ");
Console.WriteLine($"Niz je {nizBrojeva[0]} i {nizBrojeva[nizBrojeva.Length - 1]}  ");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Sad radimo drugu metodu ");


Console.WriteLine("Pre pozivanja ");
Console.WriteLine($"Niz je {nizBrojeva[0]} i {nizBrojeva[nizBrojeva.Length - 1]}  ");
Console.WriteLine("Pozivamo zameni pozicije ali sa int");
ZameniPozicijeNiza(nizBrojeva);
Console.WriteLine("Nakon toga ");
Console.WriteLine($"Niz je {nizBrojeva[0]} i {nizBrojeva[nizBrojeva.Length - 1]}  ");

Array.Sort(nizBrojeva);
foreach( int i in nizBrojeva)
{
    Console.Write(i+" " );
}

static void ZameniPozicije(int b1, int b2)
{
    int temp1 = b1;
     b1 = b2;
    b2 = temp1;
}

 static void ZameniPozicijeNiza(int[] niz)
{
    int temp = niz[0];
    niz[0] = niz[niz.Length-1];
    niz[niz.Length-1] = temp;
}
