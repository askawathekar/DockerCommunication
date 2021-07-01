using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientAPI.Models
{
  
    public class Patient
    {
        public int PatientID { get; set; }
        public string PatientName { get; set; }
    }



    public class PatientDb : List<Patient>
    {
        public PatientDb()
        {
            Add(new Patient() { PatientID = 11, PatientName = "Mayur" });
            Add(new Patient() { PatientID = 12, PatientName = "Aditya" });
        }
    }
}
