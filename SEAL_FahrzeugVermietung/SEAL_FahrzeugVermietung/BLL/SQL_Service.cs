using SEAL_FahrzeugVermietung.Common;
using SEAL_FahrzeugVermietung.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SEAL_FahrzeugVermietung.BLL
{
    public class SQL_Service
    {
        private string server;
        private string user;
        private string password;
        private string database;

        public string Server { get => server; set => server = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Database { get => database; set => database = value; }

        SQL_Command _Command = new SQL_Command();

        public SQL_Service()
        {
            Server = "";
            User = "";
            Password = "";
        }

        public string getConnectioString()
        {
            return $"Data Source = '{server}'; Initial Catalog = '{Database}'; User ID = '{User}'; Password = '{Password}';";
        }

        public List<Fahrzeug> GetFahrzeugListe()
        {
            MySqlConnection con = new MySqlConnection(getConnectioString());
            List<Fahrzeug> res = new List<Fahrzeug>();
            try
            {                
                con.Open();

                MySqlCommand command = new MySqlCommand(_Command.GetFahrzeuge_SQL(),con);

                MySqlDataReader reader = command.ExecuteReader();

                res = _Command.Read_Fahrzeuge(reader);

                con.Close();
            }
            catch(Exception ex)
            {
                con.Close();
            }
            

            return res;
        }

        public List<View_Resevirung> GetView_ResevirungsListe()
        {
            List<View_Resevirung> res = new List<View_Resevirung>();
            MySqlConnection con = new MySqlConnection(getConnectioString());
            try
            {
                con.Open();

                MySqlCommand command = new MySqlCommand(_Command.GetView_Resevirungs_SQL(), con);

                MySqlDataReader reader = command.ExecuteReader();

                res = _Command.Read_View_Resevirungen(reader);

                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
            }
            return res;
        }
    }
}
