using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriWebApp.Models
{
    public class EducationDetail
    {
        public double EducationId { get; set; }
        public string Qualification { get; set; }
        public string Course { get; set; }
        public string Specialization { get; set; }
        public string CollegeName { get; set; }
        public string CourseType { get; set; }
        public int PassingYear { get; set; }
        public double UserId { get; set; }
    }
}
