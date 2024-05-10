// See https://aka.ms/new-console-template for more information


string[] palete = new string[] { "B14","A11","B12","A13","C15"};

Console.WriteLine("Sortiran");
Array.Sort(palete);

foreach (string item in palete)
{
    Console.WriteLine(" "+item+" ");
}

Console.WriteLine("");

Console.WriteLine("Obrnuti");
Array.Reverse(palete);

foreach (string i in palete)
{
    Console.WriteLine(i);
}