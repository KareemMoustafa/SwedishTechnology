/****** Script for SelectTopNRows command from SSMS  ******/

SELECT *
  FROM [OrderDB].[dbo].[Services]


SELECT *
  FROM [OrderDB].[dbo].[Employees]

SELECT *
  FROM [OrderDB].[dbo].[Products]

SELECT *
  FROM [OrderDB].[dbo].[Orders]
WHERE OrderID = 10249

SELECT *
  FROM [OrderDB].[dbo].[OrderDetails]
  WHERE OrderID = 10249

SELECT * 
  FROM  [OrderDB].[dbo].[Customers]

SELECT * 
FROM   [OrderDB].[dbo].[Employees]