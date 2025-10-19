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
        }
    }
}
