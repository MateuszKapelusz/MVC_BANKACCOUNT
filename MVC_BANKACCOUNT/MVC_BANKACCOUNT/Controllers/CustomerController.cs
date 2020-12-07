using MVC_BANKACCOUNT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace MVC_BANKACCOUNT.Controllers
{
    public class CustomerController : Controller
    {
	    [RequireHttps]
        // GET: Customer
        public ActionResult Random()
        {
            var Customer = new Customers(){CustomerID = 1, Name = "Mateusz", SureName = "Jarząbek", PhoneNo = 781021059, Address = "Piłsudskiego",PersonalID = 12345678912};
            
            return View(Customer);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
	        return Content(year + "/" + month);
        }

        /*public int CustomerID { get; set;}
		public string Name { get; set; }
		public string SureName{ get; set; }
		public long PhoneNo { get; set; }
		public string Address { get; set; }
		public long PersonalID { get; set; } */
    }
}