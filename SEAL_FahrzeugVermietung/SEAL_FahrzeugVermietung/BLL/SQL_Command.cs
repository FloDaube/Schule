using MySql.Data.MySqlClient;
using SEAL_FahrzeugVermietung.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEAL_FahrzeugVermietung.BLL
{
    public class SQL_Command
    {
        public SQL_Command()
        {

        }

        /// <summary>
        /// Gibt ein SQL Select befhel für eine Liste von View_Reservirungen
        /// </summary>
        /// <returns></returns>
        public string GetView_Resevirungs_SQL()
        {
            string res = "SELECT r.id, r.Zweck, r.Beginn, r.Ende, f.Hersteller, f.Modell, f.kennzeichen FROM schule.reservierungen as r JOIN schule.fahrzeuge as f on r.Fahrzeug_id = f.id";

            return res;
        }

        public string GetFahrzeuge_SQL()
        {
            return "SELECT * FROM fahrzeuge;";
        }

        public List<Fahrzeug> Read_Fahrzeuge(MySqlDataReader reader)
        {
            List<Fahrzeug> res = new List<Fahrzeug>();

            while (reader.Read())
            {
                Fahrzeug f = new Fahrzeug();

                IDataRecord record = reader;

                f.Id = Convert.ToInt32(String.Format("{0}", record[0]));
                f.Kennzeichen = String.Format("{0}", record[1]);
                f.Hersteller = String.Format("{0}", record[2]);
                f.Modell = String.Format("{0}", record[3]);
                f.Kraftstoff = String.Format("{0}", record[4]);
                f.Verbrauch = Convert.ToDouble(String.Format("{0}", record[5]));
                string[] date = String.Format("{0}", record[6]).Split('.');
                string[] d = date[2].Split(' ');
                date[2] = d[0];
                f.AnschafungsDatum = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])); date = String.Format("{0}", record[4]).Split('.');
                f.AnschafungsKosten = Convert.ToDouble(String.Format("{0}", record[7]));

                res.Add(f);
            }

            return res;
        }

        public List<View_Resevirung> Read_View_Resevirungen(MySqlDataReader reader)
        {
            List<View_Resevirung> res = new List<View_Resevirung>();

            while (reader.Read())
            {
                try
                {
                    View_Resevirung vr = new View_Resevirung();
                    IDataRecord record = reader;
                    vr.Id = Convert.ToInt32(String.Format("{0}", record[0]));
                    vr.Zweck = String.Format("{0}", record[1]);
                    string[] date = String.Format("{0}", record[2]).Split('.');
                    string[] d = date[2].Split(' ');
                    date[2] = d[0];
                    vr.Beginn = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])); date = String.Format("{0}", record[4]).Split('.');
                    date = String.Format("{0}", record[3]).Split('.');
                    d = date[2].Split(' ');
                    date[2] = d[0];
                    vr.Ende = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0])); date = String.Format("{0}", record[4]).Split('.');
                    vr.Hersteller = String.Format("{0}", record[4]);
                    vr.Modell = String.Format("{0}", record[5]);
                    vr.Kennzeichen = String.Format("{0}", record[6]);
                    res.Add(vr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler in Methode : Read_View_Resevirungen() Datei SQL_View_Reservirung.cs");
                    return new List<View_Resevirung>();
                }

            }
            return res;
        }
    }
}
