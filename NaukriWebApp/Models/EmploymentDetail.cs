using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriWebApp.Models
{
    public class EmploymentDetail
    {
        public double EmploymentId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public int Lakhs { get; set; }
        public int Thousands { get; set; }
        public int JoinYear { get; set; }
        public string JoinMonth { get; set; }
        public int PresentYear { get; set; }
        public string PresentMonth { get; set; }
        public string City { get; set; }
        public string NoticePeriod { get; set; }
        public string Industry { get; set; }
        public string FuctionalArea { get; set; }
        public string Role { get; set; }
        public double UserId { get; set; }
    }
}
