using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektHet
{
    internal class Tanulok
    {
        public string Név { get; set; }
        public string Első { get; set; }
        public string Második { get; set; }
        public string Harmadik { get; set; }
        public string Negyedik { get; set; }
        public string Ötödik { get; set; }
        public string Hatodik { get; set; }
        public string Hetedik { get; set; }
        public string Nyolcadik { get; set; }

        public Tanulok(string sor)
        {
            string[] reszek = sor.Split(';');
            Név = reszek[0];
            Első = reszek[1];
            Második = reszek[2];
            Harmadik = reszek[3];
            Negyedik = reszek[4];
            Ötödik = reszek[5];
            Hatodik = reszek[6];
            Hetedik = reszek[7];
            Nyolcadik = reszek[8];
        }
    }
}
