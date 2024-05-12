internal class Program
{
    private static void Main(string[] args)
    {
        double broj_kvadrata = double.Parse(Console.ReadLine());

        double ukupna_cena = broj_kvadrata *7.61;
        double popust = ukupna_cena * 0.18;
        double konacna_cena =ukupna_cena -popust;

        Console.WriteLine($"The final price is: {konacna_cena} USD.");
        Console.WriteLine($"The discount is: {popust} USD.");
    }
}