using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat05
{
    class Kemia
    {
        string ev;
        string nev;
        string vegyjel;
        int rendszam;
        string felfedNev;

        public Kemia(string ev, string nev, string vegyjel, int rendszam, string felfedNev)
        {
            this.ev = ev;
            this.nev = nev;
            this.vegyjel = vegyjel;
            this.rendszam = rendszam;
            this.felfedNev = felfedNev;
        }

        public string Ev { get => ev;}
        public string Nev { get => nev;}
        public string Vegyjel { get => vegyjel; }
        public int Rendszam { get => rendszam;}
        public string FelfedNev { get => felfedNev; }
    }
}
