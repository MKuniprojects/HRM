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
    public partial class dmform : Form
    {
        private HRMDBDataSet.UsersRow thisUser;
        public short UserDpID { get; set; }
        public dmform()
        {
            InitializeComponent();

        }


    

        private void dmform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMDBDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter1.Fill(this.hRMDBDataSet.Persons);
            //dmform g = new dmform();
            //int id = g.UserDpID = thisUser.DpID;
            //Departmentm.Text = "Department: " + Convert.ToString(id);
        }

        private void updatedm_Click(object sender, EventArgs e)
        {
            using (HRMDBDataSetTableAdapters.PersonsTableAdapter ta = new HRMDBDataSetTableAdapters.PersonsTableAdapter())
            {

                try
                {
                    this.personsBindingSource.DataSource = this.hRMDBDataSet;
                    //DataRowView dview = personsBindingSource.Current as DataRowView;
                    //dview.Row["Photoprofile"] = CurrentPhotoProfileByteArray; // edw kanoume sti vasi to bytearray
                    personsBindingSource.EndEdit();

                   ta.Update(this.hRMDBDataSet.Persons);
                   

                }
                catch
                {
                    throw;

                }



            }
        }
        }
    }

