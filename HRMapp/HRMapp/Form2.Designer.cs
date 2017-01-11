namespace HRMapp
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickern1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxnGender = new System.Windows.Forms.ComboBox();
            this.brs = new System.Windows.Forms.Button();
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
            this.save = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtnfname = new System.Windows.Forms.TextBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.personsTableAdapter1 = new HRMapp.HRMDBDataSetTableAdapters.PersonsTableAdapter();
            this.hrmdbDataSet1 = new HRMapp.HRMDBDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.test = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.test);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxPhoneNumber);
            this.panel2.Controls.Add(this.dateTimePickern1);
            this.panel2.Controls.Add(this.comboBoxnGender);
            this.panel2.Controls.Add(this.brs);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtnadr);
            this.panel2.Controls.Add(this.txtnmail);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Lastname);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtnlname);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.txtnfname);
            this.panel2.Controls.Add(this.profile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 404);
            this.panel2.TabIndex = 5;
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
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(270, 134);
            this.textBoxPhoneNumber.MaxLength = 10;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(131, 22);
            this.textBoxPhoneNumber.TabIndex = 19;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // dateTimePickern1
            // 
            this.dateTimePickern1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickern1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickern1.Location = new System.Drawing.Point(270, 105);
            this.dateTimePickern1.Name = "dateTimePickern1";
            this.dateTimePickern1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePickern1.TabIndex = 18;
            this.dateTimePickern1.Value = new System.DateTime(2017, 2, 4, 0, 0, 0, 0);
            // 
            // comboBoxnGender
            // 
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
            // txtnadr
            // 
            this.txtnadr.Location = new System.Drawing.Point(270, 192);
            this.txtnadr.Multiline = true;
            this.txtnadr.Name = "txtnadr";
            this.txtnadr.Size = new System.Drawing.Size(131, 57);
            this.txtnadr.TabIndex = 12;
            // 
            // txtnmail
            // 
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
            this.txtnlname.Location = new System.Drawing.Point(270, 51);
            this.txtnlname.Name = "txtnlname";
            this.txtnlname.Size = new System.Drawing.Size(131, 22);
            this.txtnlname.TabIndex = 4;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(270, 265);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(131, 37);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(17, 315);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(384, 76);
            this.textBox2.TabIndex = 2;
            // 
            // txtnfname
            // 
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
            // personsTableAdapter1
            // 
            this.personsTableAdapter1.ClearBeforeFill = true;
            // 
            // hrmdbDataSet1
            // 
            this.hrmdbDataSet1.DataSetName = "HRMDBDataSet";
            this.hrmdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(195, 280);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(49, 22);
            this.test.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 404);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hrmdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickern1;
        private System.Windows.Forms.ComboBox comboBoxnGender;
        private System.Windows.Forms.Button brs;
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
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtnfname;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label7;
        private HRMDBDataSetTableAdapters.PersonsTableAdapter personsTableAdapter1;
        private HRMDBDataSet hrmdbDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox test;
    }
}