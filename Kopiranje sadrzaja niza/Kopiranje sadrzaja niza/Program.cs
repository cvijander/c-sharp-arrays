// See https://aka.ms/new-console-template for more information

int[] nizBrojeva = new int[4] { 85, 25, 11, 4 };
int[] nizB = new int[nizBrojeva.Length];

for (int i = 0; i < nizB.Length; i++)
{
    nizB[i] = nizBrojeva[i];
}

foreach (int n in nizB)
{
    Console.Write(n+" ");
}
Console.WriteLine("Druga petlja ");
foreach (int n in nizBrojeva)
{
    Console.Write(n + " ");
}

