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
            this.dmpanel = new System.Windows.Forms.Panel();
            this.paneldm = new System.Windows.Forms.Panel();
            this.updatedm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickern1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxnGender = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnadr = new System.Windows.Forms.TextBox();
            this.txtnmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnlname = new System.Windows.Forms.TextBox();
            this.txtEval = new System.Windows.Forms.TextBox();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDBDataSet = new HRMapp.HRMDBDataSet();
            this.txtnfname = new System.Windows.Forms.TextBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.dataGridViewdm = new System.Windows.Forms.DataGridView();
            this.Departmentm = new System.Windows.Forms.TextBox();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoprofileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.jobIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personsTableAdapter1 = new HRMapp.HRMDBDataSetTableAdapters.PersonsTableAdapter();
            this.dmpanel.SuspendLayout();
            this.paneldm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdm)).BeginInit();
            this.SuspendLayout();
            // 
            // dmpanel
            // 
            this.dmpanel.Controls.Add(this.paneldm);
            this.dmpanel.Controls.Add(this.dataGridViewdm);
            this.dmpanel.Controls.Add(this.Departmentm);
            this.dmpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dmpanel.Location = new System.Drawing.Point(0, 0);
            this.dmpanel.Name = "dmpanel";
            this.dmpanel.Size = new System.Drawing.Size(983, 514);
            this.dmpanel.TabIndex = 0;
            // 
            // paneldm
            // 
            this.paneldm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paneldm.Controls.Add(this.updatedm);
            this.paneldm.Controls.Add(this.label7);
            this.paneldm.Controls.Add(this.textBoxPhoneNumber);
            this.paneldm.Controls.Add(this.dateTimePickern1);
            this.paneldm.Controls.Add(this.comboBoxnGender);
            this.paneldm.Controls.Add(this.label6);
            this.paneldm.Controls.Add(this.label5);
            this.paneldm.Controls.Add(this.label4);
            this.paneldm.Controls.Add(this.label2);
            this.paneldm.Controls.Add(this.txtnadr);
            this.paneldm.Controls.Add(this.txtnmail);
            this.paneldm.Controls.Add(this.label3);
            this.paneldm.Controls.Add(this.Lastname);
            this.paneldm.Controls.Add(this.label1);
            this.paneldm.Controls.Add(this.txtnlname);
            this.paneldm.Controls.Add(this.txtEval);
            this.paneldm.Controls.Add(this.txtnfname);
            this.paneldm.Controls.Add(this.profile);
            this.paneldm.Location = new System.Drawing.Point(535, 67);
            this.paneldm.Name = "paneldm";
            this.paneldm.Size = new System.Drawing.Size(417, 408);
            this.paneldm.TabIndex = 10;
            // 
            // updatedm
            // 
            this.updatedm.Location = new System.Drawing.Point(270, 255);
            this.updatedm.Name = "updatedm";
            this.updatedm.Size = new System.Drawing.Size(131, 37);
            this.updatedm.TabIndex = 21;
            this.updatedm.Text = "Update";
            this.updatedm.UseVisualStyleBackColor = true;
            this.updatedm.Click += new System.EventHandler(this.updatedm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "ΑΞΙΟΛΟΓΗΣΗ";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Phonenumber", true));
            this.textBoxPhoneNumber.Enabled = false;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(270, 134);
            this.textBoxPhoneNumber.MaxLength = 10;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(131, 22);
            this.textBoxPhoneNumber.TabIndex = 19;
            // 
            // dateTimePickern1
            // 
            this.dateTimePickern1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickern1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickern1.Enabled = false;
            this.dateTimePickern1.Location = new System.Drawing.Point(270, 105);
            this.dateTimePickern1.Name = "dateTimePickern1";
            this.dateTimePickern1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickern1.TabIndex = 18;
            this.dateTimePickern1.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            // 
            // comboBoxnGender
            // 
            this.comboBoxnGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.personsBindingSource, "Gender", true));
            this.comboBoxnGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personsBindingSource, "Gender", true));
            this.comboBoxnGender.Enabled = false;
            this.comboBoxnGender.FormattingEnabled = true;
            this.comboBoxnGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Ginger",
            "Trans",
            "No Gender fuck off",
            "duck"});
            this.comboBoxnGender.Location = new System.Drawing.Point(270, 77);
            this.comboBoxnGender.Name = "comboBoxnGender";
            this.comboBoxnGender.Size = new System.Drawing.Size(131, 24);
            this.comboBoxnGender.TabIndex = 7;
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
            // txtnadr
            // 
            this.txtnadr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Adress", true));
            this.txtnadr.Enabled = false;
            this.txtnadr.Location = new System.Drawing.Point(270, 192);
            this.txtnadr.Multiline = true;
            this.txtnadr.Name = "txtnadr";
            this.txtnadr.Size = new System.Drawing.Size(131, 57);
            this.txtnadr.TabIndex = 12;
            // 
            // txtnmail
            // 
            this.txtnmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Mail", true));
            this.txtnmail.Enabled = false;
            this.txtnmail.Location = new System.Drawing.Point(270, 161);
            this.txtnmail.Name = "txtnmail";
            this.txtnmail.Size = new System.Drawing.Size(131, 22);
            this.txtnmail.TabIndex = 11;
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
            // txtnlname
            // 
            this.txtnlname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Lastname", true));
            this.txtnlname.Enabled = false;
            this.txtnlname.Location = new System.Drawing.Point(270, 51);
            this.txtnlname.Name = "txtnlname";
            this.txtnlname.Size = new System.Drawing.Size(131, 22);
            this.txtnlname.TabIndex = 4;
            // 
            // txtEval
            // 
            this.txtEval.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Evaluation", true));
            this.txtEval.Location = new System.Drawing.Point(17, 315);
            this.txtEval.Multiline = true;
            this.txtEval.Name = "txtEval";
            this.txtEval.Size = new System.Drawing.Size(384, 76);
            this.txtEval.TabIndex = 2;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.hRMDBDataSet;
            // 
            // hRMDBDataSet
            // 
            this.hRMDBDataSet.DataSetName = "HRMDBDataSet";
            this.hRMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtnfname
            // 
            this.txtnfname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Firstname", true));
            this.txtnfname.Enabled = false;
            this.txtnfname.Location = new System.Drawing.Point(270, 23);
            this.txtnfname.Name = "txtnfname";
            this.txtnfname.Size = new System.Drawing.Size(131, 22);
            this.txtnfname.TabIndex = 1;
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
            this.dataGridViewdm.AutoGenerateColumns = false;
            this.dataGridViewdm.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
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
            this.dataGridViewdm.Location = new System.Drawing.Point(12, 67);
            this.dataGridViewdm.Name = "dataGridViewdm";
            this.dataGridViewdm.RowTemplate.Height = 24;
            this.dataGridViewdm.Size = new System.Drawing.Size(385, 408);
            this.dataGridViewdm.TabIndex = 9;
            // 
            // Departmentm
            // 
            this.Departmentm.Enabled = false;
            this.Departmentm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departmentm.Location = new System.Drawing.Point(12, 12);
            this.Departmentm.Name = "Departmentm";
            this.Departmentm.Size = new System.Drawing.Size(208, 34);
            this.Departmentm.TabIndex = 8;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // photoprofileDataGridViewImageColumn
            // 
            this.photoprofileDataGridViewImageColumn.DataPropertyName = "Photoprofile";
            this.photoprofileDataGridViewImageColumn.HeaderText = "Photoprofile";
            this.photoprofileDataGridViewImageColumn.Name = "photoprofileDataGridViewImageColumn";
            // 
            // jobIDDataGridViewTextBoxColumn
            // 
            this.jobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID";
            this.jobIDDataGridViewTextBoxColumn.HeaderText = "JobID";
            this.jobIDDataGridViewTextBoxColumn.Name = "jobIDDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "Phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // evaluationDataGridViewTextBoxColumn
            // 
            this.evaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.Name = "evaluationDataGridViewTextBoxColumn";
            // 
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // dmform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 514);
            this.Controls.Add(this.dmpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "dmform";
            this.Text = "dmform";
            this.Load += new System.EventHandler(this.dmform_Load);
            this.dmpanel.ResumeLayout(false);
            this.dmpanel.PerformLayout();
            this.paneldm.ResumeLayout(false);
            this.paneldm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dmpanel;
        private System.Windows.Forms.TextBox Departmentm;
        private System.Windows.Forms.DataGridView dataGridViewdm;
        private System.Windows.Forms.Panel paneldm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.DateTimePicker dateTimePickern1;
        private System.Windows.Forms.ComboBox comboBoxnGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnadr;
        private System.Windows.Forms.TextBox txtnmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnlname;
        private System.Windows.Forms.TextBox txtEval;
        private System.Windows.Forms.TextBox txtnfname;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Button updatedm;
        private HRMDBDataSet hRMDBDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoprofileDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn;
        private HRMDBDataSetTableAdapters.PersonsTableAdapter personsTableAdapter1;
    }
}