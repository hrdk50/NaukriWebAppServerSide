using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;

namespace NaukriWebApp.Domain
{
    public class EmploymentDetailsDomain : BaseDomain
    {
        
        public void Add(EmploymentDetail employmentDetail)
        {
            this.ExecuteNonQuery($"insert into EmploymentDetails (JobTitle,CompanyName,Lakhs,Thousands,JoinYear,JoinMonth,PresentYear,PresentMonth,City,NoticePeriod,Industry,FuctionalArea,Role,UserId) values('{employmentDetail.JobTitle}','{employmentDetail.CompanyName}',{employmentDetail.Lakhs},{employmentDetail.Thousands},{employmentDetail.JoinYear},'{employmentDetail.JoinMonth}',{employmentDetail.PresentYear},'{employmentDetail.PresentMonth}','{employmentDetail.City}','{employmentDetail.NoticePeriod}','{employmentDetail.Industry}','{employmentDetail.FuctionalArea}','{employmentDetail.Role}',{employmentDetail.UserId})");
        }

        public List<EmploymentDetail> Get(int EmploymentId)
        {
            var reader = this.GetReader($"select * from EmploymentDetails where EmploymentId = {EmploymentId}");
            var employmentdetails = new List<EmploymentDetail>();
            while (reader.Read())
            {
                var employmentdetail = new EmploymentDetail();
                employmentdetail.JobTitle = reader.GetString(1);
                employmentdetail.CompanyName = reader.GetString(2);
                employmentdetail.Lakhs = reader.GetInt32(3);
                employmentdetail.Thousands = reader.GetInt32(4);
                employmentdetail.JoinYear = reader.GetInt32(5);
                employmentdetail.JoinMonth = reader.GetString(6);
                employmentdetail.PresentYear = reader.GetInt32(7);
                employmentdetail.PresentMonth = reader.GetString(8);
                employmentdetail.City = reader.GetString(9);
                employmentdetail.NoticePeriod = reader.GetString(10);
                employmentdetail.Industry = reader.GetString(11);
                employmentdetail.FuctionalArea = reader.GetString(12);
                employmentdetail.Role = reader.GetString(13);
                employmentdetail.UserId = reader.GetInt64(14);
                employmentdetails.Add(employmentdetail);
            }
            return employmentdetails;
        }
    }
}

