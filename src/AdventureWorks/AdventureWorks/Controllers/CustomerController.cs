using AdventureWorks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdventureWorks.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepo { get; set; }

        public CustomerController()
        {
            // init dapper repo direct for now
            this._customerRepo = new DapperCustomerRepository();
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View(this._customerRepo.GetCustomers());
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View(this._customerRepo.GetCustomer(id));
        }
    }
}
