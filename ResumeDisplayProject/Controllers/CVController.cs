using Microsoft.AspNetCore.Mvc;
using ResumeDisplayProject.Models;

namespace ResumeDisplayProject.Controllers
{
    public class CvController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Experience()
        {
            return View();
        }

        public ActionResult Skills()
        {
            return View();
        }

        // GET: /Cv/TaxCalculator
        [HttpGet]
        public ActionResult TaxCalculator()
        {
            // Return the view for the tax calculator
            var model = new TaxViewModel();
            return View(model);
        }

        // POST: /Cv/CalculateTax
        [HttpPost]
        public ActionResult CalculateTax(TaxViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Income > 0)
                {
                    model.Tax = CalculateTaxBasedOnIncome(model.Income);
                }
            }
            return View("TaxCalculator", model);
        }

        private decimal CalculateTaxBasedOnIncome(decimal income)
        {
            if (income <= 50000)
                return income * 0.1m;
            else if (income <= 100000)
                return income * 0.2m;
            else
                return income * 0.3m;
        }


    }

}
