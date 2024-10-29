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
    public partial class Analystic : UserControl
    {
        public Analystic()
        {
            InitializeComponent();
        }
        bool i = true;
        public void clear_opra()
        {
            numericUpDown1.Value = 0;
            comboBox2.Text = "";
        }
        public void clear_re()
        {
            numericUpDown2.Value = 0;
            comboBox1.Text = "";
        }

        string opra, old_opra;
        float price, old_price;

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var x = this.new__personTableAdapter.search(textBox1.Text);  // 1
            var c = this.analysticTableAdapter.check(textBox1.Text);     //1 || 0

            if (textBox1.Text == "" || comboBox1.Text == "" || numericUpDown2.Value == 0)
            {
                MessageBox.Show("Error");
            }
            else if (x.Count == 0)
            {
                MessageBox.Show("ID not Found ");
            }
            else
            {
                if (x.Count == 1 && c.Count == 0)
                {
                    bool i = true;
                    while (i == true)
                    {
                        opra += comboBox1.Text + "..";
                        price = price + (float)numericUpDown2.Value;
                        DialogResult result = MessageBox.Show("", "Anthor?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Cancel)
                        {
                            textBox1.Focus();
                            opra = "";
                            price = 0;
                            break;
                        }
                        else if (result == DialogResult.OK)
                        {
                            this.analysticTableAdapter.Insert(textBox1.Text, " ", 0, opra, (decimal?)((float)price));
                            MessageBox.Show("Add is Done");
                            clear_opra();

                            break;
                        }


                    }
                }
                else
                {
                    old_opra = c.First().nameRumours;
                    old_price = (float)c.First().priceRumours;

                    while (i == true)
                    {
                        opra += comboBox1.Text + " , ";
                        price += (float)numericUpDown2.Value;
                        DialogResult result = MessageBox.Show("", "Anthor?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Cancel)
                        {
                            textBox1.Focus();
                            opra = "";
                            price = 0;
                            break;
                        }
                        else if (result == DialogResult.OK)
                        {
                            string total = old_opra + opra;
                            float prices = old_price + price;
                            this.analysticTableAdapter.Update_re(total, (decimal?)prices);
                            MessageBox.Show("Add is Done");
                            clear_opra();
                            break;
                        }
                    }
                }
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var x = this.new__personTableAdapter.search(textBox1.Text);  // 1
            var c = this.analysticTableAdapter.check(textBox1.Text);     //1 || 0

            if (textBox1.Text == "" || comboBox2.Text == "" || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Fill Data..");
            }
            else if (x.Count == 0)
            {
                MessageBox.Show("ID not Found ");
            }
            else
            {
                bool i = true;

                if (x.Count == 1 && c.Count == 0)
                {
                    
                    while (i == true)
                    {
                        opra += comboBox2.Text + "..";
                        price = price + (float)numericUpDown1.Value;
                        DialogResult result = MessageBox.Show("", "Anthor?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.Cancel)
                        {
                            textBox1.Focus();
                            opra = "";
                            price = 0;
                            break;
                        }
                        else if (result == DialogResult.OK)
                        {
                            this.analysticTableAdapter.Insert(textBox1.Text, opra, (decimal?)((float)price), " ", 0);
                            MessageBox.Show("Add is Done");
                            clear_opra();
                            break;

                        }

                    }
                }
                else
                {
                    old_opra = c.First().nameOper;
                    old_price = (float)c.First().priceOper;

                    while (i == true)
                    {
                        opra += comboBox2.Text + " , ";
                        price += (float)numericUpDown1.Value;
                        DialogResult result = MessageBox.Show("Anthor?", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        if (result == DialogResult.Cancel)
                        {
                            textBox1.Focus();
                            opra = "";
                            price = 0;
                            break;
                        }
                        else if (result == DialogResult.OK)
                        {
                            string total = old_opra + opra;
                            float prices = old_price + price;
                            this.analysticTableAdapter.Update_opra(total, (decimal?)prices);
                            clear_opra();
                            break;
                        }
  
                    }
                }
            }
        }

        private void Analystic_Load(object sender, EventArgs e)
        {

        }

        private void analysticBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.analysticBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_paitnet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
