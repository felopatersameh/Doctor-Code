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
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            int age = Convert.ToInt32(textBox1.Text);
            float weight = float.Parse(textBox2.Text); //KG
            float height = float.Parse(textBox3.Text) / 100; // METER

            double bmi = weight / (height * height) * (1 + 0.02 * (age - 20));

            if (bmi < 18.5)
            {
                label4.Text = bmi.ToString();
                label5.Text = " is Under weight";
            }
            else if (bmi < 25)
            {
                label4.Text = bmi.ToString();
                label5.Text = " is Healthy weight";
            }
            else if (bmi < 30)
            {
                label4.Text = bmi.ToString();
                label5.Text = " is Overweight";
            }
            else if (bmi < 35)
            {
                label4.Text = bmi.ToString();
                label5.Text = ("Class 1 obesity");
            }
            else if (bmi < 40)
            {
                label4.Text = bmi.ToString();
                label5.Text = "Class 2 obesity";
            }
            else
            {
                label4.Text = bmi.ToString();
                label5.Text = "Class 3 obesity (morbidly obese)";
            }
        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label4.Text);
            SendKeys.Send("^c");
        }
    }
}
