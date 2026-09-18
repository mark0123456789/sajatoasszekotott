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
        private string postairoda_nev;
        private List<csomagok> csomag;
        public postairoda(string postairoda_nev, List<csomagok> csomag)
        { 
            this.csomag = csomag;
            this.postairoda_nev = postairoda_nev;
        }
        public postairoda( string postairoda_nev)
        {
            this.csomag = new List<csomagok>();
            this.postairoda_nev = postairoda_nev;
        }
        public bool csomag_feladas(csomagok Csomag)
        {   
                csomag.Add(Csomag);
                return true;
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
