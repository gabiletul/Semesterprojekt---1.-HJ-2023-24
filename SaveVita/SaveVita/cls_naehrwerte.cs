using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveVita
{
    internal class cls_naehrwerte
    {
        int m_id;
        string m_produktbezeichnung;
        double m_kj;
        double m_kcal;
        double m_fett;
        double m_kohlenhydrate;
        double m_ballaststoffe;
        double m_eiweiß;
        double m_salz;
        public double Kj { get => m_kj; set => m_kj = value; }
        public double Kcal { get => m_kcal; set => m_kcal = value; }
        public double Fett { get => m_fett; set => m_fett = value; }
        public double Kohlenhydrate { get => m_kohlenhydrate; set => m_kohlenhydrate = value; }
        public double Ballaststoffe { get => m_ballaststoffe; set => m_ballaststoffe = value; }
        public double Eiweiß { get => m_eiweiß; set => m_eiweiß = value; }
        public double Salz { get => m_salz; set => m_salz = value; }
        public int Id { get => m_id; set => m_id = value; }
        public string Produktbezeichnung { get => m_produktbezeichnung; set => m_produktbezeichnung = value; }

        //Konstruktor
        public cls_naehrwerte(string produktbezeichnung, double kj, double kcal, double fett, double kohlenhydrate, double ballasstoffe, double eiweiß, double salz)
        {
            m_produktbezeichnung = produktbezeichnung;
            m_kj = kj;
            m_kcal = kcal;
            m_fett = fett;
            m_kohlenhydrate = kohlenhydrate;
            m_ballaststoffe = ballasstoffe;
            m_eiweiß = eiweiß;
            m_salz = salz;
        }

        public cls_naehrwerte(int id)
        {
            m_id = id;
        }


        public string Anzeige
        {
            get
            {
                return string.Format("{0}: {1} kj/ {2} kcal/ {3} g fat/ {4} g carbohydrates/ {5} g fibre/ {6} g proteins/ {7} g salt", m_produktbezeichnung, m_kj, m_kcal, m_fett, m_kohlenhydrate, m_ballaststoffe, m_eiweiß, m_salz);
            }
        }
    }
}
