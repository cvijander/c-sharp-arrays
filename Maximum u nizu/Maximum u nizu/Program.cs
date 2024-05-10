// See https://aka.ms/new-console-template for more information


int[] nizBrojeva = new int[] { 33, 54, 8, 1012, 456, 98 };

int max=nizBrojeva[0];  // 33  54 54 1012 1012  1012 

for (int i = 0;i<nizBrojeva.Length;i++)
{
    if(max > nizBrojeva[i])
    {
        Console.WriteLine("Trenutno je max veci " +max);
    }

    else if (max < nizBrojeva[i])
    {
        max = nizBrojeva[i];
        Console.WriteLine("Moj max je manji od " +max);
    }

}