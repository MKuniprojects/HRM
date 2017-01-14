using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class CEOform : Form
    {
        public CEOform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHRM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void ceoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.hRMDBDataSet.Users);

        }

        private void HRM_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateusr_Click(object sender, EventArgs e)
        {
            using (HRMDBDataSetTableAdapters.UsersTableAdapter ta = new HRMDBDataSetTableAdapters.UsersTableAdapter())
            {
                ta.Update(this.hRMDBDataSet.Users);
                pictureBoxAccept.Visible = true;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LOGINform log = new LOGINform();
            this.Hide();
            log.Show();
        }

        private void dataGridViewHRM_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (HRMDBDataSetTableAdapters.UsersTableAdapter ta = new HRMDBDataSetTableAdapters.UsersTableAdapter())
            {
                ta.Update(this.hRMDBDataSet.Users);
            }
        }

        private void dataGridViewHRM_Enter(object sender, EventArgs e)
        {
            pictureBoxAccept.Visible = false;
        }
    }
}
