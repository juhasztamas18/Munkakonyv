using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando
{
    class Munkas
    {
        string nev;
        string telefonszam;
        int napok;
        int ber;

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

        public string Telefonszam
        {
            get
            {
                return telefonszam;
            }

            set
            {
                telefonszam = value;
            }
        }

        public int Napok
        {
            get
            {
                return napok;
            }

            set
            {
                napok = value;
            }
        }

        public int Ber
        {
            get
            {
                return ber;
            }

            set
            {
                ber = value;
            }
        }

        public Munkas(string nev, string telefonszam, int napok, int ber)
        {
            this.Nev = nev;
            this.Telefonszam = telefonszam;
            this.Napok = napok;
            this.Ber = ber;
        }
    }
}
