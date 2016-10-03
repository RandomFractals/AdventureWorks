DECLARE @sales_order_id as int
SET @sales_order_id = 43659

EXEC dbo.SalesGetSalesOrderDetails @SalesOrderID = @sales_order_id;
GO