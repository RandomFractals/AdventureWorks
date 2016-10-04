using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using AdventureWorks.Models;
using AdventureWorks.Repository;


namespace AdventureWorks.Controllers
{
    public class SalesOrdersController : Controller
    {
        // [FromServices] // note: something changed here since .net 5 alpha for inject
        //public ISalesOrdersRepository SalesOrdersRepository { get; set; }

        private ISalesOrdersRepository _ordersRepo { get; set; }

        public SalesOrdersController()
        {
            // init dapper repo direct for now
            this._ordersRepo = new DapperSalesOrdersRepository();
        }

        // GET: SalesOrders
        public ActionResult Index()
        {
            return View(this._ordersRepo.GetSalesOrders());
        }

        // GET: SalesOrderDetails
        public ActionResult SalesOrderDetails(int orderId)
        {
            return View( this._ordersRepo.GetSalesOrderDetails(orderId) );
        }


    }
}