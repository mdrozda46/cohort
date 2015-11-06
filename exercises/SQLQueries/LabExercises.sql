Use Northwind
Go

select ProductName, UnitsInStock
 from Products 
where ProductName IN ('Ravioli Angelo', 'Laughing Lumberjack Lager', 'Outback Lager')

select *
From Orders
Where CustomerID = 'QUEDE'

select * 
from Orders 
Where Freight >= 10 and freight <=20 and ShipCountry = 'USA'

select e.EmployeeID, e.LastName, et.TerritoryID 
from Employees e
inner join EmployeeTerritories et
On e.EmployeeID = et.EmployeeID

select o.OrderID, c.CompanyName, o.OrderDate, p.ProductName, c.Country
from Orders o
	inner join customers c
	on o.CustomerID = c.CustomerID
		inner join [Order Details] od
		on o.OrderID = od.OrderID
			inner join Products p
				on od.ProductID = p.ProductID
				where c.Country = 'USA' and p.ProductName = 'Chai'
			




