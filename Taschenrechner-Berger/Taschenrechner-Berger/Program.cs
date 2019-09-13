using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Berger
{
    class Program
    {
        static void Main(string[] args)
        {
            string entscheidung;

            do
            {
                Console.WriteLine("Geben Sie die erste Zahl ein: ");
                int zahl1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben Sie die zweite Zahl ein: ");
                int zahl2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben Sie die Rechenoperation an");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                int operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hui");
                switch(operation)
                {
                    case 1:
                        int ergebnisAdd = zahl1 + zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnisAdd);
                        break;
                    case 2:
                        int ergebnisSub = zahl1 - zahl2;
                        Console.WriteLine("Das Ergebnis ist: " + ergebnisSub);
                        break;
                }

                Console.WriteLine("Wollen Sie erneut rechnen? Geben Sie J oder N ein.");
                entscheidung = Console.ReadLine();
                Console.Clear();
            }
            while (entscheidung == "j" || entscheidung == "J");
        }
    }
}
