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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var v = this.starttTableAdapter.enter(textBox1.Text , textBox2.Text);
            if(v.Count == 0 )
            {
                MessageBox.Show("Username / Passward Is wrong");
            }
            else
            {
                Home ho = new Home();
                  ho .Show();
                 this.Hide();
            }
          
        }

        private void Start_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_start.startt' table. You can move, or remove it, as needed.
            this.starttTableAdapter.Fill(this.data_start.startt);
            // TODO: This line of code loads data into the 'data_start.startt' table. You can move, or remove it, as needed.
            this.starttTableAdapter.Fill(this.data_start.startt);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void starttBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.starttBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_start);

        }

        private void starttBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.starttBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_start);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You sure ?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                textBox1.Text = "";
                textBox2.Text = "";

            }
            else { textBox1.Focus(); }

        }
    }
}
