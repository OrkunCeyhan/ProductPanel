using BuisnessLayer.Concrete;
using BuisnessLayer.FluentValidation;
using DataAccessLayer.EntitiyFramework;
using EntitiyLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Demo_ProductV2.Controllers
{
    [AllowAnonymous]
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomersListWithJob();
            return View(values);
        }
        [HttpGet]
        //public IActionResult AddCustomer()
        //{
        //    ////JobManager jobManager = new JobManager(new EfJobDal());
        //    ////List<SelectListItem> values = (from x in /*jobManager.TGetList*/()
        //    ////                               select new SelectListItem
        //    ////                               {
        //    ////                                   Text = x.Name,
        //    ////                                   Value = x.JobID.ToString()
        //    ////                               }).ToList();
        //    //ViewBag.v = values;
        //    //return View();
        //}
        [HttpPost]
        public IActionResult AddCustomer(Customer p)
        {
            CustomerValidatior validatorRules = new CustomerValidatior();
            ValidationResult results = validatorRules.Validate(p);
            if (results.IsValid)
            {

                customerManager.TInsert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();



        }
        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            return View(value);
        }
        [HttpPost]

        public IActionResult UpdateCustomer(Customer p)
        {
            customerManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
