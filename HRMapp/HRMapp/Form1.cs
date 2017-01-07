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
    public partial class Home : Form
    {
        public byte[] CurrentPhotoProfileByteArray { get; set; }
        private HRMDBDataSet.UsersRow thisUser;
        public short UserDpID { get; set; }

        public Home()
        {
            InitializeComponent();
           
        }

        public Home(HRMDBDataSet.UsersRow myUser)
        {
            //Δημιουργείς constructor να δέχετε UsersRow ως όρισμα, οπότε έχεις όλες τις κολόνες της βάσεις ως ιδιότητες στο 
            // αντικείμενο myUSer
            // Χρησιμοποιείς αυτό το αντικείμενο εδώ μέσα για να μην το ξαναφωνάξεις.

            InitializeComponent();
            thisUser = myUser;
        }



        void ShowProfileImage()
        {
            try
            {
                DataRowView dview = bindingSource1.Current as DataRowView;
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
            catch (Exception ex)
            {

                throw;
            }

        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoadData();
            Home f = new Home();
            int id=f.UserDpID = thisUser.DpID;
            Department.Text = "Department: " +Convert.ToString(id);
        }

        private void LoadData()
        {
            try
            {
                // TODO: This line of code loads data into the 'hrmdbDataSet1.Persons' table. You can move, or remove it, as needed.
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    this.personsTableAdapter.FillBydp(ds.Persons, thisUser.DpID);
                    hrmdbDataSet1.Merge(ds);
                }
                

                
                ShowProfileImage();
                      // dataGridView1.DataSource = this.personsTableAdapter.GetDataBydp;
            }
            catch (Exception)
            {

                throw;
            }
          
        }


        private void FillComboBoxJobID(ref ComboBox jobComboBox)
        {
            try
            {

                ComboboxItem comCEO = new ComboboxItem() { Text = "CEO", Value = 1 };
                ComboboxItem comStuff = new ComboboxItem() { Text = "Stuff", Value = 0 };

                List<ComboboxItem> comboitemList = new List<ComboboxItem>() { comCEO, comStuff };

                jobComboBox.Items.AddRange(comboitemList.ToArray());
                jobComboBox.SelectedIndex = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                this.bindingSource1.DataSource = this.hrmdbDataSet1;
                DataRowView dview = bindingSource1.Current as DataRowView;
                dview.Row["Photoprofile"] = CurrentPhotoProfileByteArray; // edw kanoume sti vasi to bytearray
                bindingSource1.EndEdit();

                // this.personsTableAdapter.Update(this.hrmdbDataSet1.Persons);
                using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                {

                    ta.Update(this.hrmdbDataSet1.Persons);
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

                        byte[] imgdata = System.IO.File.ReadAllBytes(ofd.FileName);

                        CurrentPhotoProfileByteArray = imgdata; // den eimai sigouros gia auti ti grammi

                        //var imageByte = Image.FromFile(ofd.FileName);
                        using (var ms = new MemoryStream(imgdata))
                        {
                            profile.Image = Image.FromStream(ms);
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // αυτό το event, κάνει fire , κάθε φορά που αλλάζουμε επιλεγμένη γραμμή στο dataset. 
        // Επειδή δεν έχει databind η φωτό όπως έχουμε τα text box, θα βάζουμε τη συνάρτηση να μας φτιάχνει το profile
        // 
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            ShowProfileImage();
        }


        private void btnempadd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.UserDpID = thisUser.DpID;
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK) {
                f.Dispose();
                LoadData();
            }
            else
            {
                f.Dispose();
            }
        }

     

        private void fillBydpToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.personsTableAdapter.FillBydp(this.hrmdbDataSet1.Persons);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBydpToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //    this.personsTableAdapter.FillBydp(this.hrmdbDataSet1.Persons);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void txtnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
