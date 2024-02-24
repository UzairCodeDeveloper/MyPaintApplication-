using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Patient
    {
        public long PID { get; set; }

        [Category("Profile")]
        public string Name { get; set; }    
        public DateTime DoB {  get; set; }

        public Gender Gender { get; set; }

        public string Email {  get; set; }

        public Patient() {

            this.PID = 0;
            this.Name = "No Name";
            this.DoB = DateTime.Now;
            this.Email = string.Empty;

        }

        public Patient(long pID, string name, DateTime doB, Gender gender, string email)
        {
            PID = pID;
            Name = name;
            DoB = doB;
            Gender = gender;
            Email = email;
        }

        public override string ToString()
        {
            return Name + " (" + PID + ")";
        }
    }
}
