using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SaveVita
{
    internal class DataProv
    {
        const string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=savevita_db;";

        //Einfügen
        public static void InsertData_U(cls_User User)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("INSERT INTO tbl_userdaten (Vorname, Nachname, Geschlecht, E-Mail, Geburtsdatum, Alter, Registrierungsdatum) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", User.Vorname, User.Nachname, User.Geschlecht, User.Email, User.Gebdat, User.Alter, User.Registrierungsdatum);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);

            commandDatabase.CommandTimeout = 30;

            try
            {
                dbConn.Open(); //Verbindung DB

                commandDatabase.ExecuteNonQuery();

                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung!");
            }
        }
        public static void InsertData_N(cls_naehrwerte Nährwerte)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("INSERT INTO tbl_ernährungswerte (produktbezeichnung, kj, kcal, fett, kohlenhydrate, ballasstoffe, eiweiß, salz) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", Nährwerte.Produktbezeichnung, Nährwerte.Kj, Nährwerte.Kcal, Nährwerte.Fett, Nährwerte.Kohlenhydrate, Nährwerte.Ballaststoffe, Nährwerte.Eiweiß, Nährwerte.Salz);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);

            commandDatabase.CommandTimeout = 30;

            try
            {
                dbConn.Open(); //Verbindung DB

                commandDatabase.ExecuteNonQuery();

                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung!");
            }
        }

    }
}
