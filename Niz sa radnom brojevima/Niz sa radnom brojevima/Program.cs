// See https://aka.ms/new-console-template for more information

   Random broj = new Random();
  int brElemenata=  broj.Next(0, 50);

int[] nizElemenata = new int[brElemenata];

for(int i=0; i<nizElemenata.Length; i++)
{
    int Elementi = broj.Next(50, 100);

    nizElemenata[i] = Elementi;
}
Console.WriteLine();

foreach (int i in nizElemenata )
{
    Console.Write(i +" ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Sortitanje");
Array.Sort(nizElemenata);


foreach (int i in nizElemenata)
{
    Console.Write(i + " ");
}
Console.WriteLine();

