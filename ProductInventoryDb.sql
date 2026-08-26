IF DB_ID(N'ProductInventoryDb') IS NULL
BEGIN
    CREATE DATABASE ProductInventoryDb;
END;
GO

USE ProductInventoryDb;
GO

IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Products
    (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(200) NOT NULL,
        ProductCode NVARCHAR(50) NOT NULL,
        StockCount INT NOT NULL,
        CONSTRAINT UQ_Products_ProductCode UNIQUE (ProductCode),
        CONSTRAINT CK_Products_StockCount CHECK (StockCount >= 0)
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE ProductCode = N'CABLE-USBC-1M')
BEGIN
    INSERT INTO dbo.Products (Name, ProductCode, StockCount)
    VALUES (N'USB-C Cable', N'CABLE-USBC-1M', 25);
END;

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE ProductCode = N'MOUSE-WL-01')
BEGIN
    INSERT INTO dbo.Products (Name, ProductCode, StockCount)
    VALUES (N'Wireless Mouse', N'MOUSE-WL-01', 10);
END;

IF NOT EXISTS (SELECT 1 FROM dbo.Products WHERE ProductCode = N'KEYBOARD-01')
BEGIN
    INSERT INTO dbo.Products (Name, ProductCode, StockCount)
    VALUES (N'Keyboard', N'KEYBOARD-01', 7);
END;
GO
