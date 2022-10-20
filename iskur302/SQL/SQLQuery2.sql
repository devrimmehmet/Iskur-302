--fonksiyona parametre olarak gönderilen kolon içerisindeki tüm deðerleri toplayýp size geri döndürür
--select UnitPrice,UnitsInStock,UnitPrice*UnitsInStock as Çarpým from Products
--select COUNT(UnitPrice) from Products
--select sum(Freight) from Orders
--select sum(Freight) from Orders where (OrderDate >='1997')and (OrderDate <'1998')
--select sum(Freight) from Orders where YEAR(OrderDate) ='1997'

--select (SUM(Freight))/count(Freight) from Orders 
--select * from Products where UnitsInStock<15
--select count(ProductName) from Products where UnitsInStock<15
--select * from [Order Details]
--select SUM(UnitPrice*(1-Discount)*Quantity) from [Order Details]

-- avg yapýsý
-- ortalama almak için kullanýlan yapýdýr.
--select avg(Freight) from orders
--select avg(UnitPrice) from Products

--ortalama ne kadar kargo ücreti ödenmiþtir
--select * from Orders 
--select  SUM(Freight) from Orders where 
--select SUM(Freight)/count(DISTINCT ShipCountry) from Orders
-- sahip olunan deðerler arasýnda enbüyük veya en küçük deðeri almak için kullandýðýmýz fonksiyonlardýr 
-- bu fonksiyonlar sadece sayýsal deðil metinsel ve tarihsel ifadeler içinde kullanýlabilirler

--select MAX(Freight) from Orders 

--müþteri idleri a ile k arasýnda olanlarýn vermiþ olduklarý sipariþ tarihleri 01.01.1997 
--ile 06.06.1996 arasýnda olan sipariþlere en az ne kadar kargo ücreti ödenmiþtir
--select MIN(Freight) from orders where CustomerID LIKE '[A-K]%' and OrderDate between '01.01.1997' and '06.06.1997'

--select min( UnitPrice*Quantity *(1-Discount))from [Order Details] where UnitPrice>5

--2,4,5,7 nolu çalýþanlarýn almýþ olduklarý sipariþleri gösteriniz
 --select * from Orders where EmployeeID in (2,4,5,7)
 -- 1 yada 2 nolu kargo firmasý ile tanýþmýþ 1996 yýlýnda bir perþembe günü alýnmýþ sipariþler için ödenen azami kargo bedeli nedir
-- select MAX(Freight) from Orders where ShipVia in (1,2) and YEAR(OrderDate)=1996 AND DATENAME(WEEKDAY,OrderDate)='Thursday'

-- 'CATU' 'DUMON' 'PERIC' idli müþteriler tarafýndan
--istenmiþ 2 nolu kargo firmasý tarafýndan taþýnmamýþ kargo ücreti 20 ile 200 dolar arasý olan sipariþlere toplam ne kadarlýk kargo ödemesi yapýlmýþtýr

--select SUM(Freight) from orders where (CustomerID='PERIC' or CustomerID='DUMON' or CustomerID='CACTU') and ShipVia!=2 and  Freight BETWEEN 20 AND 200

-- sinema otomasyonu en az 10 tabloluk veri tabný oluþtur iliþkileri kur veri ekle 
--bugün iþlediklerimizi ordan yap

--speedy expreess ile taþýnmýþ, nancy nin almýþ olduðu, pazartesi günleri alfk yada dumon idli müþteriler tarafýndan verilmiþ olan sipariþler
--go
--CREATE VIEW Siparisim
--select o.OrderID,o.OrderDate,s.CompanyName,e.FirstName,c.CustomerID from Orders o inner join Customers c ON c.CustomerID = o.CustomerID INNER JOIN Employees e ON e.EmployeeID = o.EmployeeID INNER JOIN Shippers s ON s.ShipperID = o.ShipVia where s.CompanyName='Speedy Express' and e.FirstName='Nancy' and c.CustomerID IN ('ALFKI','DUMON') and DATENAME(WEEKDAY, o.OrderDate)='Monday'
--go



--saklý yordum stored presodurler
--fonksiyonlar