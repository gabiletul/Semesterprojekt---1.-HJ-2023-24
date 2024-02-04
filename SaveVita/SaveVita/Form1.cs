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
using static System.Windows.Forms.LinkLabel;
namespace SaveVita
{
    public partial class frm_main : Form
    {
        
        public frm_main()
        {

            InitializeComponent();
        }
        string line;
        int localid;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<cls_naehrwerte> nährwerteliste = new List<cls_naehrwerte>();
            List<cls_User> userliste = new List<cls_User>();
            DateTime gebdat = DateTime.Now;
            cls_User User = new cls_User("Max", "Mustermann", "m", "max@muster.gmx.de", gebdat, Convert.ToInt32(DateTime.Now - gebdat), DateTime.Now);
            DataProv.InsertData_U(User);
            //cls_DataProv.InsertData_N(nährwerteliste);
            
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("localid.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                //while (line != null)
                {
                    //write the line to console window
                    localid = Convert.ToInt32(line);
                    
                    
                }
                //close the file
                sr.Close();
                MessageBox.Show(Convert.ToString(localid));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
            
            



        }
        int time = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
           

                pictureBox1.Image = Properties.Resources.SaveVita_Logo;
            timer2.Start();
             timer1.Stop();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            btn_anywhere.Enabled = true;
            btn_anywhere.Show();
            timer2.Stop();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }

        private void btn_anywhere_Click(object sender, EventArgs e)
        {
            //if ()Account bereits existiert)
            if(line != null)
            {
                btn_mahlzeit.Show();
                btn_profil.Show();
                btn_anywhere.Hide();
                pbx_logo.Show();
            }
            else if(line == null)
            {
                frm_register Register = new frm_register();
                Register.ShowDialog();
                if(Register.DialogResult == DialogResult.OK)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_mahlzeit.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_profile.Hide();
            gbx_new.Hide();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            btn_mahlzeit.Visible=false;
            btn_profil.Visible=false;
            btn_menu.Show();
            pbx_logo.Visible=false;
            gbx_profile.Visible=true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_mahlzeit_Click(object sender, EventArgs e)
        {
            btn_mahlzeit.Visible = false;
            btn_profil.Visible = false;
            pbx_logo.Visible = false;
            gbx_new.Show();
        }

        private void gbx_new_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num_kj_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_foodt_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_carbonhydrate_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_mahlzeit.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_new.Hide();
        }

        private void btn_confirmfood_Click(object sender, EventArgs e)
        {
            btn_mahlzeit.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_new.Hide();

            string decriptionname = txt_description.Text;
            double kj = Convert.ToDouble(num_kj.Value);
            double carbohydrates = Convert.ToDouble(num_carbohydrates.Value);
            

        }
    }
}
