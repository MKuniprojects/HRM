namespace HRMapp
{
    partial class dmform
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
            this.paneldm = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.Departmentm = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.birthdate = new System.Windows.Forms.TextBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDBDataSet = new HRMapp.HRMDBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
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
            this.dataGridViewdm = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoprofileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsTableAdapter = new HRMapp.HRMDBDataSetTableAdapters.PersonsTableAdapter();
            this.usersTableAdapter1 = new HRMapp.HRMDBDataSetTableAdapters.UsersTableAdapter();
            this.paneldm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdm)).BeginInit();
            this.SuspendLayout();
            // 
            // paneldm
            // 
            this.paneldm.Controls.Add(this.Logout);
            this.paneldm.Controls.Add(this.Departmentm);
            this.paneldm.Controls.Add(this.panel2);
            this.paneldm.Controls.Add(this.dataGridViewdm);
            this.paneldm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldm.Location = new System.Drawing.Point(0, 0);
            this.paneldm.Name = "paneldm";
            this.paneldm.Size = new System.Drawing.Size(804, 476);
            this.paneldm.TabIndex = 0;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(281, 19);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 28);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Departmentm
            // 
            this.Departmentm.Enabled = false;
            this.Departmentm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departmentm.Location = new System.Drawing.Point(12, 12);
            this.Departmentm.Name = "Departmentm";
            this.Departmentm.Size = new System.Drawing.Size(208, 34);
            this.Departmentm.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.birthdate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxGender);
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
            this.panel2.Location = new System.Drawing.Point(375, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 403);
            this.panel2.TabIndex = 8;
            // 
            // birthdate
            // 
            this.birthdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Birthdate", true));
            this.birthdate.Enabled = false;
            this.birthdate.Location = new System.Drawing.Point(270, 105);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(131, 22);
            this.birthdate.TabIndex = 22;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.hRMDBDataSet;
            this.personsBindingSource.CurrentChanged += new System.EventHandler(this.personsBindingSource_CurrentChanged_1);
            // 
            // hRMDBDataSet
            // 
            this.hRMDBDataSet.DataSetName = "HRMDBDataSet";
            this.hRMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // comboBoxGender
            // 
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.personsBindingSource, "Gender", true));
            this.comboBoxGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personsBindingSource, "Gender", true));
            this.comboBoxGender.Enabled = false;
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
            this.txtadr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Adress", true));
            this.txtadr.Enabled = false;
            this.txtadr.Location = new System.Drawing.Point(270, 192);
            this.txtadr.Multiline = true;
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(131, 57);
            this.txtadr.TabIndex = 12;
            // 
            // txtmail
            // 
            this.txtmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Mail", true));
            this.txtmail.Enabled = false;
            this.txtmail.Location = new System.Drawing.Point(270, 161);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(131, 22);
            this.txtmail.TabIndex = 11;
            // 
            // txtnum
            // 
            this.txtnum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Phonenumber", true));
            this.txtnum.Enabled = false;
            this.txtnum.Location = new System.Drawing.Point(270, 133);
            this.txtnum.MaxLength = 10;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(131, 22);
            this.txtnum.TabIndex = 10;
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
            this.txtlname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Lastname", true));
            this.txtlname.Enabled = false;
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
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Evaluation", true));
            this.textBox2.Location = new System.Drawing.Point(17, 323);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 61);
            this.textBox2.TabIndex = 2;
            // 
            // txtfname
            // 
            this.txtfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Firstname", true));
            this.txtfname.Enabled = false;
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
            // dataGridViewdm
            // 
            this.dataGridViewdm.AllowUserToAddRows = false;
            this.dataGridViewdm.AllowUserToDeleteRows = false;
            this.dataGridViewdm.AllowUserToResizeColumns = false;
            this.dataGridViewdm.AutoGenerateColumns = false;
            this.dataGridViewdm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.photoprofileDataGridViewImageColumn,
            this.jobIDDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.evaluationDataGridViewTextBoxColumn});
            this.dataGridViewdm.DataSource = this.personsBindingSource;
            this.dataGridViewdm.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewdm.Name = "dataGridViewdm";
            this.dataGridViewdm.ReadOnly = true;
            this.dataGridViewdm.RowTemplate.Height = 24;
            this.dataGridViewdm.Size = new System.Drawing.Size(344, 403);
            this.dataGridViewdm.TabIndex = 9;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personIDDataGridViewTextBoxColumn.Visible = false;
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
            // photoprofileDataGridViewImageColumn
            // 
            this.photoprofileDataGridViewImageColumn.DataPropertyName = "Photoprofile";
            this.photoprofileDataGridViewImageColumn.HeaderText = "Photoprofile";
            this.photoprofileDataGridViewImageColumn.Name = "photoprofileDataGridViewImageColumn";
            this.photoprofileDataGridViewImageColumn.ReadOnly = true;
            this.photoprofileDataGridViewImageColumn.Visible = false;
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            this.jobIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Visible = false;
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdateDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Visible = false;
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phonenumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // evaluationDataGridViewTextBoxColumn
            // 
            this.evaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.Name = "evaluationDataGridViewTextBoxColumn";
            this.evaluationDataGridViewTextBoxColumn.ReadOnly = true;
            this.evaluationDataGridViewTextBoxColumn.Visible = false;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // dmform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 476);
            this.Controls.Add(this.paneldm);
            this.Name = "dmform";
            this.Text = "dmform";
            this.Load += new System.EventHandler(this.dmform_Load);
            this.paneldm.ResumeLayout(false);
            this.paneldm.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldm;
        private System.Windows.Forms.TextBox Departmentm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGender;
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
        private System.Windows.Forms.DataGridView dataGridViewdm;
        private HRMDBDataSet hRMDBDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private HRMDBDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoprofileDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn;
        private HRMDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.TextBox birthdate;
        private System.Windows.Forms.Button Logout;
    }
}