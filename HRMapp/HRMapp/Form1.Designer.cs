namespace HRMapp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Department = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.brs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.btnempadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hrmdbDataSet1 = new HRMapp.HRMDBDataSet();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersTableAdapter1 = new HRMapp.HRMDBDataSetTableAdapters.UsersTableAdapter();
            this.personsTableAdapter = new HRMapp.HRMDBDataSetTableAdapters.PersonsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmdbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Department);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnempadd);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 500);
            this.panel1.TabIndex = 0;
            // 
            // Department
            // 
            this.Department.Enabled = false;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(34, 16);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(208, 34);
            this.Department.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboBoxGender);
            this.panel2.Controls.Add(this.brs);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtadr);
            this.panel2.Controls.Add(this.txtmail);
            this.panel2.Controls.Add(this.txtnum);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Lastname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtlname);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtfname);
            this.panel2.Controls.Add(this.profile);
            this.panel2.Location = new System.Drawing.Point(397, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 403);
            this.panel2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Birthdate", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSource1, "Gender", true));
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "Gender", true));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Ginger",
            "Trans",
            "No Gender fuck off",
            "duck"});
            this.comboBoxGender.Location = new System.Drawing.Point(270, 77);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(131, 24);
            this.comboBoxGender.TabIndex = 7;
            // 
            // brs
            // 
            this.brs.Location = new System.Drawing.Point(17, 215);
            this.brs.Name = "brs";
            this.brs.Size = new System.Drawing.Size(160, 34);
            this.brs.TabIndex = 17;
            this.brs.Text = "Browse";
            this.brs.UseVisualStyleBackColor = true;
            this.brs.Click += new System.EventHandler(this.brs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adress";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ph.number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Birthdate";
            // 
            // txtadr
            // 
            this.txtadr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Adress", true));
            this.txtadr.Location = new System.Drawing.Point(270, 192);
            this.txtadr.Multiline = true;
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(131, 57);
            this.txtadr.TabIndex = 12;
            // 
            // txtmail
            // 
            this.txtmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Mail", true));
            this.txtmail.Location = new System.Drawing.Point(270, 161);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(131, 22);
            this.txtmail.TabIndex = 11;
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Phonenumber", true));
            this.txtnum.Location = new System.Drawing.Point(270, 133);
            this.txtnum.MaxLength = 10;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(131, 22);
            this.txtnum.TabIndex = 10;
            this.txtnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnum_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gender";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(194, 54);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(70, 17);
            this.Lastname.TabIndex = 7;
            this.Lastname.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firstname";
            // 
            // txtlname
            // 
            this.txtlname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Lastname", true));
            this.txtlname.Location = new System.Drawing.Point(270, 51);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(131, 22);
            this.txtlname.TabIndex = 4;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(270, 262);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 37);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(17, 323);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 61);
            this.textBox2.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Firstname", true));
            this.txtfname.Location = new System.Drawing.Point(270, 23);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(131, 22);
            this.txtfname.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(17, 21);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(160, 188);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            // 
            // btnempadd
            // 
            this.btnempadd.Location = new System.Drawing.Point(697, 16);
            this.btnempadd.Name = "btnempadd";
            this.btnempadd.Size = new System.Drawing.Size(117, 34);
            this.btnempadd.TabIndex = 6;
            this.btnempadd.Text = "Add Employee";
            this.btnempadd.UseVisualStyleBackColor = true;
            this.btnempadd.Click += new System.EventHandler(this.btnempadd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 403);
            this.dataGridView1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "ΑΞΙΟΛΟΓΗΣΗ";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Persons";
            this.bindingSource1.DataSource = this.hrmdbDataSet1;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // hrmdbDataSet1
            // 
            this.hrmdbDataSet1.DataSetName = "HRMDBDataSet";
            this.hrmdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.FillWeight = 30F;
            this.personIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            this.personIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Visible = false;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            this.mailDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmdbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
   
        private HRMDBDataSet hrmdbDataSet1;
        private HRMDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HRMDBDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnempadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button brs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label label7;
    }
}

