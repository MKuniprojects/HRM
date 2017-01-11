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

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
          
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
                    

                    hrmdbDataSet1.Persons.Rows.Add(newRow);
                   
                    
                    // this.personsTableAdapter1.Update(this.hrmdbDataSet1.Persons);
                    using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
                    {

                        ta.Update(this.hrmdbDataSet1.Persons);
                    }

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

        }

        private void brs_Click(object sender, EventArgs e)
        {
            
            //test.Text = Convert.ToString(max);
          
        }
    }

}
