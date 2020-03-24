using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;
using NaukriWebApp.Domain;
using Microsoft.AspNetCore.Mvc;

namespace NaukriWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmploymentDetailsController : ControllerBase
    {
        public EmploymentDetailsController()
        {
            this.EmploymentDetailsDomain = new EmploymentDetailsDomain();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var employmentdetails = this.EmploymentDetailsDomain.Get(id);
            return Ok(employmentdetails);
        }

        [HttpPost]
        public IActionResult Post(EmploymentDetail employmentDetail)
        {
            this.EmploymentDetailsDomain.Add(employmentDetail);
            return Ok();
        }

        private EmploymentDetailsDomain EmploymentDetailsDomain { get; set; }
    }
}
