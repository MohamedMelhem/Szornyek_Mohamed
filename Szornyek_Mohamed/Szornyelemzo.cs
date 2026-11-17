using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Szornyek_Mohamed
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo(List<Szorny> szornyek)
        {
           this.szornyek = szornyek;
        }

        public int OsszesSzornySzama()
        {
            return szornyek.Count;
        }

        public IEnumerable<string> VeszelyesSzornyekNevei()
        {
            List<string> veszelyesSzornyek = new List<string>();
            foreach (var szorny in szornyek)
            {
                if (szorny.VeszelyesE)
                {
                    veszelyesSzornyek.Add(szorny.Nev);
                }
            }
            return veszelyesSzornyek;
        }
        public IEnumerable<string> EgyediElohelyek()
        {
            HashSet<string> egyediElohelyek = new HashSet<string>();
            foreach (var szorny in szornyek)
            {
                egyediElohelyek.Add(szorny.Elohely);
            }
            return egyediElohelyek;
        }
        public double AtlagosVeszelyessegSzint()
        {
            if (szornyek.Count == 0)
            {
                return 0;
            }
            int osszesVeszelyessegSzint = 0;
            foreach (var szorny in szornyek)
            {
                osszesVeszelyessegSzint += szorny.VeszelyessegSzint;
            }
            return (double)osszesVeszelyessegSzint / szornyek.Count;
        }

        public  IEnumerable<Szorny> LegveszelyesebbSzornyek()
        {
            int maxVeszelyessegSzint = 0;
            foreach (var szorny in szornyek)
            {
                if (szorny.VeszelyessegSzint > maxVeszelyessegSzint)
                {
                    maxVeszelyessegSzint = szorny.VeszelyessegSzint;
                }
            }
            List<Szorny> legveszelyesebbSzornyek = new List<Szorny>();
            foreach (var szorny in szornyek)
            {
                if (szorny.VeszelyessegSzint == maxVeszelyessegSzint)
                {
                    legveszelyesebbSzornyek.Add(szorny);
                }
            }
            return legveszelyesebbSzornyek;

            
        }
        public IEnumerable<Szorny> MocsariVeszelyesSzornyek()
        {
            List<Szorny> mocsariVeszelyesSzornyek = new List<Szorny>();
            foreach (var szorny in szornyek)
            {
                if (szorny.Elohely == "Fekete Mocsár" && szorny.VeszelyessegSzint > 5)
                {
                    mocsariVeszelyesSzornyek.Add(szorny);
                }
            }

            return mocsariVeszelyesSzornyek.OrderByDescending(s => s.VeszelyessegSzint);
        }

        public bool VanExtremTuzGyengeSzorny()
        {
            bool vanExtremTuzGyengeSzorny = false;
            foreach (var szorny in szornyek)
            {
                if (szorny.FoGyengeseg == "Tűz" && szorny.VeszelyessegSzint >= 9)
                {
                   vanExtremTuzGyengeSzorny = true;
                    
                }

            }
            return vanExtremTuzGyengeSzorny;
        }
    }
}
