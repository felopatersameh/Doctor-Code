using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_project
{
    public partial class user_setting : UserControl
    {
        public user_setting()
        {
            InitializeComponent();
            neww.Text = "";
            old.Text = "";
            Done.Text = "";
            panel1.Visible = false;
            panel2.Visible = false;
            guna2Panel2.Visible = false; ;
            name.Text = "";
            department.Text = "";
            price.Value = 0;
            information.Text = "";
            pa7.Visible = false;


        }



        private void guna2GradientButton1_Click(object sender, EventArgs e) //passward
        {
            neww.Text = "";
            old.Text = "";
            Done.Text = "";
            var x = this.starttTableAdapter.Search(textBox1.Text);
            if (x.Count == 0)
            {
                old.Text = "Wrong";
            }
            else if (textBox1.Text == "")
            {
                old.Text = "Wrong";
                textBox1.Focus();
            }
            else if (textBox2.Text == "" || textBox3.Text == "" || textBox2.Text != textBox3.Text)
            {
                neww.Text = "Wrong";
                textBox2.Focus();
            }
            else
            {
                this.starttTableAdapter.Update1(textBox2.Text);
                Done.Text = "done successfully";
            }
        }


        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var x = this.starttTableAdapter.Search(textBox6.Text);
            if (x.Count == 0) { MessageBox.Show("Wrong passward"); }
            else { this.starttTableAdapter.Update2(textBox5.Text); MessageBox.Show("Done"); }
        }


        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            guna2Panel2.Visible = false;
            pa7.Visible = false;

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            guna2Panel2.Visible = false;
            pa7.Visible = false;



        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            guna2Panel2.Visible = true; ;
            pa7.Visible = false;


        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void user_setting_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            var x = medicineTableAdapter.search(name.Text);
            if (x.Count == 1 )
            {
                MessageBox.Show("name Is Found ..");
            }
            else if (name.Text == "" || department.Text == "" || price.Value == 0 || information.Text == "")
            {
                MessageBox.Show("Fill data");
            }
            else
            {
                medicineTableAdapter.Insert1(department.Text, name.Text, price.Value, information.Text);
                MessageBox.Show("Done");
                name.Text = "";
                department.Text = "";
                price.Value = 0;
                information.Text = "";
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            var x = medicineTableAdapter.search(name.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("name Is Wrong ..");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Delete?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    medicineTableAdapter.Delete1(name.Text); 
                    MessageBox.Show("Done");
                    name.Text = "";
                    department.Text = "";
                    price.Value = 0;
                    information.Text = "";
                }

                else { name.Focus(); }
                

            }
        }

        private void guna2GradientButton9_Click(object sender, EventArgs e)
        {
            var x = medicineTableAdapter.search(name.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("name Is Wrong ..");
            }
            else
            { medicineTableAdapter.Update1(department.Text, name.Text, price.Value, information.Text); MessageBox.Show("Update is Done"); }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            pa7.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            guna2Panel2.Visible = false; ;
        }
    }
}
