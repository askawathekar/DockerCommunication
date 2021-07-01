using ClientAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        string patienturl = "http://localhost:35750/";
        string Doctorurl = "http://localhost:34535/";
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            ////var result = await client.GetStringAsync("http://servhost/api/Test");
            var result = await client.GetStringAsync("http://localhost:35750/PatientController");
            //ViewBag.Response = result;

            return View();
        }
        public async Task<IActionResult> Patient()
        {
            List<Hospital.Patient> PatientInfo = new List<Hospital.Patient>();
            using (var client = new HttpClient())
            {
               
                client.BaseAddress = new Uri(patienturl);
                client.DefaultRequestHeaders.Clear();
              
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
               
               HttpResponseMessage Res = await client.GetAsync("PatientController");
                var PatientList = await client.GetAsync("PatientController");

                if (Res.IsSuccessStatusCode)
                {

                    var PatientResponse = Res.Content.ReadAsStringAsync().Result;

                    PatientInfo = JsonConvert.DeserializeObject<List<Hospital.Patient>>(PatientResponse);
                }
                // ViewBag.PatientList = PatientList;


                return View(PatientInfo);
            }
        }
        public async Task<IActionResult> Doctor()
        {
            List<Hospital.Doctor> DoctorInfo = new List<Hospital.Doctor>();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Doctorurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

               HttpResponseMessage Res = await client.GetAsync("DoctorController");
                var DoctorList = await client.GetAsync("DoctorController");

                if (Res.IsSuccessStatusCode)
                {

                    var DoctorResponse = Res.Content.ReadAsStringAsync().Result;

                    DoctorInfo = JsonConvert.DeserializeObject<List<Hospital.Doctor>>(DoctorResponse);
                }
                // ViewBag.PatientList = PatientList;


                return View(DoctorInfo);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
