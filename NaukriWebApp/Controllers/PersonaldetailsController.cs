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
    public class PersonaldetailsController : ControllerBase
    {
        public PersonaldetailsController()
        {
            this.PersonalDetailsDomain = new PersonalDetailsDomain();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var personaldetails = this.PersonalDetailsDomain.Get(id);
            return Ok(personaldetails);
        }

        [HttpPost]
        public IActionResult Post(PersonalDetail personalDetail)
        {
            this.PersonalDetailsDomain.Add(personalDetail);
            return Ok();
        }

        private PersonalDetailsDomain PersonalDetailsDomain { get; set; }
    }
}
