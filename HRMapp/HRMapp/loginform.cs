using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HRMDBDataSet ds = new HRMDBDataSet())
            {
                using (HRMDBDataSetTableAdapters.UsersTableAdapter ta= new HRMDBDataSetTableAdapters.UsersTableAdapter())
                {
                    ta.FillByNameAndPassword(ds.Users, textBox1.Text, textBox2.Text);
                }
                if (ds.Users.Count == 1)
                {
                    Home f = new Home();
                    this.Hide();
                    f.Show();
                    
                }
                
            }
            
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
