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
    public class EducationDetailsController : ControllerBase
    {
        public EducationDetailsController()
        {
            this.EducationDetailDomain = new EducationDetailDomain();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var educationdetails = this.EducationDetailDomain.Get(id);
            return Ok(educationdetails);
        }

        [HttpPost]
        public IActionResult Post(EducationDetail educationDetail)
        {
            this.EducationDetailDomain.Add(educationDetail);
            return Ok();
        }

        private EducationDetailDomain EducationDetailDomain { get; set; }
    }
}
