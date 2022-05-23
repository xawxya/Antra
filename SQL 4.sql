--1. What is index; types of indices; pros and cons
--Index are used to collect data more quickly.
--Clustered index: only one clustered index and data are sorted. Non clustered index: more than than one and data are not sorted
--Speed up queries. Use extra space

--2. What's the difference between Primary key and Unique constraint?
--You can only have one primary key for each table. You can have multiple Unique constraint in a table and it allows null value.

--3. Tell me about check constraint
--The check constraint is used to limit the data that can be inserted into a column, for example, we can make a check constraint between 0 to 120 for column 'age'

--4. Difference between temp table and table variable
--Temp table are store in db as local/global table, while table variable can only be used right after it's created.

--5. Difference between WHERE and HAVING
--WHERE is used before GROUP BY while HAVING is used after

--6. Difference between RANK() and DenseRank() — value gap
--Rank() gives tie rank and skip ranking number when it happens, while DenseRank() doesn't skip number

--7. COUNT(*) vs. COUNT(colName)
--COUNT(*) gives you the total number of row no matter if the columes are null, COUNT(colName) only counts rows that are not null under a certain column

--8. What's the difference between left join and inner join? JOIN and Subquery, which one has a
--better performance, why?
--Left join shows null value on the right table if there is any, while inner join only shows non null values on both tables. Join has a better performance because SQL has built-in optmizer for JOIN

--9. What is correlated subquery
--Correlated subquery happens when the inner query is dependent on the outer query.

--10. What is a CTE, why do we need CTE?
--CTE stands for common table expression, we use CTE because it can be called recursively

--11. What does SQL Profiler do?
--SQL Profiler is an interface that used   to analyzes and tunes SQL databases.

--12. What is SQL injection, how to avoid SQL injection?
--SQL injection is a way that hackers can use to cause data leak and may destory your database. We can use stored procdures to limit the input type.

--13. Difference between SP and user defined function? When to use SP when to use function?
--SP does not always have a return value and can not be used in SQL statement. Function always have a return value and can be used in SQL statement like SELECT.

--14. Criteria of Union and Union all? Difference between UNION and UNION ALL
--UNION returns all values from both table with no duplicates. UNION ALL returns all values with dulplicates.

--15. Steps you take to improve SQL Queries
--Plan before executing queries. Only use neccessary indices and joins. Use JOIN instead of subqyery.

--16. concurrency problem in transaction
--Happens when multiple transactions execute concurrently in an uncontrolled manner. It may lead to inaccurate result.

--17. what is deadlock, how to prevent

--18. what is normalization, 1NF - BCNF, benefits using normalization
--Normalization is a process of organizing data. The benefits of using normalization is to keep the table clean and ensure data consistency.

--19. what are the system defined databases?

--20. composite key
--Composite key uses two or more columns to indenify each unique value.

--21. candidate key
--Candidate key is used to uniquely identity each row such as id.

--22. DDL vs. DML
--DDL are used to define objects such as CREATE. DML are used to manage data such as SELECT.

--23. ACID property
--Automicity, consistency, ioslation, durability

--24. table scan vs. index scan
--Table scan iterates every row in the table, while index scan only iterates all index item, but it takes some time to set up.

--25. Difference between Union and JOIN
--UNION has fixed columns shared by both tables. JOIN allows more columns combined by both tables.