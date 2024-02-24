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

    
    public partial class PatientNewRecordForm : Form
    {
        List<Patient> patients = new List<Patient>();

        public PatientNewRecordForm()
        {
            InitializeComponent();


            patients.Add(new Patient(1, "Ahmad", DateTime.Now, Gender.Male, "ahmad@gmail.com"));
            patients.Add(new Patient(2, "Sara", DateTime.Now, Gender.Female, "sara@gmail.com"));
            patients.Add(new Patient(3, "Usman", DateTime.Now, Gender.Male, "usman@gmail.com"));
            patients.Add(new Patient(4, "Saleem", DateTime.Now, Gender.Male, "saleem@gmail.com"));


            patientBindingSource.DataSource = patients;
        }

        private void PatientNewRecordForm_Load(object sender, EventArgs e)
        {

        }

        private void PatientNewRecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
    }
}
