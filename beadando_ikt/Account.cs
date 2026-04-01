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
