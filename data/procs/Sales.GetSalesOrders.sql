USE AdventureWorks2014
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID ('[dbo].[SalesGetSalesOrders]', 'P') IS NOT NULL
	DROP PROCEDURE [dbo].[SalesGetSalesOrders];
GO

CREATE PROCEDURE [dbo].[SalesGetSalesOrders]
AS
BEGIN
	SELECT TOP (20) SalesOrderID, OrderDate, DueDate, ShipDate, Status, 
		SalesOrderNumber, PurchaseOrderNumber, AccountNumber, 
    CustomerID, ShipToAddressID, ShipMethodID, CurrencyRateID,
		SubTotal, TaxAmt, Freight, TotalDue, ModifiedDate
	FROM Sales.SalesOrderHeader
END
GO