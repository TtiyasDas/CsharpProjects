create table Salesman( salesman_id numeric(5) primary key, name varchar(30) not null, city varchar(15) not null, commission decimal(5,2) not null
)
insert into Salesman values(5001,'James Hoog','New York',0.15)
insert into Salesman values(5002,'Nail Knite','Paris',0.13)
insert into Salesman values(5005,'Pit Alex','London',0.11)
insert into Salesman values(5006,'Mc Lyon','Paris',0.14)
insert into Salesman values(5007,'Paul Adam','Rome',0.13)
insert into Salesman values(5003,'Lauson Hen','San Jose',0.12)


create table Customer(customer_id numeric(5) primary key,cust_name varchar(30) not null,city varchar(15) not null,grade numeric(3) not null,salesman_id numeric(5) not null)
insert into Customer values(3002,'Nick Rimando','New York',100,5001)
insert into Customer values(3007,'Brad Davis','New York',200,5001)
insert into Customer values(3005,'Graham Zusi','California',200,5002)
insert into Customer values(3008,'Julian Green','London',300,5002)
insert into Customer values(3004,'Fabian Johnson','Paris',300,5006)
insert into Customer values(3009,'Geoff Cameron','Berlin',100,5003)
insert into Customer values(3003,'Jozy Altidor','Moscow',200,5007)
insert into Customer values(3001,'Brad Guzan','London',100,5005)



create table Orders(ord_no numeric(5) primary key,purch_amt decimal(8,2) not null,ord_date date not null,customer_id numeric(5) references Customer(customer_id) not null,
salesman_id numeric(5) references Salesman(salesman_id) not null)
insert into Orders values(70001,150.5,'2012-10-05',3005,5002)
insert into Orders values(70009,270.65,'2012-09-10',3001,5005)
insert into Orders values(70002,65.26,'2012-10-05',3002,5001)
insert into Orders values(70004,110.5,'2012-08-17',3009,5003)
insert into Orders values(70007,948.5,'2012-09-10',3005,5002)
insert into Orders values(70005,2400.6,'2012-07-27',3007,5001)
insert into Orders values(70008,5760,'2012-09-10',3002,5001)
insert into Orders values(70010,1983.43,'2012-10-10',3004,5006)
insert into Orders values(70003,2480.4,'2012-10-10',3009,5003)
insert into Orders values(70012,250.45,'2012-06-27',3008,5002)
insert into Orders values(70011,75.29,'2012-08-17',3003,5007)
insert into Orders values(70013,3045.6,'2012-04-25',3002,5001)


--1.Write a SQL statement to display all the information of all salesmen
select * from Salesman

--2.Write a SQL statement to display specific columns like name and commission for all the salesmen
select name,commission from Salesman 
	
--3.Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders
select ord_date,salesman_id,ord_no,purch_amt from Orders

--4.Write a SQL query to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city.
select name,city from Salesman where city='Paris'

--5.Write a SQL query to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id
select customer_id,cust_name,city,grade,salesman_id from Customer where grade < 200

--6.Write a SQL query to find the orders, which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt
select ord_no, ord_date, purch_amt from Orders where salesman_id = 5001

--7.Write a SQL query to calculate average purchase amount of all orders. Return average purchase amount. 
select AVG(purch_amt) as avg_purchase_amt from Orders

--8.Write a SQL query to count the number of unique salespeople. Return number of salespeople.  
select count(salesman_id) as number_of_salesman from Salesman 

--9.Write a SQL query to count the number of customers. Return number of customers.
select count(customer_id) as number_of_customers from Customer 

--10.Write a SQL query to find the maximum purchase amount
select max(purch_amt) as max_purch_amt from Orders

--11.Write a SQL query to find the highest grade of the customers for each of the city. Return city, maximum grade.
select city,max(grade) as max_grade from Customer group by city

--12.Write a SQL query to find the highest purchase amount ordered by each customer. Return customer ID, maximum purchase amount
select customer_id,max(purch_amt) as max_purch_amt from Orders group by customer_id
