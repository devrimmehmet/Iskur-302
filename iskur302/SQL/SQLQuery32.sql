--group by yapýsý
--gruplandýrma iþlemi için kullanýlan anahtar kelimedir asýl ortaya çýkýþ amacý avg max min sum count gibi aggregate
--fonksiyonlarla birlikte baðlý bulunduklarý kolonlarýda sorgu içerisine dahil etmektir.
-- ÜLkelere göre çalýþan sayýmýz?
--select country, count (Country) as 'Toplam Çalýþan' from Employees group by Country
--select country from Employees
--select [CategoryID3,],count (CategoryID) as 'Ürün Adeti'  from Products group by CategoryID order by ProductID desc

--select EmployeeID,count(EmployeeID) as 'A' from Orders group by EmployeeID order by 'A' desc
--ülkere göre sipariþ sayýlarýný sýralayýnýz en çok sipariþ veren ülkeyi 
--select top 3 ShipCountry, count(OrderID) as 'Sayi' from Orders group by ShipCountry order by Sayi desc

--her bir kategoride ücret bazlý toplam ne kadarlýk ürün vardýr 
--select SUM (UnitPrice*UnitsInStock) as 'Toplam' from Products group by CategoryID order by Toplam desc

--hangi personel kaç satýþta yer almýþtýr
 --select EmployeeID,count(EmployeeID) as 'Personel' from Orders group by EmployeeID order by Personel desc

 --hangi müþteri kaç kere alýþveriþ yapmýþtýr.

--select CustomerID,count(CustomerID) as 'Müþteri' from Orders group by CustomerID order by Müþteri desc

--hangi tedarikçi hangi kategorideki üründen kaç dolarlýk mevcuttur
--select SupplierID,Sum(UnitPrice*UnitsInStock) as'Toplam' from Products group by SupplierID order by Toplam desc

--iç içe sorgular SUBQUERY YAPISI--

-- iç içe select sorgularýdýr  içteki select sorgusundan gelen cevabýn dýþtaki select sorgusuna dahil edilerek 
-- bir sonuç dahilinde raporlanmasý iþlemine yardýmcý olur
--inner join yetersiz olduðu durumlarda, having iþleminin size cevap vermediði durumlarda

-- ortalama ücretin üzerinde yer alan ürünleri gösteriniz

--select ProductName, UnitPrice from Products 
--where UnitPrice> (select AVG(UnitPrice) from Products)

--select ProductName,UnitPrice, avg (UnitPrice) as 'a' from Products
--where UnitPrice >a

-- nacy vermiþ olduðu sipariþlerin idlerini raporlayýnýz
--select OrderID,EmployeeID from Orders  where
--EmployeeID=(select EmployeeID from Employees 
--where FirstName='nancy')

