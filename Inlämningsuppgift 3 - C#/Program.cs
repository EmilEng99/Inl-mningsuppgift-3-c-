namespace Inlämningsuppgift_3___C_;

class Program
{
    static void Main(string[] args)
    {
        myFunction();
    }

    static void myFunction()
    {
        bool personNummer = false;

        while (personNummer == false){
        Console.WriteLine("Skriv in ditt personnummer, 10 siffror och i formatet: XXXXXX-XXXX");

        string nummerInput = (Console.ReadLine());
        string dateOfBirth = nummerInput.Replace("-", ""); //tar bort strecket mellan siffrorna

        if(dateOfBirth == "") //ser till att något blir skrivet
        {
            Console.WriteLine("Verkar som att du inte skrev in något, försök igen");
        }
        else if(!Int64.TryParse(dateOfBirth, out long baraSiffor )) // Kollar så att alla tecken är siffor
        {
            Console.WriteLine("Alla tecken var inte siffor, försök igen.");
        }
        else if(dateOfBirth.Length < 10 || dateOfBirth.Length > 10) // Kontrollerar längd
        {
            Console.WriteLine("Personnumret var för kort eller för långt, försök igen.");
        }
        else{ 

            int lastNumber = (dateOfBirth[dateOfBirth.Length - 2]); // tar ut näst sista siffran och för att kontrollera kvinna/man
            if(lastNumber % 2 == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Din näst sista siffa är jämn vilket visar att du är en kvinna.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Din näst sista siffa är ojämn vilket visar att du är en man.");
            }

                dateOfBirth = dateOfBirth.Insert(6,"-"); // sätter tillbaka strecket till samma plats
                Console.WriteLine($"Ditt personnummer är {dateOfBirth}, och är godkänt.");
                break;
            }
        }
    }
}
