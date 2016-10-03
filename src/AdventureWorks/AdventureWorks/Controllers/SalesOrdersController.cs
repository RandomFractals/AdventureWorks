using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AdventureWorks.Models.SalesOrder;
using AdventureWorks.Repository;


namespace AdventureWorks.Controllers
{
    public class SalesOrdersController : Controller
    {
        // GET: SalesOrders
        public ActionResult Index()
        {
            ISalesOrdersRepository ordersRepo = new DapperSalesOrdersRepository();

            return View(ordersRepo.GetSalesOrders());
        }
    }
}