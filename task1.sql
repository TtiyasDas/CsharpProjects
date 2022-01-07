--write a SQL query to calculate average purchase amount of all orders. Return average purchase amount.
SELECT AVG (purch_amt)FROM orders;

--Write a SQL query to count the number of unique salespeople. Return number of salespeople.
SELECT COUNT (DISTINCT salesman_id) FROM orders;

--write a SQL query to count the number of customers. Return number of customers.
SELECT COUNT(*) FROM customer;

--write a SQL query to find the minimum purchase amount.
SELECT MIN(purch_amt) FROM orders;

--write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade
SELECT city,MAX(grade)FROM customer GROUP BY city;

--write a SQL query to find the highest purchase amount ordered by each customer. Return customer ID, maximum purchase amount.
SELECT customer_id,MAX(purch_amt) FROM orders GROUP BY customer_id;