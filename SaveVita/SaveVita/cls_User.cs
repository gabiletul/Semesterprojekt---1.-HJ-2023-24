using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveVita
{
    internal class cls_User
    {
        int m_id;
        string m_vorname;
        string m_nachname;
        string m_geschlecht;
        string m_email;
        DateTime m_gebdat;
        int m_alter;
        DateTime m_registrierungsdatum;
        decimal m_weight;
        int m_height;

        public int ID { get => m_id; set => m_id = value; }
        public string Vorname { get => m_vorname; set => m_vorname = value; }
        public string Nachname { get => m_nachname; set => m_nachname = value; }
        public string Geschlecht { get => m_geschlecht; set => m_geschlecht = value; }
        public string Email { get => m_email; set => m_email = value; }
        public DateTime Gebdat { get => m_gebdat; set => m_gebdat = value; }
        public int Alter { get => m_alter; set => m_alter = value; }
        public DateTime Registrierungsdatum { get => m_registrierungsdatum; set => m_registrierungsdatum = value; }
        public decimal Weight { get => m_weight; set => m_weight = value; }
        public int Height { get => m_height; set => m_height = value; }

        //Konstruktoren
        //public cls_User(int id, string vorname, string nachname, string geschlecht, string email, DateTime gebdat, int alter, DateTime registrierungsdatum)
        //{
        //    m_id = id;
        //    m_vorname = vorname;
        //    m_nachname = nachname;
        //    m_geschlecht = geschlecht;
        //    m_email = email;
        //    m_gebdat = gebdat;
        //    m_alter = alter;
        //    m_registrierungsdatum = registrierungsdatum;
        //}
        public cls_User(string vorname, string nachname, string geschlecht, string email, DateTime gebdat, int alter, DateTime registrierungsdatum, decimal weight, int height)
        {
            m_vorname = vorname;
            m_nachname = nachname;
            m_geschlecht = geschlecht;
            m_email = email;
            m_gebdat = gebdat;
            m_alter = alter;
            m_registrierungsdatum = registrierungsdatum;
            Weight = weight;
            Height = height;
        }
        public cls_User(int id)
        {
            m_id = id;
        }
        public cls_User(string email)
        {
           m_email=email;
        }
    }
}
