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
            lbx_funktionier.DisplayMember = "Anzeige";
        }
        string line;
        int localid =0;
        List<cls_naehrwerte> nährwerteliste = new List<cls_naehrwerte>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<cls_User> userliste = new List<cls_User>();
            DateTime gebdat = DateTime.Now;
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
                    cls_User User = new cls_User(localid);
                    User.ID = localid;
                    if (line != null)
                    {
                        

                        
                        cls_DataProv.Select_U(User);

                        int alter = User.Alter;
                        lbl_age.Text = Convert.ToString(alter);
                        lbl_name.Text = Convert.ToString(User.Vorname + " " + User.Nachname);
                        lbl_height.Text = Convert.ToString(User.Height);
                        lbl_weight.Text = Convert.ToString(User.Weight);
                        if (User.Geschlecht == "f")
                        {
                            pbx_pp.Image = Properties.Resources.umriss_frau;
                        }
                            

                    }
                }
               
                sr.Close();

                StreamReader tr = new StreamReader("tempid.txt");
                
                string tline = tr.ReadLine();
                
                {
                    
                    if (tline == null)
                    {
                        File.WriteAllText("localid.txt", String.Empty);

                    }
                }
                
                tr.Close();
                
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
            try
            {
                
            
            //StreamReader sr = new StreamReader("localid.txt");
            //Read the first line of text
            //line = sr.ReadLine();
                //if ()Account bereits existiert)
                if (line != null)
                {
                    btn_showmeals.Show();
                    btn_profil.Show();
                    btn_anywhere.Hide();
                    pbx_logo.Show();
                    btn_showmeals.Show();

                    //cls_User User = new cls_User(localid);
                    //cls_DataProv.Select_U(User);

                    string vorname;
                    string nachname;
                    string gender;
                    string email;
                    DateTime gebdat;
                    int age;
                    DateTime regdat;


                }
                else if (line == null)
                {
                    frm_register register = new frm_register();
                    register.ShowDialog();

                    if (register.DialogResult == DialogResult.OK)
                    {
                        Application.Restart();
                        } 
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_showmeals.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_profile.Hide();
            gbx_new.Hide();
            gbx_meallist.Hide();
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            btn_showmeals.Visible=false;
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
            btn_showmeals.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_new.Hide();
        }

        private void btn_confirmfood_Click(object sender, EventArgs e)
        {
            btn_showmeals.Show();
            btn_profil.Show();
            btn_menu.Hide();
            pbx_logo.Show();
            gbx_new.Hide();

            string decriptionname = txt_description.Text;
            double kj = Convert.ToDouble(num_kj.Value);
            double carbohydrates = Convert.ToDouble(num_carbohydrates.Value);

            Aktualisieren();
        }

        private void btn_confirmfood_Click_1(object sender, EventArgs e)
        {
            gbx_meallist.Show();
            gbx_new.Hide();

            //cls_User U = new cls_User();
            cls_naehrwerte NW = new cls_naehrwerte(txt_description.Text, Convert.ToDouble(num_kj.Value), Convert.ToDouble(num_calories.Value), Convert.ToDouble(num_fat.Value), Convert.ToDouble(num_carbohydrates.Value), Convert.ToDouble(num_fibre.Value), Convert.ToDouble(num_proteins.Value), Convert.ToDouble(num_salt.Value));
            cls_DataProv.InsertData_N(NW, localid);

            Aktualisieren();
        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            gbx_meallist.Show();
            gbx_new.Hide();
        }

        private void btn_showmeals_Click(object sender, EventArgs e)
        {
            btn_showmeals.Visible = false;
            btn_profil.Visible = false;
            pbx_logo.Visible = false;
            gbx_meallist.Show();
            btn_menu.Visible = true;

            Aktualisieren();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            gbx_new.Show();
            gbx_meallist.Hide();
            btn_menu.Hide();
        }

        //Methode zum Aktualisieren
        void Aktualisieren()
        {
            nährwerteliste.Clear();
            lbx_funktionier.Items.Clear();


            cls_naehrwerte naehrwerte = new cls_naehrwerte(localid);
            cls_DataProv.LoadData(nährwerteliste, localid);

            //Befüllen
            foreach (cls_naehrwerte NW in nährwerteliste)
            {
                lbx_funktionier.Items.Add(NW);
            }
        }

    }
}
