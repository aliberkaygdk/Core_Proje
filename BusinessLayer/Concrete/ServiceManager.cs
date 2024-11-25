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
    public class ServiceManager : IGenericService<Service>
    {
        IServiceDal service;

        public ServiceManager(IServiceDal service)
        {
            this.service = service;
        }

        public void TAdd(Service t)
        {
            service.Insert(t);
        }

        public void TDelete(Service t)
        {
            service.Delete(t);
        }

        public Service TGetById(int id)
        {
            return service.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return service.GetList();
        }

        public void TUpdate(Service t)
        {
            service.Update(t);
        }
    }
}
