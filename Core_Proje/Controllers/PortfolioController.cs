using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolio());
        public IActionResult Index()
        {
            var values = portfolioManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(Portfolio p)
        {
            portfolioManager.TAdd(p);
            return RedirectToAction("Index");
        }

        //public IActionResult DeletePortfolio(int id)
        //{
        //    var values = portfolioManager.TGetByID(id);
        //    portfolioManager.TDelete(values);
        //    return RedirectToAction("Index");
        //}
        //public IActionResult EditPortfolio(int id)
        //{
        //    var values = portfolioManager.TGetByID(id);
        //    return View(values);
        //}
        //[HttpPost]
        //public IActionResult EditPortfolio(Portfolio portfolio)
        //{
        //    PortfolioValidator validations = new PortfolioValidator();
        //    ValidationResult results = validations.Validate(portfolio);
        //    if (results.IsValid)
        //    {
        //        portfolioManager.TUpdate(portfolio);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        foreach (var item in results.Errors)
        //        {
        //            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
        //        }
        //    }
        //    return View();
        //}
    }
}
