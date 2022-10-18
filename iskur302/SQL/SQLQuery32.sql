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



ÖDEVLER
-- ürünlerle birlikte ürün satýþ adetini listeleyen sorgu

select * from Products
select Quantity from [Order Details]

-- hangi satýþta kaç adet ürün satýlmýþtýr
select * from Orders
select * from [Order Details]

-- VINET ID isimli müþterinin satýþlarýný listeleyiniz orders ve orderdetails