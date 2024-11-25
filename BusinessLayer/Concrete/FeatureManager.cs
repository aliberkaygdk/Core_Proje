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
    public class FeatureManager : IGenericService<Feature>
    {
        IFeatureDal feature;

        public FeatureManager(IFeatureDal feature)
        {
            this.feature = feature;
        }

        public void TAdd(Feature t)
        {
            feature.Insert(t);
        }

        public void TDelete(Feature t)
        {
            feature.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return feature.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return feature.GetList();
        }

        public void TUpdate(Feature t)
        {
            feature.Update(t);
        }
    }
}
