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
    public partial class Form1 : Form
    {

        List<Patient> patients = new List<Patient>();

        int currIndex = 0;
        Patient currPatient;
        public Form1()
        {
            InitializeComponent();


        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            //currPatient = new Patient();
            //currPatient.PID = patients.Count + 1;

            PatientNewRecordForm fnrf = new PatientNewRecordForm();

            //fnrf.Patient = currPatient;
            fnrf.ShowDialog();

            //currPatient = fnrf.Patient;

            //FromDatatoGUI();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PatientDBHelper patientDBHelper = new PatientDBHelper();

            patients.Add(new Patient(1, "Ahmad", DateTime.Now, Gender.Male, "ahmad@gmail.com"));
            patients.Add(new Patient(2, "Sara", DateTime.Now, Gender.Female, "sara@gmail.com"));
            patients.Add(new Patient(3, "Usman", DateTime.Now, Gender.Male, "usman@gmail.com"));
            patients.Add(new Patient(4, "Saleem", DateTime.Now, Gender.Male, "saleem@gmail.com"));

            currPatient = patients[currIndex];

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
            if (currIndex < patients.Count -1)
            {
                currIndex++;
                currPatient = patients[currIndex];
                FromDatatoGUI();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currIndex > 0)
            {
                currIndex--;
                currPatient = patients[currIndex];
                FromDatatoGUI();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FromGUItoData();
            patients.Add(currPatient);
            currIndex = patients.IndexOf(currPatient);
        }
    }
}
