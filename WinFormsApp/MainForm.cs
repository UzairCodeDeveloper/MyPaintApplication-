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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetAllRecords_Click(object sender, EventArgs e)
        {

            PatientForm patientForm = new PatientForm();
            patientForm.currPatient = new Patient();
            
            patientForm.currPatient.PID = PatientDBHelper.GetNextID();

            if (patientForm.ShowDialog() == DialogResult.OK)
            {
                listPatients.Add(patientForm.currPatient);
                dgvPatients.DataSource = null;
                dgvPatients.DataSource = listPatients;

                PatientDBHelper.InsertPatient(patientForm.currPatient);
            }
           

        }

        List<Patient> listPatients = new List<Patient>();   

        private void MainForm_Load(object sender, EventArgs e)
        {
            listPatients = PatientDBHelper.GetPatients();
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.DataSource = listPatients;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            PatientForm patientForm = new PatientForm();
            patientForm.currPatient = (Patient)dgvPatients.SelectedRows[0].DataBoundItem;

          
            if (patientForm.ShowDialog() == DialogResult.OK)
            {
                dgvPatients.DataSource = null;
                dgvPatients.DataSource = listPatients;

                PatientDBHelper.UpdatePatient(patientForm.currPatient);
            }


        }

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                Patient selectedPatient = dgvPatients.SelectedRows[0].DataBoundItem as Patient;
                if (selectedPatient != null)
                {
                    pgPatient.SelectedObject = selectedPatient;
                }
            }

        }

        private void pgPatient_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            dgvPatients.Refresh();
        }
    }
}
