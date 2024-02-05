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

        public int ID { get => m_id; set => m_id = value; }
        public string Vorname { get => m_vorname; set => m_vorname = value; }
        public string Nachname { get => m_nachname; set => m_nachname = value; }
        public string Geschlecht { get => m_geschlecht; set => m_geschlecht = value; }
        public string Email { get => m_email; set => m_email = value; }
        public DateTime Gebdat { get => m_gebdat; set => m_gebdat = value; }
        public int Alter { get => m_alter; set => m_alter = value; }
        public DateTime Registrierungsdatum { get => m_registrierungsdatum; set => m_registrierungsdatum = value; }

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
        public cls_User(string vorname, string nachname, string geschlecht, string email, DateTime gebdat, int alter, DateTime registrierungsdatum)
        {
            m_vorname = vorname;
            m_nachname = nachname;
            m_geschlecht = geschlecht;
            m_email = email;
            m_gebdat = gebdat;
            m_alter = alter;
            m_registrierungsdatum = registrierungsdatum;
        }
        public cls_User(int id)
        {
            m_id = id;
        }
    }
}
