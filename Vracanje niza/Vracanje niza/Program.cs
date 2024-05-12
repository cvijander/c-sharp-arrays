// See https://aka.ms/new-console-template for more information

int[] nizBrojeva = new int[] { 1, 2, 3, 4, 5 };
int[] Niz2 = new int[nizBrojeva.Length];


 int [] noviNiz=   VratiNiz(nizBrojeva);
Prikazi(nizBrojeva);

     Prikazi(noviNiz);
VratiNiz1(nizBrojeva);

Prikazi(Niz2);




static int[] VratiNiz(int[]nizB )
{
    int[] novi = new int[nizB.Length];

    for (int i = 0; i < nizB.Length; i+=2)
    {
        novi[i] = nizB[i];
    }
    return novi;
}

 void VratiNiz1(int[] nizB)
{
   
    for (int i = 0; i < nizB.Length; i += 2)
    {
        Niz2[i] = nizB[i];
    }
    
}

static void Prikazi(int[] b)
{
    Console.WriteLine();
    Console.WriteLine("Stampanje");
    foreach (int i in b)
    {
        Console.Write(i +" ");
    }
    Console.WriteLine();
}