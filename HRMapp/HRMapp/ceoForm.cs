using System;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class CEOform : Form
    {
        public short id { get; set; }

        public CEOform()
        {
            InitializeComponent();
        }

        private void ceoForm_Load(object sender, EventArgs e)
        {
            departmentsTableAdapter.FillDP(hRMDBDataSet.Departments);
            usersTableAdapter.Fill(hRMDBDataSet.Users);
            dataGridViewUsers.Rows[0].ReadOnly = true;
        }

        private void updateusr_Click(object sender, EventArgs e)
        {
            using (HRMDBDataSetTableAdapters.UsersTableAdapter ta = new HRMDBDataSetTableAdapters.UsersTableAdapter())
            {
                ta.Update(hRMDBDataSet.Users);
                pictureBoxAccept.Visible = true;
            }
            using (HRMDBDataSetTableAdapters.DepartmentsTableAdapter dp = new HRMDBDataSetTableAdapters.DepartmentsTableAdapter())
            {
                dp.Update(hRMDBDataSet.Departments);
                pictureBoxAccept.Visible = true;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LOGINform log = new LOGINform();
            Hide();
            log.Show();
        }

        private void dataGridViewHRM_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (HRMDBDataSetTableAdapters.UsersTableAdapter ta = new HRMDBDataSetTableAdapters.UsersTableAdapter())
            {
                ta.Update(hRMDBDataSet.Users);
            }
        }

        private void updateusr_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAccept.Visible = false;
        }

        private void dataGridViewDprt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string d = dataGridViewDprt.Rows[e.RowIndex].Cells[0].Value.ToString();
                id = Convert.ToInt16(d);
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    personsTableAdapter.FillBydp(ds.Persons, id);
                    BindingSource bsource = new BindingSource();
                    bsource.DataSource = ds.Persons;
                    dataGridViewEmployees.DataSource = bsource;
                    personsTableAdapter.Update(ds.Persons);
                }
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}