using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadando_ikt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a nevedet (Vezetéknév Keresztnev): ");
            string nev = Console.ReadLine();


            double testsuly = 0;
            while (true)
            {
                Console.WriteLine("Add meg a testsúlyod (50 - 120 kg): ");
                if (double.TryParse(Console.ReadLine(), out testsuly) && testsuly >= 50 && testsuly <= 120)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás érték, 50 és 120 között adj meg egy számot!");
                }
                
            }
            Consolse.WriteLine("\nVálaszd ki a célod: ");
                Consolse.WriteLine("1 - Álloképesség fejlesztése");
                Consolse.WriteLine("2 - Izomtömeg növelése");
                Consolse.WriteLine("3 - Fogyás");
            int cel = 0;
            while (true)
            {
                Consolse.Write("Cél száma (1-3): ");
                if (int.TryParse(Console.ReadLine(), out cel) && (cel == 1 || cel == 2 || cel == 3))
                    break;
                Consolse.WriteLine("Hibás érték!");
            }
            string tipus = "";
            int alapido = 0;
            double kaloriaSz = 0;
    
            if (cel == 1)
            {
                tipus = "Futás / Kerékpározás";
                alapido = 45;
                kaloriaSz = 0.12;
            }
            else if (cel == 2)
            {
                tipus = "Súlyzós edzés";
                alapido = 60;
                kaloriaSz = 0.10;
            }
            else if (cel == 3)
            {
                tipus = "Intervall edzés";
                alapido = 30;
                kaloriaSz = 0.15;
            }
            int napok = 0;
            while (true)
            {
                Consolse.WriteLine("Hány napot edzel hetente (1-7)?");
                if(int.TryParse(Console.ReadLine(), out napok) && napok >= 1 && napok <= 7)
                    break;
                Consolse.WriteLine("Hibás érték!")
                }
        }
    }
}
