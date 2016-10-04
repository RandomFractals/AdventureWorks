using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

using AdventureWorks.Models;

namespace AdventureWorks.Repository
{
    public class DapperSalesOrdersRepository: ISalesOrdersRepository
	{
        private SqlConnection GetConnection()
        {
            string sqlConnectionString = //ConfigurationManager.ConnectionStrings["SqlConn"].ToString();
                "Server=(localdb)\\MSSQLLocalDB;Database=AdventureWorks2014;Trusted_Connection=True;MultipleActiveResultSets=true";
            return new SqlConnection(sqlConnectionString);
        }

        // TODO: add query and pagination params
        public List<SalesOrder> GetSalesOrders()
        {
            try
            {
                SqlConnection sqlConnection = this.GetConnection();
                IList<SalesOrder> orderList = SqlMapper.Query<SalesOrder>(
                    sqlConnection, "SalesGetSalesOrders").ToList();
                sqlConnection.Close();
                return orderList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<SalesOrderDetails> GetSalesOrderDetails(int orderId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@SalesOrderID", orderId);
                SqlConnection sqlConnection = this.GetConnection();
                IList<SalesOrderDetails> orderList = 
                    sqlConnection.Query<SalesOrderDetails>(
                    "SalesGetSalesOrderDetails", parameters,
                    commandType: CommandType.StoredProcedure).ToList();
                sqlConnection.Close();
                return orderList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
