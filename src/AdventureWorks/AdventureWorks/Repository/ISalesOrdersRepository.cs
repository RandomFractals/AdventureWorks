using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventureWorks.Models;

namespace AdventureWorks.Repository
{
    interface ISalesOrdersRepository
    {
        // TODO: add query and pagination params
        List<SalesOrder> GetSalesOrders();

        List<SalesOrderDetails> GetSalesOrderDetails(int orderId);
    }
}
