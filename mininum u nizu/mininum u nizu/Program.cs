// See https://aka.ms/new-console-template for more information

int[] nizBrojeva = new int[] { 55, 11, 8, 102, 985, 1036, 2, 65 };

int min = nizBrojeva[0];

for (int i = 0;i<nizBrojeva.Length;i++)
{
    if(min < nizBrojeva[i])
    {
        Console.WriteLine($"Trenutno je moj {min} manji od clana niza a on je {nizBrojeva[i]} ");
    }

    else if (min > nizBrojeva[i])
    {
        
        Console.WriteLine($"Clan niza je manji od mog trenutnog {min} i clan niza je {nizBrojeva[i]} ");
        min = nizBrojeva[i];
    }
}

Console.WriteLine($"Min je {min}");
