-- Select  
--select * from Employees Employees tablosunu 
-- çalýþanlarýn ad ve soyadlarýyla birlikte yaþlarýný raporlayýnýz.
--select FirstName,LastName,BirthDate from Employees
--select e.FirstName,e.LastName,e.BirthDate, DATEDIFF(YEAR,BirthDate,GETDATE()) as 'Yaþ' from Employees e

-- ürünlerimizin idlerini adlarýný miktarlarýný fiyatlarýný ve fiyatlarýna %18 kdv eklenmiþ hallerini raporlayýnýz.

--select pr.ProductID,pr.ProductName,pr.UnitPrice,UnitsInStock,UnitPrice*1.18 as 'Kdv Dahil', UnitsInStock*5 as 'can sýkýntýsý'  from Products pr

--select sh.ShipperID,sh.CompanyName,sh.Phone from Shippers sh

-- tarihsel ifadeler
-- günün tarihini alma
--select GETDATE() 
-- bir tarihin gününü ayýný yýlýný alma
--select DAY(GETDATE())
--select MONTH(GETDATE())
--select YEAR(GETDATE())

-- girilen bir tarihe bir zaman dilimi ekleme
--select (YEAR(GETDATE())+5) --2027
--select DATEADD(YEAR,10,GETDATE())
--select DATEADD(MONTH,10,GETDATE())
--select DATEADD(DAY,50,GETDATE())

-- iki tarih arasýndaki farký alma

--select DATEDIFF (DAY,'1998',GETDATE())


-- ÖZEL TARÝHSEL FONKSÝYONLAR
--select DATENAME(MONTH,GETDATE())
--select DATENAME(DAYOFYEAR,GETDATE())
--select DATENAME(WEEK,GETDATE())

-- Where Þartlý çekim sql için

--select FirstName+ ' '+LastName as 'Ad-Soyad'  from Employees where city='London'

-- kategori id si 5 olmayan ürünlerin adlarýný ve kategori idlerini gösteriniz

--select ProductID,CategoryID, ProductName as 'Ürün Ýsmi' from Products where CategoryID!=5 and  CategoryID!=2 and ProductID!=10 and CategoryID!=7

-- 01 01 1993 tarihinden sonra iþe girmiþ 

--select e.FirstName,e.LastName,e.HireDate from Employees e where HireDate>'1993-01-01'
-- mart ayýnda alýnmýþ olan sipariþlerin id ve tarih deðerlerini raporlayýnýz
--select OrderID,OrderDate from Orders where MONTH(OrderDate)=3
--select OrderID,OrderDate from Orders where DATENAME (MONTH,OrderDate)='March'

-- ürünler arasýnda stok miktarý  20 ile 50 arasýnda olan ürünler listeleyin

--select * from Products where UnitsInStock>=20 and UnitsInStock<=50

--yaþý 50den büyük  ingilterede oturmayan çalýþanlarýn adlarýný ve yaþlarýný raporlayýnýz. ancak isimler tablosu þu formatta olacak firstname in ilk harfi ve lastname


--select LEFT(FirstName,1)+'.'+LastName as 'Ad Soyad',  DATEDIFF(YEAR,BirthDate,GETDATE())as  'Yaþ'  from Employees where Country!='UK' and DATEDIFF(YEAR,BirthDate,GETDATE())>50 


--1997den sonra alýnmýþ kargo ücreti 20den büyük ve fransaya gönderilmemiþ sipariþlerin sipariþ tarihlerini teslim tarihlerini ve kargo ücretlerini raporlayýnýz
--Freight,RequiredDate,OrderDate,ShippedDate
--select Freight,OrderDate,ShippedDate from orders where OrderDate>='1997' and Freight>20 and ShipCountry!='France' and  ShippedDate is  not NULL

--select * from orders where  ShippedDate is not NULL

-- kimseye rapor vermeyen personelin adýný soyadýný ve unvanýný yazdýrýn 

--select LEFT(FirstName,1)+'.'+LastName as 'Ad Soyad' , Title as 'Ünvan' from Employees where ReportsTo is null

