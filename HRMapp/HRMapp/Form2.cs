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
    public partial class Form2 : Form
    {
        public short UserDpID { get; set; }
       // public HRMDBDataSet.PersonsDataTable myPersonsDataTable { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
       

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                using (HRMDBDataSet ds = new HRMDBDataSet())
                {
                    this.Validate();

                    //ds.Merge(myPersonsDataTable);
                    HRMDBDataSet.PersonsRow newRow = ds.Persons[0];
                    //newRow.PersonID = -1;
                    newRow.Firstname = txtnfname.Text;
                    newRow.Lastname = txtnlname.Text;
                    newRow.Mail = txtnmail.Text;
                    newRow.Phonenumber = textBoxPhoneNumber.Text;
                    newRow.Birthdate = dateTimePickern1.Value.ToString();
                    newRow.Gender = comboBoxnGender.Text;
                    newRow.Department = UserDpID;

                    //hrmdbdataset.personsrow finalrow = ds.persons.findbypersonid(newrow.personid);
                    //finalrow = ds.persons.loaddatarow(newrow.itemarray(), true);

                   // ds.persons.addpersonsrow(newrow);
                 //   ds.acceptchanges();
                    

                    using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                    {
                        
                        ta.Update(ds.Persons);
                        
                    }
                    // return bitch
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wrong Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }
    }

}
