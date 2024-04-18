
CREATE DATABASE PARAM_TEST_DATABASE;
GO

USE PARAM_TEST_DATABASE;
GO


CREATE TABLE Clients
(
	ClientCode VARCHAR(5) PRIMARY KEY NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	Address1 VARCHAR(60) NOT NULL,
	Address2 VARCHAR(60),
	City VARCHAR(20),
	Province VARCHAR(10) NOT NULL,
	PostalCode VARCHAR(10),
	YTDSales DECIMAL(18, 2) NOT NULL,
	CreditHold BIT NOT NULL,
	NOTES VARCHAR(4000)
);
GO

/*
DROP TABLE Clients;
GO
*/



INSERT INTO Clients
	(ClientCode, CompanyName, Address1, Address2, City, Province, PostalCode, YTDSales, CreditHold, NOTES)
VALUES 
    ('C001', 'ABC Corporation', '123 Main St', NULL, 'Anytown', 'ON', 'A1B 2C3', 50000.00, 0, 'No credit hold'),
    ('C002', 'XYZ Industries', '456 Oak St', 'Suite 100', 'Anycity', 'AB', 'X1Y 2Z3', 75000.00, 1, 'Credit hold due to outstanding invoices'),
    ('C003', 'Smith & Co.', '789 Elm St', NULL, 'Anysville', 'BC', 'M1N 2P3', 100000.00, 0, 'Regular customer with steady sales');
GO


SELECT TOP (1000) [ClientCode]
      ,[CompanyName]
      ,[Address1]
      ,[Address2]
      ,[City]
      ,[Province]
      ,[PostalCode]
      ,[YTDSales]
      ,[CreditHold]
      ,[NOTES]
  FROM [PARAM_TEST_DATABASE].[dbo].[Clients]
