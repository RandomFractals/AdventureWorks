using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Models
{

    public class SalesOrderDetails
    {
        public int SalesOrderID { get; set; }

        public int SalesOrderDetailID { get; set; }

        public int ProductID { get; set; }

        [Display(Name = "product")]
        public string ProductName { get; set; }

        [Display(Name = "quantity")]
        public int OrderQty { get; set; }

        [Display(Name = "list price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ListPrice { get; set; }

        [Display(Name = "unit price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "discount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal UnitPriceDiscount { get; set; }

        [Display(Name = "total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal LineTotal { get; set; }
    }
}
