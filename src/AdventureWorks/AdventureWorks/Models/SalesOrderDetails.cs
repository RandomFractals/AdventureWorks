using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Models.SalesOrder
{

    public class SalesOrderDetails
    {
        public int SalesOrderID { get; set; }

        public int SalesOrderDetailID { get; set; }

        public int OrderQty { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        [Display(Name = "Unit ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "UP Discount ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal UnitPriceDiscount { get; set; }

        [Display(Name = "Line Total ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal LineTotal { get; set; }

        [Display(Name = "List Price ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal ListPrice { get; set; }

    }
}
