// See https://aka.ms/new-console-template for more information


int[] nizA = new int[] { 5, 6, 9, 81, 1 ,66};
int[] nizB = new int[nizA.Length];

nizB[0] = nizA[1];
nizB[1] = nizA[0];
nizB[2] = nizA[3];
nizB[3] = nizA[2];
nizB[4] = nizA[5];
nizB[5] = nizA[4];


Console.WriteLine("Stampamo A");

foreach (int n in nizA)
{
    Console.Write(n + " ");
}


Console.WriteLine();
Console.WriteLine("Stampamo B");

foreach (int nb in nizB)
{
    Console.Write(nb + " ");
}
Console.WriteLine();


Console.WriteLine("Rad sa for petljom ");

for (int i =0; i< nizA.Length;i+=2)
{
    Console.Write(nizA[i]+" / ");
}