--1- Kategori id = 5 olan ürün bedeli 20den büyük 300den küçük olan ve stok durumu null olmayan
--2- Dumon alfki  customer idlerine sahip olan müþteriler tarafýndan alýnmýþ 1 nolu personelin onayladýðý 3 nolu kargo firmasý tarafýndan taþýnmýþ ve shipregion null olmayan sipariþlerini gösteriniz
--3- sqlde indexleme nasýl yapýlýr ? indexleme araþtýr satýr bazlý kolon bazlý veriye göre
--4- fiyatý 50den büyük olan ürünlerden satýþ adeti en fazla olan 10 ürünü listeleyiniz. ve eþit olan varsa hepsini göstersin
--5- baþ harfi c olan stoklarda mevcut 10 ile 250 dolar arasý ücreti olan ürünlerin fiyatlarýna göre listeleyiniz.i
--6- çarþamba günü alýnan kargo ücreti 20 ile 75 arasýnda olan teslim tarihi null olmayan sipariþlerin bilgilerini raporlayýnýz ve orderidye göre büyükten küçüðe göre sýralayýnýz.
--7- Tablolarýn kolon isimlerinin hepsinin türkçesini öðreniyorsunuz.

--1- select * from Products where CategoryID=5 and UnitPrice>20 and UnitPrice<300 and UnitsInStock is not null
--2- select * from Orders where CustomerID='DUMON' or CustomerID='ALFKI' and EmployeeID=1
--4- select top 10 with TIES * from [Order Details] where UnitPrice>50 order by  Quantity desc
--5- SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 75 AND UnitsInStock != '0' AND ProductName LIKE 'C%' ORDER BY UnitPrice ASC
--6- Select * from Orders where DATENAME (WEEKDAY,OrderDate)='Wednesday' and Freight between 20 and 75  and ShippedDate is not null order by OrderID desc

-- sadece 3,5,7,12,8 ifadelerini içermeyen ürünleri bulunuz
--select * from Products where ProductID!=3 and ProductID!=5 and ProductID!=7 and ProductID!=8 and ProductID!=12 and ProductID!=4
 --select * from Products where  ProductID not in (3,5,4,7,12,8)
 --select * from Products where ProductName in ('Chai')

-- Order Line sýralama
--select * from Products Order by ProductName
--select * from Products order by ProductID Desc -- tersi 
-- müþterilerin idlerini þirket adlarýný ve ürünlerini listeleyiniz þirket fýransýz þirketi olacak idleri tersten sýralanacak
--select CustomerID,CompanyName, Country from customers where Country='France' order by CustomerID desc

-- ürünlerimizin adlarýný ücretlerini stok miktarlarýný gösteriniz stok miktarý 50den büyük ve ücretlere göre sýralama

--select ProductName,UnitPrice,UnitsInStock from Products where UnitsInStock>50 order by UnitPrice

--select top 30 ProductName,UnitPrice from Products order by UnitPrice

-- en fazla kargo ücreti ödenen sipariþin ödeme ve id gösteriniz

--select top 1  OrderID,Freight from orders order by Freight desc

--satýþ detay tablosunda ürünid ürün fiyatý ve miktarý gelsin 
--select ProductID,UnitPrice,Quantity from [Order Details] order by ProductID
-- belli bir deðer aralýðýnda verilen stok miktarý 20den büyük 49den küçük ürünler
--select * from Products where UnitsInStock between 20 and 49 -- 20 ve 50 arasýndaki ürünler 
--4- fiyatý 50den büyük olan ürünlerden satýþ adeti en fazla olan 10 ürünü listeleyiniz.eþit olanlarý göstersin
--5- 01 01 1997 ile 06 06 1998 arasýndaki sipariþleri listeleyiniz.

--select * from Orders where OrderDate between '1997-01-01' and '1998-06-06' order by OrderDate desc

--5- baþ harfi c olan stoklarda mevcut 10 ile 250 dolar arasý ücreti olan ürünlerin fiyatlarýna göre listeleyiniz.i
--6- çarþamba günü alýnan kargo ücreti 20 ile 75 arasýnda olan teslim tarihi null olmayan sipariþlerin bilgilerini raporlayýnýz ve orderidye göre büyükten küçüðe göre sýralayýnýz.

-- like tablolar içerisinde arama gerçekleþtirmek istiyorsak 

-- ülkesi olmayan ingiltere olmayan adý a ile baþlayýp soyadý r ile biten doðum tarihi 1985ten önce olan çalýþan kimdir?
--select * from Employees where FirstName like 'D%' and LastName like '%U' and BirthDate>1985 and Country!= 'UK'

--select * from Employees where notes like '%japan%'

-- stokta bulunan kaç ürün vardýr

--select COUNT( *) from Products where UnitsInStock!=0

-- 1996dan sonra alýnmýþ kaç adet sipariþ vardýr

--select * from Orders where OrderDate>1996

-- kaç ülkede müþterimiz bulunmaktadýr. 

--select   country from Customers where Country='Turkey'