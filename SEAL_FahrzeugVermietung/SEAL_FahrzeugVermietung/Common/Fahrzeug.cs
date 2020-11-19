using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAL_FahrzeugVermietung.Common
{
    public class Fahrzeug
    {
        private int id;
        private string kennzeichen;
        private string hersteller;
        private string modell;
        private string kraftstoff;
        private double verbrauch;
        private DateTime anschafungsDatum;
        private double anschafungsKosten;


        public int Id { get => id; set => id = value; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public string Hersteller { get => hersteller; set => hersteller = value; }
        public string Modell { get => modell; set => modell = value; }
        public string Kraftstoff { get => kraftstoff; set => kraftstoff = value; }
        public double Verbrauch { get => verbrauch; set => verbrauch = value; }
        public DateTime AnschafungsDatum { get => anschafungsDatum; set => anschafungsDatum = value; }
        public double AnschafungsKosten { get => anschafungsKosten; set => anschafungsKosten = value; }

        public Fahrzeug()
        {
            Id = -1;
            Kennzeichen = "";
            Hersteller = "";
            Modell = "";
            Kraftstoff = "";
            Verbrauch = 0;
            AnschafungsDatum = DateTime.Now;
            AnschafungsKosten = 0;
        }

    }
}
