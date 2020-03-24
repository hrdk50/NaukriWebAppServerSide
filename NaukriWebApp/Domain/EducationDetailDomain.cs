using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;


namespace NaukriWebApp.Domain
{
    public class EducationDetailDomain : BaseDomain
    {
        public void Add(EducationDetail educationDetail)
        {
            this.ExecuteNonQuery($"insert into EducationDetails (Qualification,Course,Specialization,CollegeName,CourseType,PassingYear,UserId) values('{educationDetail.Qualification}','{educationDetail.Course}','{educationDetail.Specialization}','{educationDetail.CollegeName}','{educationDetail.CourseType}',{educationDetail.PassingYear},{educationDetail.UserId})");
        }

        public List<EducationDetail> Get(int EducationId)
        {
            var reader = this.GetReader($"select * from EducationDetails where EducationId = {EducationId}");
            var educationdetails = new List<EducationDetail>();
            while (reader.Read())
            {
                var educationdetail = new EducationDetail();
                educationdetail.Qualification = reader.GetString(1);
                educationdetail.Course = reader.GetString(2);
                educationdetail.Specialization = reader.GetString(3);
                educationdetail.CollegeName = reader.GetString(4);
                educationdetail.CourseType = reader.GetString(5);
                educationdetail.PassingYear = reader.GetInt32(6);
                educationdetail.UserId = reader.GetInt64(7);
                educationdetails.Add(educationdetail);
            }
            return educationdetails;
        }
    }
}
