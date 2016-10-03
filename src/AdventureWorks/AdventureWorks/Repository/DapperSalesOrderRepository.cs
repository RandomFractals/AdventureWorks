using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AdventureWorks.Models.SalesOrder;

namespace AdventureWorks.Repository
{
    public class DapperSalesOrdersRepository: ISalesOrdersRepository
	{

        // TODO: add query and pagination params
        public List<SalesOrder> GetSalesOrders()
        {
            return null;
        }

        public List<SalesOrderDetails> GetSalesOrderDetails(int orderId)
        {
            return null; 
        }

    }
}
