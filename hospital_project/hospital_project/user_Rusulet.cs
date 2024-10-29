using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_project
{
    public partial class user_Rusulet : UserControl
    {
        public user_Rusulet()
        {
            InitializeComponent();
            yes.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        string namme;
        decimal price;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var b = this.new__personTableAdapter.search(textBox4.Text);
            var v = this.analysticTableAdapter.check(textBox4.Text);

            namme = b.First().Name;
             price = v.First().priceOper + v.First().priceRumours;

            //نفس العمود //     نفس السطر   
            e.Graphics.DrawString("Doctor.code" , new Font("stencil", 3), Brushes.DarkBlue, new PointF(2, 2));
            e.Graphics.DrawString("Name: " + namme, new Font("Arial", 12), Brushes.Black, new PointF(3,10));
            e.Graphics.DrawString("Price: " + price  , new Font("Arial", 12), Brushes.Black, new PointF(3, 26));
            e.Graphics.DrawString("Signature:", new Font("Arial", 12), Brushes.Black, new PointF(3, 43));
        }

        private void user_Rusulet_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {


            yes.Text = "";
            PrintDocument document = new PrintDocument();
            document.DefaultPageSettings.PaperSize = new PaperSize("Custom", 170, 90 );
            document.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = document;
            previewDialog.ShowDialog();
        }
        string name;
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            var p = this.analysticTableAdapter.check(textBox4.Text);
            if (p.Count == 0)
            {
                yes.Text = "ID Not Found";
            }
            else
            {
                decimal cal = p.First().priceOper + p.First().priceRumours;
                yes.Text = cal.ToString();
                
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            yes.Text = "";
            var p = this.analysticTableAdapter.check(textBox4.Text);
            if (p.Count == 0)
            {
                yes.Text = "ID Not Found";
            }
            else
            {
                DialogResult result = MessageBox.Show("Delete !", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK) { analysticTableAdapter.Delete__data(textBox4.Text); MessageBox.Show("Done"); }
                else { textBox4.Focus(); }
            }
        }
    }
}
