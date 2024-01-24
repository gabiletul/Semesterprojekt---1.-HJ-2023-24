using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveVita
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int time = 8;
        private void timer1_Tick(object sender, EventArgs e)
        {
           

                pictureBox1.Image = Properties.Resources.SaveVita_Logo;
            timer2.Start();
             
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            btn_register.Enabled = true;
            btn_register.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

        }
    }
}
