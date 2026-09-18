using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatoasszekotott
{
    internal class csomagok

    {
        private static string[] kondiciok = { "N", "T", "TS", "TM", "TWU" };//nincs,törékeny,túlsúlyos,túlméreteterzett,this side up
        private string lakcím;
        private double súly;
        private double méret;
        private string cimzett;
        private string felado;
        private List<string> kondicio;
        public csomagok(string lakcím, double súly, double méret, string cimzett, string felado, string kondicio)
        {
            this.lakcím = lakcím;
            this.súly = súly;
            this.méret = méret;
            this.cimzett = cimzett;
            this.felado = felado;
            this.kondicio = new List<string>();
            string[] kapottKondiciok = kondicio.ToUpper().Split(',');
            foreach (string k in kapottKondiciok)
            {
                string feltétel = k.Trim();
                if (kondiciok.Contains(feltétel))
                {
                    this.kondicio.Add(feltétel);
                }
            }
        }

        public override string ToString()
        {
            string kondiciok_ki_irva = "";

            foreach (string k in kondicio)
            {
                kondiciok_ki_irva += " " + k;
            }

            return $"{felado}-tól {cimzett}-nek {lakcím}-címre. " +$"{méret} cm3 {súly} kg. " + $"{kondiciok_ki_irva} kondíciókkal";
        }
    }
}
