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
    public class DapperCustomerRepository: ICustomerRepository
	{
        private SqlConnection GetConnection()
        {
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ToString();
            // "Server=(localdb)\\MSSQLLocalDB;Database=AdventureWorks2014;Trusted_Connection=True;MultipleActiveResultSets=true";
            //"Server=.\\SQLEXPRESS;Database=AdventureWorks2014;Trusted_Connection=True;MultipleActiveResultSets=true";
            return new SqlConnection(sqlConnectionString);
        }
        
        public List<Customer> GetCustomers()
        {
            try
            {
                SqlConnection sqlConnection = this.GetConnection();
                IList<Customer> customerList =
                    sqlConnection.Query<Customer>(
                    @"SELECT TOP 1000 CustomerID, Title, FirstName, LastName
                        FROM Sales.Customer
                                JOIN Person.Person
                                ON Sales.Customer.PersonID = Person.Person.BusinessEntityID
                            WHERE Title IS NOT NULL").ToList();
                sqlConnection.Close();
                return customerList.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer GetCustomer(int customerId)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@CustomerID", customerId);
                SqlConnection sqlConnection = this.GetConnection();
                Customer customer =
                    sqlConnection.QueryFirst<Customer>(
                    @"SELECT Sales.Customer.CustomerID, Title, FirstName, LastName
                        FROM Sales.Customer 
                                JOIN Person.Person
                                ON Sales.Customer.PersonID = Person.Person.BusinessEntityID
                        JOIN Sales.SalesOrderHeader
                                ON Sales.Customer.CustomerID = Sales.SalesOrderHeader.CustomerID 
                    WHERE Sales.Customer.CustomerID = @CustomerID", parameters
                    );
                sqlConnection.Close();
                customer.Orders = (new DapperSalesOrdersRepository()).GetSalesOrders(customerId);
                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
