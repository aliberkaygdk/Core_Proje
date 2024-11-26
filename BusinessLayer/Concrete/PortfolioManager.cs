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
    public class PortfolioManager : IPortfolioService
    {
        IPortfolioDal portfolioDal;

        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            this.portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetList()
        {
            return portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
