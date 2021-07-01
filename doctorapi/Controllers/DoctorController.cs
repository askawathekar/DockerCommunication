using DoctorAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorAPI.Controllers
{
   

    [Route("DoctorController")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        DoctorDb database;

        public DoctorController()
        {
            database = new DoctorDb();
        }

        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            return Ok(database);
        }
    }
}
