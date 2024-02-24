using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class PatientForm : Form
    {
         public Patient currPatient { get; set; }
        public PatientForm()
        {
            InitializeComponent();


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FromDatatoGUI();
        }

        void FromDatatoGUI()
        {
            txtID.Text = currPatient.PID.ToString();
            txtName.Text = currPatient.Name;
            cmbGender.SelectedIndex = (int) currPatient.Gender;
            dtpDoB.Value = currPatient.DoB;
            txtEmail.Text = currPatient.Email;

        }

        void FromGUItoData()
        {
            currPatient.PID = long.Parse(txtID.Text);
            currPatient.Name = txtName.Text;
            currPatient.Gender = (Gender)cmbGender.SelectedIndex;
            currPatient.DoB = dtpDoB.Value;
            currPatient.Email = txtEmail.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();

        }

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            FromGUItoData();
            DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
