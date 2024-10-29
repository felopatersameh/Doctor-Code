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
    public partial class User_doctor : UserControl
    {
        public User_doctor()
        {
            InitializeComponent();
            clear_form();
            claer_label();
        }
        string gender , whatsap;
        public void clear_form()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            checkBox1.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
        public void claer_label ()
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_doctor);

        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)  //insert
        {
            claer_label();
            if (radioButton2.Checked == true) { gender = "Male"; } else if (radioButton1.Checked == true) { gender = "Female"; }
            if (checkBox1.Checked == true) { whatsap = "Yes"; } else { whatsap = "No"; }
            var x = this.doctorTableAdapter.Search(textBox2.Text);
            if (x.Count == 1)
            {
                label7.Text = "Is Found";
            }
            else if (textBox1.Text == "")
            {
                label6.Text = "Erorr";
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                label7.Text = "Erorr";
                textBox2.Focus();
            }
            else if (textBox3.Text == "")
            {
                label8.Text = "Erorr";
                textBox3.Focus();
            }
            else if (gender == "")
            {
                label9.Text = "Erorr";
            }
            else if (textBox6.Text == "")
            {
                label10.Text = "Erorr";
                textBox6.Focus();
            }
            else
            {
                this.doctorTableAdapter.Insert_Data(textBox2.Text, textBox1.Text, textBox3.Text, gender, textBox6.Text, whatsap);
                clear_form();
                MessageBox.Show("Done Successfully");

            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)  //search
        {
            claer_label();
            if (gender == "Male") { radioButton2.Checked = true; } else if (gender == "Female") { radioButton1.Checked = true; }
            if (whatsap == "Yes") { checkBox1.Checked = true; } else { checkBox1.Checked = false; }
            var x = this.doctorTableAdapter.Search(textBox2.Text);
            if (x.Count == 0)
            {
                label7.Text = "Is not Found";
            }
            else
            {
                textBox1.Text = x.First().Name;
                textBox3.Text = x.First().department;
                textBox6.Text = x.First().phone;
                gender = x.First().Gender;
                whatsap = x.First().whatsapp;
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e) //delete
        {
            claer_label();
            var x = this.doctorTableAdapter.Search(textBox2.Text);
            if (x.Count == 0)
            {
                label7.Text = "Is Not Found";
            }
            else
            {
                DialogResult re = MessageBox.Show("Are You Sure? \n All Data are Deleting ", "Deleting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (re == DialogResult.Yes)
                {
                    this.doctorTableAdapter.Delete_Data(textBox2.Text);
                }
                else
                {
                    textBox2.Focus();
                }
        }
            }

        private void guna2GradientButton3_Click(object sender, EventArgs e) //update
        {
            claer_label();
            var x = this.doctorTableAdapter.Search(textBox2.Text);
            if (x.Count == 0)
            {
                label7.Text = "Is Not Found";
            }
            else
            {
                this.doctorTableAdapter.Update_Data(textBox2.Text, textBox1.Text, textBox3.Text, gender, textBox6.Text, whatsap);
                MessageBox.Show("Update is succeeded");
                
            }
        }

    }
}
