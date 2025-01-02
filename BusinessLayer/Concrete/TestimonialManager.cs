using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            this.testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            testimonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
            return testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            testimonialDal.Update(t);
        }
    }
}
