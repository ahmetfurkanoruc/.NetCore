using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreIntro.Controllers
{
    [Route("deneme")]
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

       [Route("index")]
       [Route("")]
       [Route("~/anasayfa")]
        public IActionResult Index3()
        {
            _logger.Log("");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id = 1,FirstName = "Furkan",LastName = "Oruç",City = "Ankara"},
                new Customer{Id = 2,FirstName = "Furkan2",LastName = "Oruç",City = "Ankara"},
                new Customer{Id = 3,FirstName = "Furkan3",LastName = "Oruç",City = "Ankara"}
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }
        [HttpPost]
        [Route("save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";
        }

        [HttpGet]
        [Route("save")]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel() 
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Ankara", Value="06"},
                    new SelectListItem{Text = "İstanbul", Value="34"},
                    new SelectListItem{Text = "İzmir", Value="35"}
                }
                
            });
        }
    }
}
