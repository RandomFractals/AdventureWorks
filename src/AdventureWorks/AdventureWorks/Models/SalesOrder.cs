using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Models
{

    public class SalesOrder
    {
        public int SalesOrderID { get; set; }

        [Display(Name = "order #")]
        public string SalesOrderNumber { get; set; }

        [Display(Name = "purchase order")]
        public string PurchaseOrderNumber { get; set; }

        [Display(Name = "account #")]
        public string AccountNumber { get; set; }

        // TODO: see how moving these to Customer.cs works with Dapper mapping
        [Display(Name = "for")]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "due")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DueDate { get; set; }

        [Display(Name = "on")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ShipDate { get; set; }

        [Display(Name = "to")]
        public int ShipToAddressID { get; set; }

        [Display(Name = "via")]
        public int ShipMethodID { get; set; }

        [Display(Name = "via")]
        public string ShipMethodName { get; set; }

        // TODO: move these to Address.cs
        public string AddressLine1 { get; set; }
        public string City { get; set;  }
        public string StateProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryRegionCode { get; set; }


        [Display(Name = "subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal SubTotal { get; set; }

        [Display(Name = "tax")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TaxAmount { get; set; }

        [Display(Name = "freight")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Freight { get; set; }

        [Display(Name = "total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal TotalDue { get; set; }

        [Display(Name = "modified")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ModifiedDate { get; set; }


    }
}
