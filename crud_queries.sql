-- Make sure to use your database
USE DB_Ordering_Food_Transaction_Casan_IT13;
GO

-- ------------------------------------------------------------------
-- CREATE (Add a new record)
-- ------------------------------------------------------------------
-- Description: This query inserts a new food item into the FoodItems table.
-- Instructions: You can change the values in the VALUES clause to add different items.

INSERT INTO FoodItems (Name, Description, Price)
VALUES ('Cheeseburger', 'A classic beef burger with cheese, lettuce, and tomato.', 9.99);
GO

-- ------------------------------------------------------------------
-- READ (View all records)
-- ------------------------------------------------------------------
-- Description: This query retrieves all records from the FoodItems table.
-- Instructions: Run this query to see all the data currently in your table.

SELECT * FROM FoodItems;
GO

-- ------------------------------------------------------------------
-- UPDATE (Edit an existing record)
-- ------------------------------------------------------------------
-- Description: This query updates the details of an existing food item.
-- Instructions: Change the SET values to modify the record. Make sure to specify the correct Id in the WHERE clause to update the right item.

UPDATE FoodItems
SET Name = 'Bacon Cheeseburger', Price = 11.49
WHERE Id = 1; -- Change the Id to the specific item you want to update
GO

-- ------------------------------------------------------------------
-- DELETE (Remove a record)
-- ------------------------------------------------------------------
-- Description: This query removes a food item from the table.
-- Instructions: Specify the Id of the item you want to delete in the WHERE clause. Be careful, as this action is permanent.

DELETE FROM FoodItems
WHERE Id = 1; -- Change the Id to the specific item you want to delete
GO
