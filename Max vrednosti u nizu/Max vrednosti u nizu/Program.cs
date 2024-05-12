// See https://aka.ms/new-console-template for more information

int[] nizBrojeva = new int[4] { 99, 11, 5, 4 };

Ispisi(nizBrojeva);

Ispisi(new int[] { 10, 152, 35 });


static void Ispisi(int[] niz)
{
    int max = niz[0];
	for (int i = 0; i < niz.Length; i++)
	{
		if(max < niz[i])
		{
			max = niz[i];
		}
	}
    Console.WriteLine("Max je " +max);
}