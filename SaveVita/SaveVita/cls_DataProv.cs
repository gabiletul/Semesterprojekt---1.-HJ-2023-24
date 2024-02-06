using MySql.Data.MySqlClient;
using SaveVita;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveVita
{
    internal class cls_DataProv
    {
        const string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=savevita_db;";

        //Einfügen
        public static void InsertData_U(cls_User User)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("INSERT INTO `tbl_userdaten`(`Vorname`, `Nachname`, `Geschlecht`, `EMail`, `Geburtsdatum`, `age`, `Registrierungsdatum`) VALUES (@vorname,@nachname,@geschlecht,@email,@geburtsdatum,@age,@regdatum)");//('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", User.Vorname, User.Nachname, User.Geschlecht, User.Email, User.Gebdat, User.Alter, User.Registrierungsdatum);

            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);
            commandDatabase.Parameters.Add("@vorname", MySqlDbType.String).Value = User.Vorname;
            commandDatabase.Parameters.Add("@nachname", MySqlDbType.String).Value = User.Nachname;
            commandDatabase.Parameters.Add("@geschlecht", MySqlDbType.String).Value = User.Geschlecht;
            commandDatabase.Parameters.Add("@email", MySqlDbType.String).Value = User.Email;
            commandDatabase.Parameters.Add("@geburtsdatum", MySqlDbType.DateTime).Value = User.Gebdat.Date;
            commandDatabase.Parameters.Add("@age", MySqlDbType.Int64).Value = User.Alter;
            commandDatabase.Parameters.Add("@regdatum", MySqlDbType.DateTime).Value = User.Registrierungsdatum.Date;
            commandDatabase.Parameters.Add("@id", MySqlDbType.Int32).Value = User.ID;


            commandDatabase.CommandTimeout = 500;

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
        public static void Select_ID(cls_User User)
        {

            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("SELECT `id` FROM `tbl_userdaten` WHERE Vorname = @vorname AND Nachname = @nachname AND EMail = @email");

            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);
            commandDatabase.Parameters.Add("@vorname", MySqlDbType.String).Value = User.Vorname;
            commandDatabase.Parameters.Add("@nachname", MySqlDbType.String).Value = User.Nachname;
            commandDatabase.Parameters.Add("@email", MySqlDbType.String).Value = User.Email;

            commandDatabase.CommandTimeout = 30;

            try
            {
                dbConn.Open(); //Verbindung DB

                
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    User.ID = reader.GetInt32(0);
                }

                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung!");
            }
        }
        public static void Select_U(cls_User User)
        {

            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("SELECT `Vorname`, `Nachname`, `Geschlecht`, `EMail`, `Geburtsdatum`, `age`, `Registrierungsdatum` FROM `tbl_userdaten` WHERE id = @id");
            
            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);
            
            commandDatabase.Parameters.Add("@id", MySqlDbType.Int32).Value = User.ID;

            commandDatabase.CommandTimeout = 30;

            try
            {
                dbConn.Open(); //Verbindung DB


                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    User.Vorname = reader.GetString(0);
                    User.Nachname = reader.GetString(1);
                    User.Geschlecht = reader.GetString(2);
                    User.Email = reader.GetString(3);
                    User.Gebdat = reader.GetDateTime(4);
                    User.Alter = reader.GetInt32(5);
                    User.Registrierungsdatum = reader.GetDateTime(6);
                }

                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung!");
            }
        }
        public static void Analyze(cls_naehrwerte naehrwerte)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("SELECT kj, kcal, fett, kohlenhydrate, ballasstoffe, eiweiß, salz FROM tbl_ernaerungswerte WHERE id=@id");

            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);

            commandDatabase.CommandTimeout = 30;
        }
    }
}
