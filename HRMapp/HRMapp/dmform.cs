using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMapp
{
    public partial class dmform : Form
    {
        public byte[] CurrentPhotoProfileByteArray { get; set; }
        private HRMDBDataSet.UsersRow thisUsr;
        public short UserDpID  { get; set; }

        public dmform()
        {
            InitializeComponent();
        }

        public dmform(HRMDBDataSet.UsersRow myUser)
        {
            //Constructor
            InitializeComponent();
            thisUsr = myUser;
           
        }

        private void dmform_Load(object sender, EventArgs e)
        {
            LoadData();
            dmform f = new dmform();
            int id = f.UserDpID = thisUsr.DpID;
            Departmentm.Text = "Department: " + Convert.ToString(id);
        }

        private void LoadData()
        {
            
            try
            {
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    this.personsTableAdapter.FillBydp(ds.Persons, thisUsr.DpID);
                    hRMDBDataSet.Merge(ds);
                }
                ShowProfileImage();
            }
            catch (Exception)
            {

                throw;
            }

        }
        void ShowProfileImage()
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

                throw;
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
                }
                ShowProfileImage();
            }
            catch(Exception)
            {
                throw;

            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loginform log = new loginform();
            this.Hide();
            log.Show();
        }
        private void personsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            ShowProfileImage();
        }


    }
}
