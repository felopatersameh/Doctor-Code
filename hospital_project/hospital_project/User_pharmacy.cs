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
    public partial class User_pharmacy : UserControl
    {
        public User_pharmacy()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var x = this.medicineTableAdapter1.search(guna2ComboBox1.Text);
            if (x.Count == 0)
            {
                MessageBox.Show("There are Wrong");
            }
            else
            {
                Data_doctor data = new Data_doctor();
                this.medicineTableAdapter1.FillBy2(data.medicine , guna2ComboBox1.Text);
                guna2DataGridView1.DataSource = data.medicine;
            }
        }

    }
}
