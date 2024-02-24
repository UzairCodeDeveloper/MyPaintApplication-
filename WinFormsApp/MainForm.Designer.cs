namespace WinFormsApp
{
    partial class MainForm
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.colPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetAllRecords = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pgPatient = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPID,
            this.colName,
            this.colGender});
            this.dgvPatients.Location = new System.Drawing.Point(38, 26);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersWidth = 62;
            this.dgvPatients.RowTemplate.Height = 28;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(515, 376);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // colPID
            // 
            this.colPID.DataPropertyName = "PID";
            this.colPID.HeaderText = "ID";
            this.colPID.MinimumWidth = 8;
            this.colPID.Name = "colPID";
            this.colPID.ReadOnly = true;
            this.colPID.Width = 70;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 180;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 80;
            // 
            // btnGetAllRecords
            // 
            this.btnGetAllRecords.Location = new System.Drawing.Point(587, 32);
            this.btnGetAllRecords.Name = "btnGetAllRecords";
            this.btnGetAllRecords.Size = new System.Drawing.Size(151, 55);
            this.btnGetAllRecords.TabIndex = 1;
            this.btnGetAllRecords.Text = "Add Patient";
            this.btnGetAllRecords.UseVisualStyleBackColor = true;
            this.btnGetAllRecords.Click += new System.EventHandler(this.btnGetAllRecords_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(587, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pgPatient
            // 
            this.pgPatient.Dock = System.Windows.Forms.DockStyle.Right;
            this.pgPatient.Location = new System.Drawing.Point(777, 0);
            this.pgPatient.Name = "pgPatient";
            this.pgPatient.Size = new System.Drawing.Size(257, 450);
            this.pgPatient.TabIndex = 2;
            this.pgPatient.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgPatient_PropertyValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.pgPatient);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetAllRecords);
            this.Controls.Add(this.dgvPatients);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnGetAllRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PropertyGrid pgPatient;
    }
}