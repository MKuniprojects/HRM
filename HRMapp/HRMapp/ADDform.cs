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
    public partial class ADDform : Form
    {
        public byte[] CurrentPhotoProfileByteArray { get; set; }
        public short UserDpID { get; set; }
        public ADDform()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    HRMDBDataSet.PersonsRow newRow = hrmdbDataSet1.Persons.NewPersonsRow();
                    newRow.Firstname = txtnfname.Text;
                    newRow.Lastname = txtnlname.Text;
                    newRow.Mail = txtnmail.Text;
                    newRow.Phonenumber = textBoxPhoneNumber.Text;
                    newRow.Birthdate = dateTimePickern1.Value.ToString();
                    newRow.Gender = comboBoxnGender.Text;
                    newRow.Department = UserDpID;
                    newRow.Photoprofile = CurrentPhotoProfileByteArray;
                    hrmdbDataSet1.Persons.Rows.Add(newRow);
                    
                    using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                    {
                        ta.Update(this.hrmdbDataSet1.Persons);
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wrong Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
             }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
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
                        PictureBoxProfile.Image = Image.FromFile(ofd.FileName);
    
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

    }

}
