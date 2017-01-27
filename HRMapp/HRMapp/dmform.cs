using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class DMform : Form
    {
        public byte[] CurrentPhotoProfileByteArray { get; set; }
        private HRMDBDataSet.UsersRow thisUsr;
        public short UserDpID { get; set; }

        public DMform()
        {
            InitializeComponent();
        }

        public DMform(HRMDBDataSet.UsersRow myUser)
        {
            //Constructor
            InitializeComponent();
            thisUsr = myUser;
        }

        private void dmform_Load(object sender, EventArgs e)
        {
            this.UserDpID = thisUsr.DpID;
            LoadData();
            DMform f = new DMform();
            profile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadData()
        {
            try
            {
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    personsTableAdapter.FillBydp(ds.Persons, thisUsr.DpID);
                    departmentsTableAdapter1.FillBydpname(ds.Departments, UserDpID);
                    hRMDBDataSet.Merge(ds);
                }
                Departmentm.Text = "Department: " + hRMDBDataSet.Departments.Rows[0]["Department"].ToString();
                ShowProfileImage();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ShowProfileImage()
        {
            try
            {
                DataRowView dview = personsBindingSource.Current as DataRowView;
                DataRow drow = dview.Row;
                var imgbytes = drow["Photoprofile"] as Byte[];
                if (imgbytes == null)
                {
                    CurrentPhotoProfileByteArray = null;
                    profile.Image = null;
                    return;
                }

                using (var ms = new MemoryStream(imgbytes))
                {
                    profile.Image = Image.FromStream(ms);
                }
                CurrentPhotoProfileByteArray = imgbytes;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                personsBindingSource.EndEdit();
                using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                {
                    ta.Update(this.hRMDBDataSet.Persons);
                    pictureBoxAccept.Visible = true;
                }
                ShowProfileImage();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LOGINform log = new LOGINform();
            Hide();
            log.Show();
        }

        private void personsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            ShowProfileImage();
        }

        private void update_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxAccept.Visible = false;
        }
    }
}