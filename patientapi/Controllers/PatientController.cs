using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PatientAPI.Models;

namespace patientapi.Controllers
{

      [Route("PatientController")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        PatientDb database;

        public PatientController()
        {
            database = new PatientDb();
        }

        [HttpGet]
        public IActionResult GetAllPatient()
        {
            return Ok(database);
        }
    }
}
