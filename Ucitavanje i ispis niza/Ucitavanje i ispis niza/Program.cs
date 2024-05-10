// See https://aka.ms/new-console-template for more information


Console.WriteLine("Unesite koliko zelite da imate clanova niza ");
int brojElemenataNiza = int.Parse(Console.ReadLine());

int suma = 0;
double aritmetickaSredina = 0;

int[] nizBrojeva = new int[brojElemenataNiza];

for (int i = 0; i < nizBrojeva.Length; i++)
{
    Console.Write($"Unesite element  niza na poziciji {i+1} : ");
    nizBrojeva[i] = int.Parse(Console.ReadLine());
    suma += nizBrojeva[i];
}

Console.WriteLine("Niz je napunjen ");

foreach (int broj in nizBrojeva)
{
    Console.Write(broj +" ");
}


Console.WriteLine();
Console.WriteLine($"Nasa suma je {suma}");
aritmetickaSredina = suma / (double)nizBrojeva.Length;
Console.WriteLine($"Sredina je {aritmetickaSredina}");



