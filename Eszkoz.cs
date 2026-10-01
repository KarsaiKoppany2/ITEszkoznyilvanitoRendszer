using System;
using System.Collections.Generic;
using System.Text;

namespace ITEszkoznyilvanitoRendszer
{
    internal class Eszkoz
    {
        private int beszerzesiAr;
        private int raktarKeszlet;
        private static int osszesLetezoEszkoz = 0;
        public string Cikkszam;
        public string Nev;
        public int BeszerzesiAr 
        {
            get
            {
                return beszerzesiAr;
            }
            set
            {
                if (value < 0) beszerzesiAr = 0;
            }
        }
        public int RaktarKeszlet 
        {
            get
            {
                return raktarKeszlet;
            }
            set
            {
                if (value < 0) raktarKeszlet = 0;
            }
        }
        public static int OsszesLetezoEszkoz { get { return osszesLetezoEszkoz; } }
        public Eszkoz(string cikkszam, string nev, int beszerzesiAr) 
        {
            Cikkszam = cikkszam;
            Nev = nev;
            BeszerzesiAr = beszerzesiAr;
            RaktarKeszlet = 0;
        }
        public Eszkoz(string cikkszam, string nev, int beszerzesiAr, int raktarKeszlet)
        {
            Cikkszam = cikkszam;
            Nev = nev;
            BeszerzesiAr = beszerzesiAr;
            RaktarKeszlet = raktarKeszlet;
            osszesLetezoEszkoz++;
        }
        public override string ToString()
        {
            return $"{Cikkszam} {Nev} | Beszerzési Ár: {BeszerzesiAr} Ft | Készlet: {RaktarKeszlet} db";
        }
        public bool Eladas(int db) 
        {
            if (db >= RaktarKeszlet) 
            {
                RaktarKeszlet = RaktarKeszlet - db;
                return true;
            }
            else { return false; }
        }
    }
}
