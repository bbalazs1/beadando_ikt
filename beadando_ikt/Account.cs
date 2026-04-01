using System;
using System.Collections.Generic;
using System.IO;

namespace BankiApp
{
    public class Account
    {
        private string szamlaszam;
        private string nev;
        private decimal egyenleg;
        private decimal hitelkeret;
        private decimal nyitoEgyenleg;
        private List<string> naplo;

        public string Szamlaszam { get { return szamlaszam; } }
        public string Nev { get { return nev; } }
        public decimal Egyenleg { get { return egyenleg; } }

        public Account(string szamlaszam, string nev, decimal egyenleg)
        {
            this.szamlaszam = szamlaszam;
            this.nev = nev;
            this.egyenleg = egyenleg;
            this.nyitoEgyenleg = egyenleg;
            this.hitelkeret = 0;
            this.naplo = new List<string>();
            Naplozas("Számla létrehozva");
        }
        
        public void Deposit(decimal osszeg)
        {
            if (osszeg > 0)
            {
                egyenleg += osszeg;
                Naplozas("Befizetés: +" + osszeg);
            }
        }

        public bool Withdraw(decimal osszeg)
        {
            if (osszeg > 0 && (egyenleg + hitelkeret) >= osszeg)
            {
                egyenleg -= osszeg;
                Naplozas("Kifizetés: -" + osszeg);
                return true;
            }
            return false;
        }
           public bool Utalas(Account cel, decimal osszeg)
        {
            if (this.Withdraw(osszeg))
            {
                cel.Deposit(osszeg);
                return true;
            }
            return false;
        }



     
