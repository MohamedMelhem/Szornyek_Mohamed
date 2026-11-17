using System;
using System.Collections.Generic;
using System.Text;

namespace Szornyek_Mohamed
{
    internal class Szorny
    {
        private int id;
        private string nev;
        private int veszelyessegSzint;
        private string elohely;
        private string foGyengeseg;
        private string leggyakoribbZsakmany;
        private bool veszelyesE;

        public Szorny(int id, string nev, int veszelyessegSzint, string elohely, string foGyengeseg, string leggyakoribbZsakmany, bool veszelyesE)
        {
            this.id = id;
            this.nev = nev;
            this.veszelyessegSzint = veszelyessegSzint;
            this.elohely = elohely;
            this.foGyengeseg = foGyengeseg;
            this.leggyakoribbZsakmany = leggyakoribbZsakmany;
            this.veszelyesE = veszelyesE;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int VeszelyessegSzint { get => veszelyessegSzint; set => veszelyessegSzint = value; }
        public string Elohely { get => elohely; set => elohely = value; }
        public string FoGyengeseg { get => foGyengeseg; set => foGyengeseg = value; }
        public string LeggyakoribbZsakmany { get => leggyakoribbZsakmany; set => leggyakoribbZsakmany = value; }
        public bool VeszelyesE { get => veszelyesE; set => veszelyesE = value; }
    }
}
