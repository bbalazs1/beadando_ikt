using System;
using System.Collections.Generic;
using System.IO;

namespace BankiApp
{
    class Program
    {
        static List<Account> szamlak = new List<Account>();
        static void Main(string[] args)
        {
            AdatokBetoltese();
            string valasztas = "";

            while (valasztas != "0")
            {
                Console.Clear();
                Console.WriteLine("=== EGYSZERŰ BANKI RENDSZER ===");
                Console.WriteLine("1. Befizetés");
                Console.WriteLine("2. Kifizetés");
                Console.WriteLine("3. Utalás két számla között");
                Console.WriteLine("4. Hitelkeret módosítása");
                Console.WriteLine("5. Napló mentése (számlánként)");
                Console.WriteLine("6. Összes egyenleg megtekintése");
                Console.WriteLine("0. Kilépés");
                Console.Write("\nVálasszon menüpontot: ");
                valasztas = Console.ReadLine();

                if (valasztas == "1") BefizetesMenu();
                else if (valasztas == "2") KifizetesMenu();
                else if (valasztas == "3") UtalasMenu();
                else if (valasztas == "4") HitelkeretMenu();
                else if (valasztas == "5") MentesMenu();
                else if (valasztas == "6") ListazasMenu();
            }
        }

   

        
