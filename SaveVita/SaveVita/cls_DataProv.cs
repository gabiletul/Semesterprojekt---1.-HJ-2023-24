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

            string query = string.Format("INSERT INTO `tbl_userdaten`(`Vorname`, `Nachname`, `Geschlecht`, `EMail`, `Geburtsdatum`, `age`, `Registrierungsdatum`, `Gewicht`, `Height`) VALUES (@vorname,@nachname,@geschlecht,@email,@geburtsdatum,@age,@regdatum,@weight,@height)");//('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", User.Vorname, User.Nachname, User.Geschlecht, User.Email, User.Gebdat, User.Alter, User.Registrierungsdatum);

            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);
            commandDatabase.Parameters.Add("@vorname", MySqlDbType.String).Value = User.Vorname;
            commandDatabase.Parameters.Add("@nachname", MySqlDbType.String).Value = User.Nachname;
            commandDatabase.Parameters.Add("@geschlecht", MySqlDbType.String).Value = User.Geschlecht;
            commandDatabase.Parameters.Add("@email", MySqlDbType.String).Value = User.Email;
            commandDatabase.Parameters.Add("@geburtsdatum", MySqlDbType.DateTime).Value = User.Gebdat.Date;
            commandDatabase.Parameters.Add("@age", MySqlDbType.Int64).Value = User.Alter;
            commandDatabase.Parameters.Add("@regdatum", MySqlDbType.DateTime).Value = User.Registrierungsdatum.Date;
            commandDatabase.Parameters.Add("@id", MySqlDbType.Int32).Value = User.ID;
            commandDatabase.Parameters.Add("@weight", MySqlDbType.Decimal).Value = User.Weight;
            commandDatabase.Parameters.Add("@height", MySqlDbType.Int64).Value = User.Height;



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
        public static void InsertData_N(cls_naehrwerte Nährwerte, int zwischenid)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("INSERT INTO `tbl_naehrwerte` (`uid`, `produktbezeichnung`, `kj`, `kcal`, `fett`, `kohlenhydrate`, `ballasstoffe`, `eiweiß`, `salz`) VALUES (@uid, @produktbezeichnung, @kj, @kcal, @fett, @kohlenhydrate, @ballaststoffe, @eiweiß, @salz)");//, User.ID, Nährwerte.Produktbezeichnung, Nährwerte.Kj, Nährwerte.Kcal, Nährwerte.Fett, Nährwerte.Kohlenhydrate, Nährwerte.Ballaststoffe, Nährwerte.Eiweiß, Nährwerte.Salz);
            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);
            commandDatabase.Parameters.Add("@uid", MySqlDbType.Int32).Value = zwischenid;
            commandDatabase.Parameters.Add("@produktbezeichnung", MySqlDbType.VarChar).Value = Nährwerte.Produktbezeichnung;
            commandDatabase.Parameters.Add("@kj", MySqlDbType.Int32).Value = Nährwerte.Kj;
            commandDatabase.Parameters.Add("@kcal", MySqlDbType.Int32).Value = Nährwerte.Kcal;
            commandDatabase.Parameters.Add("@fett", MySqlDbType.Int32).Value = Nährwerte.Fett;
            commandDatabase.Parameters.Add("@kohlenhydrate", MySqlDbType.Int32).Value = Nährwerte.Kohlenhydrate;
            commandDatabase.Parameters.Add("@ballaststoffe", MySqlDbType.Int32).Value = Nährwerte.Ballaststoffe;
            commandDatabase.Parameters.Add("@eiweiß", MySqlDbType.Int32).Value = Nährwerte.Eiweiß;
            commandDatabase.Parameters.Add("@salz", MySqlDbType.Int32).Value = Nährwerte.Salz;


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

            string query = string.Format("SELECT `id` FROM `tbl_userdaten` WHERE EMail = @email");

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

        //////////public static void NewMeal(cls_naehrwerte naehrwerte)
        //////////{
        //////////    MySqlConnection dbConn = new MySqlConnection(connectionString);

        //////////    string query = string.Format("INSERT INTO tbl_naehrwerte (kj, kcal, fett, kohlenhydrate, ballasstoffe, eiweiß, salz)");

        //////////    MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);

        //////////    commandDatabase.CommandTimeout = 30;
        //////////}



        public static void LoadData(List<cls_naehrwerte> nährwerteliste0, int zwischenid)
        {
            MySqlConnection dbConn = new MySqlConnection(connectionString);

            string query = string.Format("SELECT `produktbezeichnung`, `kj`, `kcal`, `fett`, `kohlenhydrate`, `ballasstoffe`, `eiweiß`, `salz` FROM `tbl_naehrwerte` WHERE uid=@id");

            MySqlCommand commandDatabase = new MySqlCommand(query, dbConn);

            commandDatabase.Parameters.Add("@id", MySqlDbType.Int32).Value = zwischenid;

            commandDatabase.CommandTimeout = 30;

            try
            {
                dbConn.Open(); //Verbindung DB

                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    cls_naehrwerte NW = new cls_naehrwerte(Convert.ToString(reader[0]), Convert.ToInt32(reader[1]), Convert.ToInt32(reader[2]), Convert.ToInt32(reader[3]), Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]));
                    nährwerteliste0.Add(NW);
                }
                dbConn.Close();
            }
            catch
            {
                MessageBox.Show("Fehler bei der Datenbankverbindung!");
            }

        }
    }
}
