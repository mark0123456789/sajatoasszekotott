using sajatoasszekotott;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatoasszekotott
{
    internal class postairoda
    {
        private int csomag_szam;
        private string postairoda_nev;
        private List<csomagok> csomag;
        public postairoda(int csomag_szam, string postairoda_nev, List<csomagok> csomag)
        { 
            this.csomag = csomag;
            this.csomag_szam = csomag_szam;
            this.postairoda_nev = postairoda_nev;
        }
        public postairoda(int csomag_szam, string postairoda_nev)
        {
            this.csomag = new List<csomagok>();
            this.csomag_szam = csomag_szam;
            this.postairoda_nev = postairoda_nev;
        }
        public bool csomag_feladas(csomagok Csomag)
        {
            if (csomag.Count < csomag_szam)
            {
                csomag.Add(Csomag);
                return true;
            }
            return false;
        }
        public bool csomagatvetel(csomagok Csomag) 
        {
            if (csomag.Contains(Csomag))
            { csomag.Remove(Csomag);
                return true;
            }
            return false;
        }
    }
}
