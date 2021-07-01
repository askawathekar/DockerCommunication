using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAPP.Models
{
    public class Hospital
    {
        public class Patient
        {
            public int PatientID { get; set; }
            public string PatientName { get; set; }
        }
        public class Doctor
        {
            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
        }
    }
}
