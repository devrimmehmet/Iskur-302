--fonksiyona parametre olarak g�nderilen kolon i�erisindeki t�m de�erleri toplay�p size geri d�nd�r�r
--select UnitPrice,UnitsInStock,UnitPrice*UnitsInStock as �arp�m from Products
--select COUNT(UnitPrice) from Products
--select sum(Freight) from Orders
--select sum(Freight) from Orders where (OrderDate >='1997')and (OrderDate <'1998')
--select sum(Freight) from Orders where YEAR(OrderDate) ='1997'

--select (SUM(Freight))/count(Freight) from Orders 
--select * from Products where UnitsInStock<15
--select count(ProductName) from Products where UnitsInStock<15
--select * from [Order Details]
--select SUM(UnitPrice*(1-Discount)*Quantity) from [Order Details]

-- avg yap�s�
-- ortalama almak i�in kullan�lan yap�d�r.
--select avg(Freight) from orders
--select avg(UnitPrice) from Products

--ortalama ne kadar kargo �creti �denmi�tir
--select * from Orders 
--select  SUM(Freight) from Orders where 
--select SUM(Freight)/count(DISTINCT ShipCountry) from Orders
-- sahip olunan de�erler aras�nda enb�y�k veya en k���k de�eri almak i�in kulland���m�z fonksiyonlard�r 
-- bu fonksiyonlar sadece say�sal de�il metinsel ve tarihsel ifadeler i�inde kullan�labilirler

--select MAX(Freight) from Orders 

--m��teri idleri a ile k aras�nda olanlar�n vermi� olduklar� sipari� tarihleri 01.01.1997 
--ile 06.06.1996 aras�nda olan sipari�lere en az ne kadar kargo �creti �denmi�tir
--select MIN(Freight) from orders where CustomerID LIKE '[A-K]%' and OrderDate between '01.01.1997' and '06.06.1997'

--select min( UnitPrice*Quantity *(1-Discount))from [Order Details] where UnitPrice>5

--2,4,5,7 nolu �al��anlar�n alm�� olduklar� sipari�leri g�steriniz
 --select * from Orders where EmployeeID in (2,4,5,7)
 -- 1 yada 2 nolu kargo firmas� ile tan��m�� 1996 y�l�nda bir per�embe g�n� al�nm�� sipari�ler i�in �denen azami kargo bedeli nedir
-- select MAX(Freight) from Orders where ShipVia in (1,2) and YEAR(OrderDate)=1996 AND DATENAME(WEEKDAY,OrderDate)='Thursday'

-- 'CATU' 'DUMON' 'PERIC' idli m��teriler taraf�ndan
--istenmi� 2 nolu kargo firmas� taraf�ndan ta��nmam�� kargo �creti 20 ile 200 dolar aras� olan sipari�lere toplam ne kadarl�k kargo �demesi yap�lm��t�r

--select SUM(Freight) from orders where (CustomerID='PERIC' or CustomerID='DUMON' or CustomerID='CACTU') and ShipVia!=2 and  Freight BETWEEN 20 AND 200

-- sinema otomasyonu en az 10 tabloluk veri tabn� olu�tur ili�kileri kur veri ekle 
--bug�n i�lediklerimizi ordan yap

--speedy expreess ile ta��nm��, nancy nin alm�� oldu�u, pazartesi g�nleri alfk yada dumon idli m��teriler taraf�ndan verilmi� olan sipari�ler
--go
--CREATE VIEW Siparisim
--select o.OrderID,o.OrderDate,s.CompanyName,e.FirstName,c.CustomerID from Orders o inner join Customers c ON c.CustomerID = o.CustomerID INNER JOIN Employees e ON e.EmployeeID = o.EmployeeID INNER JOIN Shippers s ON s.ShipperID = o.ShipVia where s.CompanyName='Speedy Express' and e.FirstName='Nancy' and c.CustomerID IN ('ALFKI','DUMON') and DATENAME(WEEKDAY, o.OrderDate)='Monday'
--go



--sakl� yordum stored presodurler
--fonksiyonlar