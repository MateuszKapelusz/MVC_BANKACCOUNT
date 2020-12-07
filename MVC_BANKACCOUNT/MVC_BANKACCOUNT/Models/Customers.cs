using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_BANKACCOUNT.Models
{
	public class Customers
	{

		public int CustomerID { get; set;}
		public string Name { get; set; }
		public string SureName{ get; set; }
		public long PhoneNo { get; set; }
		public string Address { get; set; }
		public long PersonalID { get; set; }

		
	}
}