using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaukriWebApp.Models
{
    public class User
    {
        public double UserId { get; set; }
        public string UserName { get; set; }
        public byte UserType { get; set; }
        public string UserTypeName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

    }
}
