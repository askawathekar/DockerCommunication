using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAPI.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
    }



    public class DoctorDb : List<Doctor>
    {
        public DoctorDb()
        {
            Add(new Doctor() { DoctorID = 101, DoctorName = "Dr.Amol" });
            Add(new Doctor() { DoctorID = 102, DoctorName = "Dr. Nishi" });
        }
    }
}
