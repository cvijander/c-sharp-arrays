// See https://aka.ms/new-console-template for more information



string[] palete = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(palete, 0, 2);   


Console.WriteLine($"Clearing 2 ... count: {palete.Length}");
foreach (var pallet in palete)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref palete, 6);
Console.WriteLine($"Resizing 6 .. count : {palete.Length}");

palete[4] = "C01";
palete[5] = "C02";

foreach (var pallet in palete)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref palete, 3);
Console.WriteLine($"Resizing 3 .. count : {palete.Length}");
foreach (var pallet in palete)
{
    Console.WriteLine($"-- {pallet}");
}

palete[0] = "AAA";
foreach (var pallet in palete)
{
    Console.WriteLine($"-- {pallet}");
}
