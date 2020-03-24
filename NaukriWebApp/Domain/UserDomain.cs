using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;

namespace NaukriWebApp.Domain
{
    public class UserDomain : BaseDomain
    {
        public bool IsLogin(User user)
        {
            var reader = this.GetReader($"select * from Users where EmailId = '{user.EmailId}' and Password = '{user.Password}'");
            var isLoggedIn = false;
            while (reader.Read())
            {
                isLoggedIn = true;
            }
            return isLoggedIn;
        }
    }
}
