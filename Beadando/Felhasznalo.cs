using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Felhasznalo
    {
        string nev;
        string jelszo;

        public string Nev
        {
            get
            {
                return nev;
            }

            set
            {
                nev = value;
            }
        }

        public string Jelszo
        {
            get
            {
                return jelszo;
            }

            set
            {
                jelszo = value;
            }
        }

        public Felhasznalo(string nev, string jelszo)
        {
            this.Nev = nev;
            this.Jelszo = jelszo;
        }
    }
}
