using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaukriWebApp.Models;

namespace NaukriWebApp.Domain
{
    public class SkillDomain : BaseDomain
    {
        public void Add(Skill skill)
        {
            this.ExecuteNonQuery($"insert into Skills (SkillName,UserId) values('{skill.SkillName}',{skill.UserId})");
        }

        public List<Skill> Get(int SkillId)
        {
            var reader = this.GetReader($"select * from Skills where SkillId = {SkillId}");
            var skills = new List<Skill>();
            while (reader.Read())
            {
                var skill = new Skill();
                skill.SkillName= reader.GetString(1);
                skill.UserId = reader.GetInt64(2);
                skills.Add(skill);
            }
            return skills;
        }
    }
}
