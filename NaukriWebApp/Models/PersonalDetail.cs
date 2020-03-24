using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriWebApp.Models
{
    public class PersonalDetail
    {
        public double PersonalId { get; set; }
        public string MobileNumber { get; set; }
        public byte Resume { get; set; }
        public double UserId { get; set; }
        public int YearExperience { get; set; }
        public int MonthExperience { get; set; }
    }
}
