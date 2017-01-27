using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class HRform : Form
    {
        public byte[] CurrentPhotoProfileByteArray { get; set; }
        private HRMDBDataSet.UsersRow thisUser;
        public short UserDpID { get; set; }

        public HRform()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            profileImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UserDpID = thisUser.DpID;
            LoadData();
            HRform f = new HRform();
        }

        public HRform(HRMDBDataSet.UsersRow myUser)
        {
            InitializeComponent();
            thisUser = myUser;
        }

        private void ShowProfileImage()
        {
            try
            {
                DataRowView dview = bindingSource1.Current as DataRowView;
                DataRow drow = dview.Row;

                var imgbytes = drow["Photoprofile"] as byte[];
                if (imgbytes == null)
                {
                    CurrentPhotoProfileByteArray = null;
                    profileImg.Image = null;
                    return;
                }
                using (var ms = new MemoryStream(imgbytes))
                {
                    profileImg.Image = Image.FromStream(ms);
                }
                CurrentPhotoProfileByteArray = imgbytes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    personsTableAdapter.FillBydp(ds.Persons, thisUser.DpID);
                    departmentsTableAdapter.FillBydpname(ds.Departments, UserDpID);
                    hrmdbDataSet1.Merge(ds);
                }
                Department.Text = "Department: " + hrmdbDataSet1.Departments.Rows[0]["Department"].ToString();
                ShowProfileImage();
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.DataSource = this.hrmdbDataSet1;
                DataRowView dview = bindingSource1.Current as DataRowView;
                dview.Row["Photoprofile"] = CurrentPhotoProfileByteArray;//tobytearray in db
                bindingSource1.EndEdit();
                using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                {
                    ta.Update(hrmdbDataSet1.Persons);
                    pictureBoxAccept.Visible = true;
                }
            }
            catch
            {
                throw;
            }
        }

        private void brs_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "jpeg|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        profileImg.Image = Image.FromFile(ofd.FileName);

                        byte[] imgdata = System.IO.File.ReadAllBytes(ofd.FileName);

                        CurrentPhotoProfileByteArray = imgdata;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            ShowProfileImage();
        }

        private void btnempadd_Click(object sender, EventArgs e)
        {
            ADDform f = new ADDform();
            f.UserDpID = thisUser.DpID;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                f.Dispose();
                LoadData();
            }
            else
            {
                f.Dispose();
            }
        }

        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LOGINform log = new LOGINform();
            Hide();
            log.Show();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
            {
                ta.Update(hrmdbDataSet1.Persons);
            }
        }

        private void update_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAccept.Visible = false;
        }
    }
}