using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro.Controllers
{
    public class SessionDemoController : Controller
    {
        
        public string Index1()
        {
            Customer customer = new Customer { Id = 27, FirstName = "Vincent", LastName = "Aboubakar", City = "İstanbul" };

            HttpContext.Session.SetString("isim", "Furkan");
            HttpContext.Session.SetObject("musteri", customer);
            return "Session oluştu";
        }

        public string Index2()
        {
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.LastName;
        }
    }
}
