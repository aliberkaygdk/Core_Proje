﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void TAdd(About t)
        {
            aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            aboutDal.Delete(t);
        }

        public About TGetById(int id)
        {
            return aboutDal.GetByID(id);
        }

        public List<About> TGetList()
        {
            return aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            aboutDal.Update(t);
        }
    }
}
