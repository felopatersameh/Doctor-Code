using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            panel2.Top = Homee.Top;
            user_home1.BringToFront();
            doc.Visible = false;
            pa.Visible = false;
            print.Visible = false;
            cleander.Visible = false;
            pharmacy.Visible = false;
            timer1.Start();
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel2.Top = Homee.Top;
            user_home1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panel2.Top = addd.Top;
            pa.Visible = !pa.Visible;
            doc.Visible = !doc.Visible;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panel2.Top = search.Top;
            print.Visible = !print.Visible;
            cleander.Visible = !cleander.Visible;
            pharmacy.Visible = !pharmacy.Visible;


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            analystic1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel2.Top = setting.Top;
            user_setting1.BringToFront();

        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            panel2.Top = result.Top;
            user_Rusulet1.BringToFront();

        }

        private void doc_Click(object sender, EventArgs e)
        {
            user_doctor1.BringToFront();
        }

        private void pa_Click(object sender, EventArgs e)
        {
            user_data_personal1.BringToFront();
        }

        private void cleander_Click(object sender, EventArgs e)
        {
            user_cleander1.BringToFront();
        }

        private void pharmacy_Click(object sender, EventArgs e)
        {
            user_pharmacy1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            Date.Text = dateTime.ToString("dd/MM/yyyy  hh:mm:ss tt");
        }
    }
}
