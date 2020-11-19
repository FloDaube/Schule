using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEAL_FahrzeugVermietung.Common
{
    public class Reservierung
    {
        private int id;
        private DateTime beginn;
        private DateTime ende;
        private string zweck;
        private int fahrzeug_id;

        public int Id { get => id; set => id = value; }
        public DateTime Beginn { get => beginn; set => beginn = value; }
        public DateTime Ende { get => ende; set => ende = value; }
        public string Zweck { get => zweck; set => zweck = value; }
        public int Fahrzeug_id { get => fahrzeug_id; set => fahrzeug_id = value; }

        public Reservierung()
        {
            Id = -1;
            Beginn = DateTime.Now;
            Ende = DateTime.Now;
            Zweck = "";
            Fahrzeug_id = 0;
        }
    }
}
