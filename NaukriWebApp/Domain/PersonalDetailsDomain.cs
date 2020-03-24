using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;

namespace NaukriWebApp.Domain
{
    public class PersonalDetailsDomain : BaseDomain
    {
        public void Add(PersonalDetail personalDetail)
        {
            this.ExecuteNonQuery($"insert into PersonalDetails (MobileNumber,Resume,UserId,YearExperience,MonthExperience) values('{personalDetail.MobileNumber}',{personalDetail.Resume},{personalDetail.UserId},{personalDetail.YearExperience},{personalDetail.MonthExperience})");
        }

        public List<PersonalDetail> Get(int PersonalId)
        {
            var reader = this.GetReader($"select * from PersonalDetails where PersonalId = {PersonalId}");
            var personaldetails = new List<PersonalDetail>();
            while (reader.Read())
            {
                var personaldetail = new PersonalDetail();
                personaldetail.MobileNumber = reader.GetString(1);
               // personaldetail.Resume = reader.GetByte(2);
                personaldetail.UserId = reader.GetInt64(3);
                personaldetail.YearExperience = reader.GetInt32(4);
                personaldetail.MonthExperience = reader.GetInt32(5);
                personaldetails.Add(personaldetail);
            }
            return personaldetails;
        }

    }
}
