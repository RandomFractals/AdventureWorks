USE AdventureWorks2014
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND 
		name = 'SalesGetSalesOrderDetails')
	DROP PROCEDURE [dbo].[SalesGetSalesOrderDetails];
GO

CREATE PROCEDURE [dbo].[SalesGetSalesOrderDetails]
	(@SalesOrderID int)
AS

BEGIN 
  SELECT
		OrderDetail.SalesOrderID,
		OrderDetail.SalesOrderDetailID,
		OrderDetail.OrderQty,
		OrderDetail.UnitPrice,
		OrderDetail.UnitPriceDiscount,
		OrderDetail.LineTotal,
		Product.ProductID, 
    Product.Name AS ProductName, 
    Product.ListPrice
  FROM Sales.SalesOrderDetail AS OrderDetail
		INNER JOIN Production.Product as Product
		ON OrderDetail.ProductID = Product.ProductID
  WHERE  OrderDetail.SalesOrderID = @SalesOrderID
  ORDER BY Product.Name  
END

GO
