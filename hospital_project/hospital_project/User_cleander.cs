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
    public partial class User_cleander : UserControl
    {
        public User_cleander()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
          
        }


        private void new__personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.new__personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_paitnet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_cleander_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            var x = this.new__personTableAdapter.GetDataBy1(dateTimePicker1.Value.ToString());
            if (x.Count != 0)
            {
                Data_paitnet data = new Data_paitnet();
                this.new__personTableAdapter.FILLL(data.New__person, dateTimePicker1.Value.ToString());
                guna2DataGridView1.DataSource = data.New__person;

            }
        }
    }
}