-- beverages ' in 
--select ProductID,ProductName from Products where CategoryID=(select CategoryID from Categories where CategoryName='Beverages'

-- 'nancy' yada 'andrew' yada 'janet' tarafýndan alýnmýþ speedy express ile taþýnmýþ sipariþleri listeleyiniz

--select * from orders where ShipVia!=(select ShipperID from Shippers where CompanyName ='Speedy Express') and ( EmployeeID=(select EmployeeID from Employees where FirstName='Nancy') 
--or EmployeeID=(select EmployeeID from Employees where FirstName='Andrew')or EmployeeID=(select EmployeeID from Employees where FirstName='Janet'))


-- ALT SORGULAR -- 
-- Belli bir sorgu içinde baþka bir sorgu çalýþtýrma 
--select *, (select CompanyName from Suppliers s where p.SupplierID=s.SupplierID) from Products p



--ÖDEVLER
-- ürünlerle birlikte ürün satýþ adetini listeleyen sorgu

--select * from Products
--select Quantity from [Order Details]

-- hangi satýþta kaç adet ürün satýlmýþtýr
--select * from Orders
--select * from [Order Details]

-- VINET ID isimli müþterinin satýþlarýný listeleyiniz orders ve orderdetails

-- JOINLER -- 
--Ýki tabloyu iliþkili kolonlar üzerinden birbirine baðlar
-- tablolarýn denormalize þeklinde sorgulanmalarýný saðlr
--inner join iliþkili kolonlarda 
--OUTER  join
--cross join

--SELECT * FROM kategoriler INNER JOIN urunler ON kategoriler.kat_id = urunler.kat_id;
--select * from Categories
--select * from Products
--select * from Products p  inner join Categories c on p.CategoryID=c.CategoryID

-- ürünleri tedarikçi þirketlerin adlarý ile listeleyiniz 



--select ProductName,CompanyName 


--from Products p inner join Suppliers s 

--on p.SupplierID=s.SupplierID

--select * from Suppliers

--select * from Products1

-- ürünlerin satýþ raporunu ürün adý satýþ fiyatý adet indirim kolonlarýný rapor et

--select ProductName,oD.UnitPrice,Quantity,Discount from Products p inner join [Order Details] oD on p.ProductID=oD.ProductID 
--select * from [Order Details]

-- hangi satýþta hangi ürünler satýlmýþtýr.
--select o.OrderID,ProductName from Products p 
--inner join [Order Details] oD on p.ProductID=oD.ProductID
--inner join Orders o oN o.OrderID=oD.OrderID

--select * from [Order Details]
--select * from Products
--select * from orders

-- hangi personel hangi müþteriye hangi tarihte satýþ yapmýþtýr.

--select * from [Order Details]
--select left( e.FirstName,1)+ '. '+e.LastName as 'Personel Ad Soyad',OrderDate as 'Satýþ Tarihi',c.ContactName as'Müþteri Adý-Soyadý' from Orders o 
--inner join Customers c on c.CustomerID=o.CustomerID
--inner join Employees e on o.EmployeeID=e.EmployeeID 

--select * from Customers

--inner join [Order Details] oD on p.ProductID=oD.ProductID
--inner join Orders o oN o.OrderID=oD.OrderID




-- ÖDEVVVVV
--1-hangi müþteri hangi üründen kaç dolarlýk alýþveriþ yapmýþtýr
--select * from [Order Details]

--2-hangi personel hangi kategorideki hangi ürünleri satmýþtýr

--3-ürünlerimizin adlarýný ve kategori adlarýný bir raporda gösteriniz


--4-Beverages  kategorisine ait stoklarda bulunan ürünleri raporlayýnýz


--5- Federal Shipping ile taþýnmýþ ne 'Nancy' nin almýþ olduðu sipariþleri gösteriniz

--6- company name arasýnda a harfi geçen müþterilerin vermiþ  olduðu Nancy Andrew Janet tarafýndan alýnmýþ Speedy Express tarafýndan taþýnmamýþ siparilere toplam ne kadarlýk kargo ücreti ödendiðini bulunuz

--7- en çok ürün aldýðýmýz 3 toptancýyý almýþ olduðumuz ürün miktarýna göre raporlayýnýz


--8- her bir üründen toplam ne kadarlýk satýþ yapýlmýþtýr ve o ürünler hangi kategorilere aittir


-- null olup olmamasýna aldýrýþ etmez altered joindir left right full 
--left join sorgudan önce yapýlmýþ tablo ve left olan tablodaki tüm kayýtlar null dahil getirilir.
--right ise yeni baðlanan tablodaki sadece iliþkili kayýtlarýn null dahil deðil getirilmesine 

--select * from Orders o left join Customers c on o.CustomerID=c.CustomerID

--select * from Products p left join Categories c on c.CategoryID=p.CategoryID

--select * from Products p right join Categories c on c.CategoryID=p.CategoryID

--select * from Products p full join Categories c on c.CategoryID=p.CategoryID

--ürünleri ve baðlý bulunduklarý kategorileri listeleyiniz ancak ürünü olmayan kategorilerde sonuca dahil edilsin

--select ProductName,CategoryName from Categories c left join Products p on c.CategoryID=p.CategoryID

-- LEFT JOIN = Soldaki tablonun tamamýný getirir ve solda tabloda boþ yerler varsa onu da getirir fakat saðdaki tablodan herhangi bir boþ getirmez.
-- RIGHT JOIN = Saðdaki tablonun tamamýný getirir ve saðda tabloda boþ yerler varsa onu da getirir fakat soldaki tablodan herhangi bir boþ getirmez.

-- ürünleri ve baðlý bulunduklarý katogorileri listeleyiniz 
--select ProductName,CategoryName from Categories c right join Products p on c.CategoryID=p.CategoryID

--hangi ürün hangi nakliye firmasý ile taþýnmýþtýr

--select ProductName,CompanyName from Orders o join Shippers s on o.ShipVia=s.ShipperID join [Order Details] oD on od.OrderID=o.OrderID join Products p on p.ProductID=oD.ProductID
--select * from Shippers

--hangi tedarikçiden toplam kaç tl ürün satýlmýþtýr.
-- supplioer produc order deat
--select CompanyName as 'Þirket Adý',  SUm(Quantity*od.UnitPrice) as 'Toplam Fiyat' from Suppliers s join Products p on p.SupplierID=s.SupplierID join [Order Details] oD on od.ProductID=p.ProductID group by CompanyName 

--select CompanyName as 'Þirket Adý', Sum(Quantity*od.UnitPrice) from suppliers s join Products p on p.SupplierID=s.SupplierID join [Order Details] oD on od.ProductID=p.ProductID group by CompanyName

-- kategorilerin toplam satýþlarýný raporlayýnýz

--select CategoryName,Sum(Quantity*od.UnitPrice)as 'Money Money'  from Categories c join Products p on c.CategoryID=p.CategoryID join [Order Details] oD on od.ProductID=p.ProductID group by CategoryName

--hangi personel hangi ürünü toplam kaç dolarlýk satmýþtýr
--employes order- order details