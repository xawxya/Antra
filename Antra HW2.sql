use AdventureWorks2019
GO
--1. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the
--following.
--    Country                        Province

SELECT cr.CountryRegionCode AS Country, sp.StateProvinceCode as Province 
FROM Person.CountryRegion cr LEFT JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode

--2. Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and list the countries filter them by Germany and Canada.
--Join them and produce a result set similar to the following.
--    Country                        Province

SELECT cr.CountryRegionCode AS Country, sp.StateProvinceCode as Province 
FROM Person.CountryRegion cr LEFT JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.CountryRegionCode IN('DE', 'CA')


-- Using Northwind Database: (Use aliases for all the Joins)
use NORTHWND
GO
--3. List all Products that has been sold at least once in last 25 years.
SELECT DISTINCT p.ProductName
FROM dbo.Orders o JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID LEFT JOIN dbo.Products p ON od.ProductID = p.ProductID

--4. List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT TOP 5 o.ShipPostalCode, COUNT(o.OrderID) as [Number of Orders]
FROM dbo.Orders o 
WHERE o.ShipPostalCode IS NOT NULL
GROUP BY o.ShipPostalCode
ORDER BY [Number of Orders] DESC

--5. List all city names and number of customers in that city.     
SELECT c.City, COUNT(c.CustomerID) as NumberOfCustomer
FROM dbo.Customers c
GROUP BY c.City

--6. List city names which have more than 2 customers, and number of customers in that city
SELECT c.City, COUNT(c.CustomerID) as NumberOfCustomer
FROM dbo.Customers c
GROUP BY c.City
HAVING COUNT(c.CustomerID) >= 2 --Why I can't use "HAVING NumberOfCustomer >= 2" here instead?

--7. Display the names of all customers  along with the count of products they bought
SELECT c.CompanyName, c.ContactName, SUM(od.Quantity) TotalaQuantity
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName, c.ContactName

--8. Display the customer ids who bought more than 100 Products with count of products.
SELECT c.CustomerID, SUM(od.Quantity) TotalaQuantity
FROM dbo.Customers c JOIN dbo.Orders o ON c.CustomerID = o.CustomerID JOIN dbo.[Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.CustomerID
HAVING SUM(od.Quantity) >= 100

--9. List all of the possible ways that suppliers can ship their products. Display the results as below
--    Supplier Company Name                Shipping Company Name
--    ---------------------------------            ----------------------------------
SELECT s.CompanyName, sh.CompanyName
FROM dbo.Suppliers s CROSS JOIN dbo.Shippers sh

--10. Display the products order each day. Show Order date and Product Name.
SELECT o.Orderdate, p.ProductName
FROM Orders o JOIN [Order Details] od ON o.OrderID = od.OrderID JOIN Products p ON od.ProductID = p.ProductID
ORDER BY o.Orderdate

--11. Displays pairs of employees who have the same job title.
SELECT e.Title, e.LastName + ' ' + e.FirstName Name 
FROM Employees e
ORDER BY e.Title;



--12. Display all the Managers who have more than 2 employees reporting to them.
SELECT e2.EmployeeID, e2.LastName, e2.FirstName, COUNT(e.employeeID) NumberOfEmployee
FROM Employees e JOIN Employees e2 ON e.ReportsTo = e2.EmployeeID
GROUP BY e2.EmployeeID, e2.LastName, e2.FirstName
HAVING COUNT(e.employeeID) >= 2



--13. Display the customers and suppliers by city. The results should have the following columns
--City
--Name
--Contact Name,
--Type (Customer or Supplier)

SELECT City, CompanyName, ContactName, 'Supplier' Type
FROM Suppliers
UNION ALL
SELECT City, CompanyName, ContactName, 'Customer' Supplier
FROM Customers
ORDER BY City

--All scenarios are based on Database NORTHWIND.
--14. List all cities that have both Employees and Customers.
SELECT DISTINCT c.City
FROM Employees e INNER JOIN Customers c ON e.City = c.City

--15. List all cities that have Customers but no Employee.
--a.  
-- Use sub-query
SELECT DISTINCT c.City
FROM Customers c
WHERE c.City NOT IN(SELECT DISTINCT c.City
FROM Employees e INNER JOIN Customers c ON e.City = c.City)

--b.     
-- Do not use sub-query
SELECT DISTINCT c.City
FROM Customers c FULL JOIN Employees e ON e.City = c.City

--16. List all products and their total order quantities throughout all orders.
SELECT p.ProductName, SUM(od.Quantity) TotalOrderQuantities
FROM Products p JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductName

--17. List all Customer Cities that have at least two customers.
SELECT c.City, Count(*) NumberOfCustomer
FROM Customers c
GROUP BY c.City
HAVING Count(*) >= 2

--18. List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, Count(od.ProductID) as NumOfProducts
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
Group BY c.City
HAVING Count(od.ProductID) >= 2

--19. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
SELECT TOP 5 ProductID,
AVG(UnitPrice) AvgPrice,
(select top 1 City 
FROM Customers c join Orders o ON o.CustomerID=c.CustomerID join [Order Details] od2 ON od2.OrderID=o.OrderID 
WHERE od2.ProductID=od1.ProductID GROUP BY city ORDER BY SUM(Quantity) desc) City 
FROM [Order Details] od1 
GROUP by ProductID  
ORDER by SUM(Quantity) DESC

--20. List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered
--from. (tip: join  sub-query)
SELECT TOP 1 o.EmployeeID, COUNT(o.OrderID)
FROM Orders o
GROUP BY o.EmployeeID
ORDER BY COUNT(o.OrderID) DESC

SELECT e.City
FROM Employees e
WHERE e.EmployeeID =


SELECT c.City, SUM(od.Quantity)
FROM Customers c JOIN Orders o ON c.CustomerID = o.CustomerID JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY SUM(od.Quantity) DESC


--21. How do you remove the duplicates record of a table?
 --Use ROW_NUMBER() to find all the dupdlicate rows and delete use the DELETE statement to remove from table