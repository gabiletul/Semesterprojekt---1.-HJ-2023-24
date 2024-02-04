using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveVita
{
    public partial class frm_register : Form
    {
        public frm_register()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_gebdat_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string geschlecht = "m";
            if (rb_f.Checked)
            {
                geschlecht = "f";
            }
            int age = Convert.ToInt32(DateTime.Now.Year - dtp_gebdat.Value.Year);
            cls_User User = new cls_User(txt_vorname.Text, txt_nachname.Text, geschlecht, txt_email.Text, dtp_gebdat.Value, age, DateTime.Now);
            cls_DataProv.InsertData_U(User);

            try
            {
                //Open the File
                StreamWriter sw = new StreamWriter("localid.txt");

                //Write out the numbers 1 to 10 on the same line.
                cls_DataProv.Select_ID(User);
                if (User.ID != null) { 
                    sw.Write(User.ID);
                

                //close the file
                sw.Close();
                MessageBox.Show(Convert.ToString(User.ID));
                     }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_m_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_nachname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_vorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbx_login.Show();
            gbx_register.Hide();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            gbx_login.Hide();
            gbx_register.Show();
        }

        private void gbx_register_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
