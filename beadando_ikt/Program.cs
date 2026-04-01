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
             static void AdatokBetoltese()
        {
            if (File.Exists("szamlak.txt"))
            {
                StreamReader sr = new StreamReader("szamlak.txt");
                while (!sr.EndOfStream)
                {
                    string[] sor = sr.ReadLine().Split(';');
                    szamlak.Add(new Account(sor[0], sor[1], decimal.Parse(sor[2])));
                }
                sr.Close();
            }
        }
        static void ListazasMenu()
        {
            Console.Clear();
            Console.WriteLine("Sorszám\tNév\t\tSzámlaszám\tEgyenleg");
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 0; i < szamlak.Count; i++)
            {
                Console.WriteLine(i + ".\t" + szamlak[i].Nev + "\t" + szamlak[i].Szamlaszam + "\t" + szamlak[i].Egyenleg + " Ft");
            }
            Console.WriteLine("\nNyomjon Entert a visszalépéshez!");
            Console.ReadLine();
        }



   

        
