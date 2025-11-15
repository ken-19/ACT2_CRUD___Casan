-- Create the database
CREATE DATABASE DB_Ordering_Food_Transaction_Casan_IT13;
GO

-- Use the newly created database
USE DB_Ordering_Food_Transaction_Casan_IT13;
GO

-- Create the FoodItems table
CREATE TABLE FoodItems (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255),
    Price DECIMAL(18, 2) NOT NULL
);
GO
