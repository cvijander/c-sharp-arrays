// See https://aka.ms/new-console-template for more information


int broj = 10;
int[] nizBrojeva = new int[5];  // 0 0 0 0 0
nizBrojeva[0] = 15;   // 15 0 0 0 0

MenjaVrednosti(broj, nizBrojeva);

Console.WriteLine("Stampanje brojeva nakon metode");

Console.WriteLine(broj);
Console.WriteLine();

foreach (int promenljiva in nizBrojeva)
{
    Console.Write(promenljiva +" ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Nakon metode koja vraca broj ");
Console.WriteLine();
int vracabroj= MenjaVrednosti2(broj, nizBrojeva);

broj = MenjaVrednosti2(broj, nizBrojeva);

Console.WriteLine(vracabroj);
Console.WriteLine(broj);

Console.WriteLine();
foreach (int promenljiva in nizBrojeva)
{
    Console.Write(promenljiva + " ");
}
Console.WriteLine();


static void MenjaVrednosti(int br, int[] nz)
{
    br = br + 1000; //1010
    nz[2] = 150;                  // 15 0 150 0 0 
    nz[nz.Length - 1] = 999;      // 15 0 150 0 999
}


static int MenjaVrednosti2(int br, int[] nz)
{
    br = br + 2000; //1010
    nz[1] = 200;
    return br;
}
    // 15 0 150 0 0 
    
