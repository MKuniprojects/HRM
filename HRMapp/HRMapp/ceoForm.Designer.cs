namespace HRMapp
{
    partial class ceoForm
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
            this.USERS = new System.Windows.Forms.Label();
            this.dataGridViewHRM = new System.Windows.Forms.DataGridView();
            this.updateusr = new System.Windows.Forms.Button();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hRMDBDataSet = new HRMapp.HRMDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new HRMapp.HRMDBDataSetTableAdapters.UsersTableAdapter();
            this.loginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateusr);
            this.panel1.Controls.Add(this.USERS);
            this.panel1.Controls.Add(this.dataGridViewHRM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 560);
            this.panel1.TabIndex = 0;
            // 
            // USERS
            // 
            this.USERS.AutoSize = true;
            this.USERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERS.Location = new System.Drawing.Point(208, 31);
            this.USERS.Name = "USERS";
            this.USERS.Size = new System.Drawing.Size(100, 29);
            this.USERS.TabIndex = 2;
            this.USERS.Text = "USERS";
            this.USERS.Click += new System.EventHandler(this.HRM_Click);
            // 
            // dataGridViewHRM
            // 
            this.dataGridViewHRM.AutoGenerateColumns = false;
            this.dataGridViewHRM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewHRM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHRM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginNameDataGridViewTextBoxColumn,
            this.loginPasswordDataGridViewTextBoxColumn,
            this.professionIDDataGridViewTextBoxColumn,
            this.DpID,
            this.userIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn});
            this.dataGridViewHRM.DataSource = this.usersBindingSource1;
            this.dataGridViewHRM.Location = new System.Drawing.Point(36, 63);
            this.dataGridViewHRM.Name = "dataGridViewHRM";
            this.dataGridViewHRM.RowTemplate.Height = 24;
            this.dataGridViewHRM.Size = new System.Drawing.Size(444, 408);
            this.dataGridViewHRM.TabIndex = 0;
            this.dataGridViewHRM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHRM_CellContentClick);
            // 
            // updateusr
            // 
            this.updateusr.Location = new System.Drawing.Point(36, 503);
            this.updateusr.Name = "updateusr";
            this.updateusr.Size = new System.Drawing.Size(87, 31);
            this.updateusr.TabIndex = 3;
            this.updateusr.Text = "Update";
            this.updateusr.UseVisualStyleBackColor = true;
            this.updateusr.Click += new System.EventHandler(this.updateusr_Click);
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.hRMDBDataSet;
            // 
            // hRMDBDataSet
            // 
            this.hRMDBDataSet.DataSetName = "HRMDBDataSet";
            this.hRMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.hRMDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // loginNameDataGridViewTextBoxColumn
            // 
            this.loginNameDataGridViewTextBoxColumn.DataPropertyName = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.HeaderText = "LoginName";
            this.loginNameDataGridViewTextBoxColumn.Name = "loginNameDataGridViewTextBoxColumn";
            this.loginNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // loginPasswordDataGridViewTextBoxColumn
            // 
            this.loginPasswordDataGridViewTextBoxColumn.DataPropertyName = "LoginPassword";
            this.loginPasswordDataGridViewTextBoxColumn.HeaderText = "LoginPassword";
            this.loginPasswordDataGridViewTextBoxColumn.Name = "loginPasswordDataGridViewTextBoxColumn";
            this.loginPasswordDataGridViewTextBoxColumn.Width = 80;
            // 
            // professionIDDataGridViewTextBoxColumn
            // 
            this.professionIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessionID";
            this.professionIDDataGridViewTextBoxColumn.HeaderText = "ProfessionID";
            this.professionIDDataGridViewTextBoxColumn.Name = "professionIDDataGridViewTextBoxColumn";
            this.professionIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // DpID
            // 
            this.DpID.DataPropertyName = "DpID";
            this.DpID.HeaderText = "DpID";
            this.DpID.Name = "DpID";
            this.DpID.Width = 50;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            this.personIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ceoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 560);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ceoForm";
            this.Text = "ceoForm";
            this.Load += new System.EventHandler(this.ceoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label USERS;
        private HRMDBDataSet hRMDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private HRMDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewHRM;
        private System.Windows.Forms.Button updateusr;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn professionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
    }
}