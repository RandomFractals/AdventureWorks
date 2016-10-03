using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Models.SalesOrder
{

    public class SalesOrder
    {
        public int SalesOrderID { get; set; }

        [Display(Name = "Created")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Due")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Ship")]
        public DateTime ShipDate { get; set; }

        [Display(Name = "#")]
        public string SalesOrderNumber { get; set; }

        [Display(Name = "PO #")]
        public string PurchaseOrderNumber { get; set; }

        [Display(Name = "Acct #")]
        public string AccountNumber { get; set; }

        public int CustomerID { get; set; }

        public int ShipToAddressID { get; set; }

        public int ShipMethodID { get; set; }

        [Display(Name = "SubTotal ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }

        [Display(Name = "Tax ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TaxAmount { get; set; }

        [Display(Name = "Freight ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Freight { get; set; }


        [Display(Name = "Total ($)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalDue { get; set; }

        [Display(Name = "Modified")]
        public DateTime ModifiedDate { get; set; }


    }
}
