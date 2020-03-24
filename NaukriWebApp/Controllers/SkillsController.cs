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
    public class SkillsController : ControllerBase
    {
        public SkillsController()
        {
            this.SkillDomain = new SkillDomain();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var skills = this.SkillDomain.Get(id);
            return Ok(skills);
        }

        [HttpPost]
        public IActionResult Post(Skill skill)
        {
            this.SkillDomain.Add(skill);
            return Ok();
        }

        private SkillDomain SkillDomain { get; set; }
    }
}
