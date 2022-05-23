--1.Create a view named “view_product_order_[your_last_name]”, list all products and total ordered quantity for that product.
CREATE VIEW View_product_order_wong
AS
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) TotalQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName

--2.Create a stored procedure “sp_product_order_quantity_[your_last_name]” that accept product id as an input and total quantities of order as output parameter.
CREATE PROC sp_product_order_quantity_wong
@ProductID int,
@TotalQuantity int out
AS
BEGIN
SELECT @TotalQuantity = dt.TotalQuantity 
FROM (
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) TotalQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName
) dt
WHERE dt.ProductID = @productID
END

--3.Create a stored procedure “sp_product_order_city_[your_last_name]” that accept product name as an input and top 5 cities that ordered most that product combined with the total quantity of that product ordered from that city as output.
CREATE PROC sp_product_order_city_wong
@ProductName varchar(20)
AS
BEGIN
SELECT TOP 5 dt.City
FROM (
SELECT p.ProductID, p.ProductName, c.City, SUM(od.Quantity) TotalQuantity
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID JOIN Orders o ON od.OrderID = o.OrderID JOIN Customers c ON o.CustomerID = c.CustomerID
GROUP BY p.ProductID, p.ProductName, c.City
) dt
WHERE @ProductName = dt.ProductName
ORDER BY TotalQuantity DESC
END

BEGIN
EXEC sp_product_order_city_wong [Chai]
END

--4.Create 2 new tables “people_your_last_name” “city_your_last_name”. City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. Remove city of Seattle. If there was anyone from Seattle, put them into a new city “Madison”. Create a view “Packers_your_name” lists all people from Green Bay. If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
CREATE TABLE people_wong  (ID int, Name varchar(20), City varchar(20))
CREATE TABLE City_wong(ID int, City varchar(20))

INSERT INTO City_wong
VALUES(1, 'Seattle'),(2,'Green Bay')

INSERT INTO people_wong
VALUES(1, 'Aaron Rodgers', 2), (2, 'Russell Wilson', 1), (3, 'Jody Nelson', 2)

DELETE
FROM City_wong 
WHERE City = 'Seattle'

INSERT INTO City_wong
VALUES(3, 'Madsion')

UPDATE People_Wong	
SET City = 3
WHERE City = 1

CREATE VIEW Packers_kin_wong
AS
SELECT *
FROM people_wong pw JOIN City_wong cw ON pw.City = cw.City
WHERE cw.City = 'Green Bay'

Drop table people_wong
Drop table City_wong

--5.Create a stored procedure “sp_birthday_employees_[you_last_name]” that creates a new table “birthday_employees_your_last_name” and fill it with all employees that have a birthday on Feb. (Make a screen shot) drop the table. Employee table should not be affected.
CREATE PROC sp_birthday_employees_wong 
AS
BEGIN
CREATE TABLE birthday_employees_wong (EName varchar(20))
INSERT INTO birthday_employees_wong (EName)
SELECT e.FirstName + ' ' + e.LastName as EmployeeName
FROM Employees e
WHERE MONTH(e.BirthDate) = 2
END

EXEC sp_birthday_employees_wong

SLEECT *
FROM birthday_employees_wong

DROP TABLE birthday_employees_wong
--6.How do you make sure two tables have the same data?
--By using UNION ALL and see if the row numbers are the same 