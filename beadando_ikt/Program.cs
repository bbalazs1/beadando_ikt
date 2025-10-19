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
            
            double osszIdo = 0;
            for (int i = 1; i <= napok; i++)
            {
                int erosseg = 0;
                while (true)
                {
                    Console.Write($"Add meg a(z) {i}. nap erősségét (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out erosseg) && erosseg >= 1 && erosseg <= 5)
                        break;
                    Console.WriteLine("Hibás érték! 1 és 5 között adj meg számot.");
                }
    
                double napiIdo = alapido + (erosseg - 3) * 5; 
                if (napiIdo < 0) napiIdo = 0;
                osszIdo += napiIdo;
            }
    
            double osszKaloria = testsuly * osszIdo * kaloriaSz;
    
    
            Console.WriteLine("\n----- Eredmény -----");
            Console.WriteLine($"Név: {nev}");
            Console.WriteLine($"Cél: {(cel == 1 ? "Állóképesség" : cel == 2 ? "Izomtömeg" : "Fogyás")}");
            Console.WriteLine($"Edzés típusa: {tipus}");
            Console.WriteLine($"Heti összes edzésidő: {osszIdo} perc");
            Console.WriteLine($"Becsült elégetett kalória: {Math.Round(osszKaloria, 2)} kcal");
    

        }
    }
}
