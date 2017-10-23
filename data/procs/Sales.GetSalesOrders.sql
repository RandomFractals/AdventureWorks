USE AdventureWorks2014
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID ('[dbo].[SalesGetSalesOrders]', 'P') IS NOT NULL
	DROP PROCEDURE [dbo].[SalesGetSalesOrders];
GO

CREATE PROCEDURE [dbo].[SalesGetSalesOrders] (@customerID int)
AS
BEGIN
SELECT TOP (10) Orders.SalesOrderID, 
		Orders.OrderDate, 
		Orders.DueDate, 
		Orders.ShipDate, 
		Orders.Status, 
		Orders.SalesOrderNumber, 
		Orders.PurchaseOrderNumber, 
		Orders.AccountNumber, 
		Orders.CustomerID, 
		Customer.PersonID,
		Person.FirstName,
		Person.LastName,
		Orders.ShipToAddressID, 
		ShipToAddress.AddressLine1,
		ShipToAddress.AddressLine2,
		ShipToAddress.City,
		ShipToAddress.StateProvinceID,
		ProvinceCountryRegion.StateProvinceCode,
		ProvinceCountryRegion.StateProvinceName,
		ProvinceCountryRegion.CountryRegionCode,
		ProvinceCountryRegion.CountryRegionName,
		ShipToAddress.PostalCode,
		Orders.ShipMethodID, 
		ShipMethod.[Name] AS ShipMethodName,
		ShipMethod.ShipBase,
		ShipMethod.ShipRate,
		Orders.CurrencyRateID, 
		Orders.SubTotal, 
		Orders.TaxAmt, 
		Orders.Freight, 
		Orders.TotalDue, 
		Orders.rowguid, 
		Orders.ModifiedDate
	FROM Sales.SalesOrderHeader AS Orders
		INNER JOIN Sales.Customer AS Customer
		ON Orders.CustomerID = Customer.CustomerID
		INNER JOIN Person.Person AS Person
		ON Customer.PersonID = Person.BusinessEntityID
		INNER JOIN Person.[Address] As ShipToAddress
		ON Orders.ShipToAddressID = ShipToAddress.AddressID
		INNER JOIN Person.vStateProvinceCountryRegion as ProvinceCountryRegion
		ON ShipToAddress.StateProvinceID = ProvinceCountryRegion.StateProvinceID
		INNER JOIN Purchasing.ShipMethod AS ShipMethod
		ON Orders.ShipMethodID = ShipMethod.ShipMethodID
	WHERE (@customerID IS NULL) OR Orders.CustomerID = @customerID
END
