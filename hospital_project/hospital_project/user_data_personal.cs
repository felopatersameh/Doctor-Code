using com.google.zxing.qrcode;
using com.google.zxing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace hospital_project
{
    public partial class user_data_personal : UserControl
    {
        public user_data_personal()
        {
            InitializeComponent();
            comboBox5.Hide();
            Bl.Text = "";
            Erroe.Text = "";
            suc.Text = "";
            label16.Text = "";
            ress.Visible = false;
        }

         public void clear ()
        {
            ress.Visible=false;
            textBox1.Text = "";
            Bl.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox7.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox9.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox1.Text = "";
            checkBox4.Checked = false;
            checkBox2.Checked = false;
            WhatsApp.Checked = false;
            femala.Checked = false;
            male.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            dateTimePicker1.Text = DateTime.Now.ToString();
            textBox1.Focus();

        }
         public void message ()
        { 
            Erroe.Text = "";
            suc.Text = "";
            Bl.Text = "";
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox5.Visible = !comboBox5.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BMI b=new BMI();
            b.Show();
        }
        string WhatsAp, gender, Health, Pressure, replas ;

        private void new__personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.new__personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_paitnet);

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)  //save
        {
            message();
            DateTime Today = DateTime.Today;
            // string time = Today.ToString();
            //stored _ BLOOD PRE
            BLOO = textBox11.Text + " / " + textBox10.Text;
            //store _ whatsApp
            if (WhatsApp.Checked == true) { WhatsAp = "Yes"; } else { WhatsAp = "No"; }
            //
            //store _ gender
            //
            if (male.Checked == true) { gender = "Male"; } else if (femala.Checked == true) { gender = "Female"; } else { gender = ""; } //
            //
            // store _ Health Insurance
            //
            if (radioButton1.Checked == true) { Health = "Yes"; } else if (radioButton2.Checked == true) { Health = "No"; } else { Health = ""; } //
            //
            //store _ Pressure Patient
            //
            if (radioButton4.Checked == true) { Pressure = "Hypotension"; } else if (radioButton5.Checked == true) { Pressure = "Hypertension"; } else if (radioButton6.Checked == true) { Pressure = "none"; } else { Pressure = ""; } //
            //
            //
            //store _ Diseases
            //
            //
            if (checkBox4.Checked == true) { d1 = "Diabetic"; }
            if (checkBox2.Checked == true) { d2 = "Cardiac Disease"; }
            if (comboBox5.Visible == true) { d3 = comboBox5.Text; }
            //
            //
            if (d1 == "Diabetic" && d2 == "Cardiac Disease" && d3 != null)
            {
                sd = d1 + " , " + d2 + " and " + d3;
            }
            else if (d1 != "Diabetic" && d2 == "Cardiac Disease" && d3 != null)
            {
                sd = d2 + " and " + d3;
            }
            else if (d1 == "Diabetic" && d2 != "Cardiac Disease" && d3 != null)
            {
                sd = d1 + " and " + d3;
            }
            else if (d1 == "Diabetic" && d2 == "Cardiac Disease" && d3 == null)
            {
                sd = d1 + " and " + d2;
            }
            else if (d1 != "Diabetic" && d2 != "Cardiac Disease" && d3 != null)
            {
                sd = d3;
            }
            else if (d1 != "Diabetic" && d2 == "Cardiac Disease" && d3 == null)
            {
                sd = d2;
            }
            else if (d1 == "Diabetic" && d2 != "Cardiac Disease" && d3 == null)
            {
                sd = d1;
            }
            else { sd = ""; }
            //
            //
            var x = this.new__personTableAdapter.search(textBox4.Text);
            if (x.Count == 1)
            {
                ress.Visible = true;
                Erroe.Text = "ID is Found";
            }
            else if (textBox4.Text == "") { Erroe.Text = "Enter ID"; ress.Visible = true; }
            else if (textBox1.Text == "") { Erroe.Text = " Enter  Name "; ress.Visible = true; }
            else if (textBox3.Text == "") { Erroe.Text = "Enter  address "; ress.Visible = true; }
            else if (gender == "") { Erroe.Text = "Enter  gender"; }
            else if (comboBox1.Text == "") { Erroe.Text = " Enter Marital Status "; ress.Visible = true; }
            else if (textBox7.Text == "") { Erroe.Text = "Enter Phone"; }
            else if (Health == "") { Erroe.Text = "Enter  Health Insurance"; ress.Visible = true; }
            else if (sd == "") { Erroe.Text = "Enter Diseases "; }
            else if (comboBox3.Text == "") { Erroe.Text = "Enter Therapeutic department"; ress.Visible = true; }
            else if (textBox10.Text == "" || textBox11.Text == "") { Erroe.Text = "Enter Blood Pressure"; ress.Visible = true; }
            else if (Pressure == "") { Erroe.Text = "Enter Pressure Patient"; ress.Visible = true; }
            else if (textBox9.Text == "") { Erroe.Text = "Enter  Blood Glucose Level"; ress.Visible = true; }
            else if (textBox8.Text == "") { Erroe.Text = "Enter  Body Mass Index "; ress.Visible = true; }
            else
            {
                this.new__personTableAdapter.Insert_Data(Today.ToString(), textBox4.Text, textBox1.Text, dateTimePicker1.Text, textBox3.Text, gender, comboBox1.Text, textBox7.Text, WhatsAp, textBox2.Text, textBox6.Text, Health, textBox5.Text, comboBox3.Text, Pressure, BLOO, textBox9.Text, float.Parse(textBox8.Text), comboBox4.Text, sd);
                suc.Text = "Add is Done";
                ress.Visible = true;
                clear();
            }
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)  //search
        {
            message();
            var x = this.new__personTableAdapter.search(textBox4.Text);
            if (x.Count == 0)
            {
                Erroe.Text = "ID is not Found";
                ress.Visible = true;
            }
            else if (textBox4.Text == "") { Erroe.Text = "Enter ID"; }
            else
            {
                suc.Text = "Search is Done";
                ress.Visible = true;
                textBox1.Text = x.First().Name;
                textBox4.Text = x.First().ID;
                textBox3.Text = x.First().Address;
                textBox7.Text = x.First().phone1;
                textBox2.Text = x.First().phone2;
                textBox6.Text = x.First().Medicen;
                textBox8.Text = x.First().bmi.ToString();
                Bl.Text = x.First().Bloodpressure;
                textBox9.Text = x.First().BloodGlogoz;
                textBox5.Text = x.First().doctor;
                comboBox4.Text = x.First().sports;
                comboBox1.Text = x.First().Status;
                comboBox3.Text = x.First().deName;
                if (x.First().whatsapp.Contains("Yes") == true) { WhatsApp.Checked = true; } else { WhatsApp.Checked = false; }
                if (x.First().Gender.Contains("Male") == true) { male.Checked = true; } else { femala.Checked = true; }
                if (x.First().pressurepatinet == "Hypotension")
                { radioButton4.Checked = true; }
                else if (x.First().pressurepatinet == "Hypotension")
                { radioButton5.Checked = true; }
                else { radioButton6.Checked = true; }

                dateTimePicker1.Text = x.First().DOB.ToString();

                if (x.First().Health.Contains("Yes") == true) { radioButton1.Checked = true; } else { radioButton2.Checked = true; }
                string dis = x.First().Diseases;
                if (dis.Contains("Diabetic") == true) { checkBox4.Checked = true; }
                if (dis.Contains("Cardiac Disease")) { checkBox2.Checked = true; }
                if (dis.Contains("Cardiac Disease") == true || dis.Contains("Diabetic") == true)
                {
                    replas = dis.Replace("Diabetic", "");
                    replas = dis.Replace("Cardiac Disease", "");
                    comboBox5.Show();
                    comboBox5.Text = replas;
                }
                else
                {
                    comboBox5.Show();
                    comboBox5.Text = dis;
                }
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)  // delete
        {
            message();
            var x = this.new__personTableAdapter.search(textBox4.Text);

            if (x.Count == 0)
            {
                ress.Visible = true;
                Erroe.Text = "ID is not Found";
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure? \n All Data are Deleting ", "Delet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    this.new__personTableAdapter.Delete_data(textBox4.Text);
                    suc.Text = "Done Delete";
                    ress.Visible = true;

                    clear();

                }
                else
                {
                    textBox4.Focus();
                }
            }
        }

        private void user_data_personal_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e) // update
        {
            message();
            var x = this.new__personTableAdapter.search(textBox4.Text);
            //stored _ BLOOD PRE
            BLOO = textBox11.Text + " / " + textBox10.Text;
            //store _ whatsApp
            if (WhatsApp.Checked == true) { WhatsAp = "Yes"; } else { WhatsAp = "No"; }
            //
            //store _ gender
            //
            if (male.Checked == true) { gender = "Male"; } else if (femala.Checked == true) { gender = "Female"; } else { gender = ""; } //
            //
            // store _ Health Insurance
            //
            if (radioButton1.Checked == true) { Health = "Yes"; } else if (radioButton2.Checked == true) { Health = "No"; } else { Health = ""; } //
            //
            //store _ Pressure Patient
            //
            if (radioButton4.Checked == true) { Pressure = "Hypotension"; } else if (radioButton5.Checked == true) { Pressure = "Hypotension"; } else if (radioButton6.Checked == true) { Pressure = "none"; } else { Pressure = ""; } //
            //
            //
            //store _ Diseases
            //
            //
            if (checkBox4.Checked == true) { d1 = "Diabetic"; }
            if (checkBox2.Checked == true) { d2 = "Cardiac Disease"; }
            if (comboBox5.Visible == true) { d3 = comboBox5.Text; }
            if (d1 == "Diabetic" && d2 == "Cardiac Disease" && d3 != null)
            {
                sd = d1 + " , " + d2 + " and " + d3;
            }
            else if (d1 != "Diabetic" && d2 == "Cardiac Disease" && d3 != null)
            {
                sd = d2 + " and " + d3;
            }
            else if (d1 == "Diabetic" && d2 != "Cardiac Disease" && d3 != null)
            {
                sd = d1 + " and " + d3;
            }
            else if (d1 == "Diabetic" && d2 == "Cardiac Disease" && d3 == null)
            {
                sd = d1 + " and " + d2;
            }
            else if (d1 != "Diabetic" && d2 != "Cardiac Disease" && d3 != null)
            {
                sd = d3;
            }
            else if (d1 != "Diabetic" && d2 == "Cardiac Disease" && d3 == null)
            {
                sd = d2;
            }
            else if (d1 == "Diabetic" && d2 != "Cardiac Disease" && d3 == null)
            {
                sd = d1;
            }
            else { sd = ""; }

            if (x.Count == 0)
            {
                Erroe.Text = "ID is not Found";
                ress.Visible = true;

            }
                
            else if (textBox1.Text == "") { Erroe.Text = " Enter  Name "; ress.Visible = true; }
            else if (textBox3.Text == "") { Erroe.Text = "Enter  address "; ress.Visible = true; }
            else if (gender == "") { Erroe.Text = "Enter  gender"; ress.Visible = true; }
            else if (comboBox1.Text == "") { Erroe.Text = " Enter Marital Status "; ress.Visible = true; }
            else if (textBox7.Text == "") { Erroe.Text = "Enter Phone"; ress.Visible = true; }
            else if (Health == "") { Erroe.Text = "Enter  Health Insurance"; ress.Visible = true; }
            else if (sd == "") { Erroe.Text = "Enter Diseases "; ress.Visible = true;  }
            else if (comboBox3.Text == "") { Erroe.Text = "Enter Therapeutic department"; ress.Visible = true;  }
            else if (textBox10.Text == "" || textBox11.Text == "") { Erroe.Text = "Enter Blood Pressure"; ress.Visible = true; }
            else if (Pressure == "") { Erroe.Text = "Enter Pressure Patient"; ress.Visible = true; }
            else if (textBox9.Text == "") { Erroe.Text = "Enter  Blood Glucose Level"; ress.Visible = true; }
            else if (textBox8.Text == "") { Erroe.Text = "Enter  Body Mass Index "; ress.Visible = true; }
            else
            {
                this.new__personTableAdapter.Update_Data(textBox4.Text, textBox1.Text, dateTimePicker1.Text, textBox3.Text, gender, comboBox1.Text, textBox7.Text, WhatsAp, textBox2.Text, textBox6.Text, Health, textBox5.Text, comboBox3.Text, Pressure, BLOO, textBox9.Text, float.Parse(textBox8.Text), comboBox4.Text, sd);
                suc.Text = "Update is Done";
                ress.Visible = true;
                clear();
            }
        }

        string BLOO;
        string d1, d2, d3;
        string sd;

    }
}
