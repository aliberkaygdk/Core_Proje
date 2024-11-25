using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal skill;

        public SkillManager(ISkillDal skill)
        {
            this.skill = skill;
        }

        public void TAdd(Skill t)
        {
            skill.Insert(t);
        }

        public void TDelete(Skill t)
        {
            skill.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return skill.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return skill.GetList();
        }

        public void TUpdate(Skill t)
        {
            skill.Update(t);
        }
    }
}
