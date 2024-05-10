using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {



        // initialize variables - graded assignments 
        int currentAssignments = 5;

        int petar1 = 92;
        int petar2 = 89;
        int petar3 = 81;
        int petar4 = 96;
        int petar5 = 90;

        int milica1 = 90;
        int milica2 = 86;
        int milica3 = 87;
        int milica4 = 98;
        int milica5 = 100;

        int emma1 = 90;
        int emma2 = 85;
        int emma3 = 87;
        int emma4 = 98;
        int emma5 = 68;

        int logan1 = 90;
        int logan2 = 95;
        int logan3 = 87;
        int logan4 = 88;
        int logan5 = 96;

        // niz je prazan 
        /*
      Console.WriteLine(" ************  ispis tek kreiranog  niza");
      Console.WriteLine(milicineOcene[0]);
      Console.WriteLine(milicineOcene[1]);
      Console.WriteLine(milicineOcene[2]);
      Console.WriteLine(milicineOcene[3]);
      Console.WriteLine(milicineOcene[4]);

      Console.WriteLine(" unosimo vrednosti u niz ");

      milicineOcene[0] = milica1;
      milicineOcene[1] = milica2;
      milicineOcene[2] = milica3;
      milicineOcene[3] = milica4;
      milicineOcene[4] = milica5;

      Console.WriteLine(" ********************");
      Console.WriteLine("Ispis niza sa vrednostima ");

      Console.WriteLine(milicineOcene[0]);
      Console.WriteLine(milicineOcene[1]);
      Console.WriteLine(milicineOcene[2]);
      Console.WriteLine(milicineOcene[3]);
      Console.WriteLine(milicineOcene[4]);


      Console.WriteLine(" ************* ispis preko foreach petlje ");

      foreach(int ocena in milicineOcene)
      {

          Console.WriteLine(ocena);
      }
      */


        // kreiranje nizova 

        int[] milicineOcene = new int[] { 90, 86, 87, 98, 100 };

        int[] petroveOcene = new int[] { 92, 89, 81, 96, 90 };

        int[] anineOcene = new int[] { 90, 85, 87, 98, 68 };

        int[] miloseveOcene = new int[] { 90, 95, 87, 88, 96 };

        int zbirMilicinihOcena = 0;
        int zbirPetrovihOcena = 0;
        int zbirAninihOcena = 0;
        int zbirMilosevihOcena = 0;
        decimal milicaProsek = 0;
        decimal petarProsek = 0;
        decimal anaProsek = 0;
        decimal milosProsek = 0;
        int pretvaranjeOceneUSlovo = 0;

        // kreiranje niza koji sadrzi imena studenata 

        string[] imenaStudenata = new string[] { "Milica", "Petar", "Ana", "Milos" };

        // int[] studentskeOcene = new int[10];




        Console.WriteLine("Student\t\tOcene\n");
        foreach (string ime in imenaStudenata)
        {


            if (ime == "Milica")
            {
                //Console.WriteLine("Pozdrav od Milice");

                foreach (int mil in milicineOcene)
                {
                    zbirMilicinihOcena += mil;
                }
                milicaProsek = (decimal)zbirMilicinihOcena / milicineOcene.Length;
                pretvaranjeOceneUSlovo = (int)milicaProsek;

                string ocenaSlovo = "";

                if (pretvaranjeOceneUSlovo >= 97)
                    ocenaSlovo = "A+";

                else if (pretvaranjeOceneUSlovo >= 93)
                    ocenaSlovo = "A";

                else if (pretvaranjeOceneUSlovo >= 90)
                    ocenaSlovo = "A-";

                else if (pretvaranjeOceneUSlovo >= 87)
                    ocenaSlovo = "B+";

                else if (pretvaranjeOceneUSlovo >= 83)
                    ocenaSlovo = "B";

                else if (pretvaranjeOceneUSlovo >= 80)
                    ocenaSlovo = "B-";

                else if (pretvaranjeOceneUSlovo >= 77)
                    ocenaSlovo = "C+";

                else if (pretvaranjeOceneUSlovo >= 73)
                    ocenaSlovo = "C";

                else if (pretvaranjeOceneUSlovo >= 70)
                    ocenaSlovo = "C-";

                else if (pretvaranjeOceneUSlovo >= 67)
                    ocenaSlovo = "D+";

                else if (pretvaranjeOceneUSlovo >= 63)
                    ocenaSlovo = "D";

                else if (pretvaranjeOceneUSlovo >= 60)
                    ocenaSlovo = "D-";

                else
                    ocenaSlovo = "F";
                Console.WriteLine($"Milica:\t\t {milicaProsek} \t {ocenaSlovo}");
                // studentskeOcene = milicineOcene;

            }
            else if (ime == "Petar")
            {
                

                foreach (int ocenaPetra in petroveOcene)
                {
                    zbirPetrovihOcena += ocenaPetra;
                }
                petarProsek = (decimal)zbirPetrovihOcena / petroveOcene.Length;
                
               
                int pProsek = (int)petarProsek;
                string oce = PretvaranjeOceneUSlovo1(pProsek);
                Console.WriteLine($"Petar: \t\t {petarProsek} \t {oce}");

                
            }
            else if (ime == "Ana")
            {
                //Console.WriteLine("Pozdrav od Ane");

                foreach (int ocenaAna in anineOcene)
                {
                    zbirAninihOcena += ocenaAna;
                }
                anaProsek = (decimal)zbirAninihOcena / anineOcene.Length;
                            
               
               
                int aProsek = (int)anaProsek;
                string oce = PretvaranjeOceneUSlovo1(aProsek);
                Console.WriteLine($"Ana: \t\t {anaProsek} \t {oce}");
                //studentskeOcene= anineOcene;
            }

            else if (ime == "Milos")
            {
                // Console.WriteLine("Pozdrav od Milosa");


                foreach (int milosevOcena in miloseveOcene)
                {
                    zbirMilosevihOcena += milosevOcena;
                }
                milosProsek = (decimal)zbirMilosevihOcena / miloseveOcene.Length;
                /*
                pretvaranjeOceneUSlovo = (int)milosProsek;

                string ocenaSlovo = "";

                if (pretvaranjeOceneUSlovo >= 97)
                    ocenaSlovo = "A+";

                else if (pretvaranjeOceneUSlovo >= 93)
                    ocenaSlovo = "A";

                else if (pretvaranjeOceneUSlovo >= 90)
                    ocenaSlovo = "A-";

                else if (pretvaranjeOceneUSlovo >= 87)
                    ocenaSlovo = "B+";

                else if (pretvaranjeOceneUSlovo >= 83)
                    ocenaSlovo = "B";

                else if (pretvaranjeOceneUSlovo >= 80)
                    ocenaSlovo = "B-";

                else if (pretvaranjeOceneUSlovo >= 77)
                    ocenaSlovo = "C+";

                else if (pretvaranjeOceneUSlovo >= 73)
                    ocenaSlovo = "C";

                else if (pretvaranjeOceneUSlovo >= 70)
                    ocenaSlovo = "C-";

                else if (pretvaranjeOceneUSlovo >= 67)
                    ocenaSlovo = "D+";

                else if (pretvaranjeOceneUSlovo >= 63)
                    ocenaSlovo = "D";

                else if (pretvaranjeOceneUSlovo >= 60)
                    ocenaSlovo = "D-";

                else
                    ocenaSlovo = "F";
                */

                int mProsek = (int)milosProsek;
                string oce=    PretvaranjeOceneUSlovo1(mProsek);
                Console.WriteLine($"Milos: \t\t {milosProsek} \t {oce}");
                //studentskeOcene = miloseveOcene;
            }

            else
            {
                Console.WriteLine("Greska , nepostoje ime iz niza ");
            }
        }

    


        // trenutna ocena - prosek  =  zbir / duzinaniza 
        //  currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

          string  PretvaranjeOceneUSlovo1(int prosek)
            {
               
                string Slovo = "";
                if (prosek >= 97)
                    Slovo = "A+";                   

                else if (prosek>= 93)
                    Slovo = "A";

                else if (prosek >= 90)
                    Slovo = "A-";

                else if (prosek >= 87)
                    Slovo = "B+";

                else if (prosek >= 83)
                    Slovo = "B";

                else if (prosek >= 80)
                    Slovo = "B-";

                else if (prosek >= 77)
                    Slovo = "C+";

                else if (prosek >= 73)
                    Slovo = "C";

                else if (prosek >= 70)
                    Slovo = "C-";

                else if (prosek >= 67)
                    Slovo = "D+";

                else if (prosek >= 63)
                    Slovo = "D";

                else if (prosek >= 60)
                    Slovo = "D-";

                else
                    Slovo = "F";
                return Slovo;
            }
    
       
        
     



















        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Milica:\t\t" + milicaProsek + "\tA-");
        Console.WriteLine("Petar:\t\t" + petarProsek + "\tB+");
        Console.WriteLine("Ana:\t\t" + anaProsek + "\tB");
        Console.WriteLine("Milos:\t\t" + milosProsek + "\tA-");

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();

    }
}