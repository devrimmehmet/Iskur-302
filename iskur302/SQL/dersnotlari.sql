-- Select  
--select * from Employees Employees tablosunu 
-- �al��anlar�n ad ve soyadlar�yla birlikte ya�lar�n� raporlay�n�z.
--select FirstName,LastName,BirthDate from Employees
--select e.FirstName,e.LastName,e.BirthDate, DATEDIFF(YEAR,BirthDate,GETDATE()) as 'Ya�' from Employees e

-- �r�nlerimizin idlerini adlar�n� miktarlar�n� fiyatlar�n� ve fiyatlar�na %18 kdv eklenmi� hallerini raporlay�n�z.

--select pr.ProductID,pr.ProductName,pr.UnitPrice,UnitsInStock,UnitPrice*1.18 as 'Kdv Dahil', UnitsInStock*5 as 'can s�k�nt�s�'  from Products pr

--select sh.ShipperID,sh.CompanyName,sh.Phone from Shippers sh

-- tarihsel ifadeler
-- g�n�n tarihini alma
--select GETDATE() 
-- bir tarihin g�n�n� ay�n� y�l�n� alma
--select DAY(GETDATE())
--select MONTH(GETDATE())
--select YEAR(GETDATE())

-- girilen bir tarihe bir zaman dilimi ekleme
--select (YEAR(GETDATE())+5) --2027
--select DATEADD(YEAR,10,GETDATE())
--select DATEADD(MONTH,10,GETDATE())
--select DATEADD(DAY,50,GETDATE())

-- iki tarih aras�ndaki fark� alma

--select DATEDIFF (DAY,'1998',GETDATE())


-- �ZEL TAR�HSEL FONKS�YONLAR
--select DATENAME(MONTH,GETDATE())
--select DATENAME(DAYOFYEAR,GETDATE())
--select DATENAME(WEEK,GETDATE())

-- Where �artl� �ekim sql i�in

--select FirstName+ ' '+LastName as 'Ad-Soyad'  from Employees where city='London'

-- kategori id si 5 olmayan �r�nlerin adlar�n� ve kategori idlerini g�steriniz

--select ProductID,CategoryID, ProductName as '�r�n �smi' from Products where CategoryID!=5 and  CategoryID!=2 and ProductID!=10 and CategoryID!=7

-- 01 01 1993 tarihinden sonra i�e girmi� 

--select e.FirstName,e.LastName,e.HireDate from Employees e where HireDate>'1993-01-01'
-- mart ay�nda al�nm�� olan sipari�lerin id ve tarih de�erlerini raporlay�n�z
--select OrderID,OrderDate from Orders where MONTH(OrderDate)=3
--select OrderID,OrderDate from Orders where DATENAME (MONTH,OrderDate)='March'

-- �r�nler aras�nda stok miktar�  20 ile 50 aras�nda olan �r�nler listeleyin

--select * from Products where UnitsInStock>=20 and UnitsInStock<=50

--ya�� 50den b�y�k  ingilterede oturmayan �al��anlar�n adlar�n� ve ya�lar�n� raporlay�n�z. ancak isimler tablosu �u formatta olacak firstname in ilk harfi ve lastname


--select LEFT(FirstName,1)+'.'+LastName as 'Ad Soyad',  DATEDIFF(YEAR,BirthDate,GETDATE())as  'Ya�'  from Employees where Country!='UK' and DATEDIFF(YEAR,BirthDate,GETDATE())>50 


--1997den sonra al�nm�� kargo �creti 20den b�y�k ve fransaya g�nderilmemi� sipari�lerin sipari� tarihlerini teslim tarihlerini ve kargo �cretlerini raporlay�n�z
--Freight,RequiredDate,OrderDate,ShippedDate
--select Freight,OrderDate,ShippedDate from orders where OrderDate>='1997' and Freight>20 and ShipCountry!='France' and  ShippedDate is  not NULL

--select * from orders where  ShippedDate is not NULL

-- kimseye rapor vermeyen personelin ad�n� soyad�n� ve unvan�n� yazd�r�n 

--select LEFT(FirstName,1)+'.'+LastName as 'Ad Soyad' , Title as '�nvan' from Employees where ReportsTo is null

--1- Kategori id = 5 olan �r�n bedeli 20den b�y�k 300den k���k olan ve stok durumu null olmayan
--2- Dumon alfki  customer idlerine sahip olan m��teriler taraf�ndan al�nm�� 1 nolu personelin onaylad��� 3 nolu kargo firmas� taraf�ndan ta��nm�� ve shipregion null olmayan sipari�lerini g�steriniz
--3- sqlde indexleme nas�l yap�l�r ? indexleme ara�t�r sat�r bazl� kolon bazl� veriye g�re
--4- fiyat� 50den b�y�k olan �r�nlerden sat�� adeti en fazla olan 10 �r�n� listeleyiniz. ve e�it olan varsa hepsini g�stersin
--5- ba� harfi c olan stoklarda mevcut 10 ile 250 dolar aras� �creti olan �r�nlerin fiyatlar�na g�re listeleyiniz.i
--6- �ar�amba g�n� al�nan kargo �creti 20 ile 75 aras�nda olan teslim tarihi null olmayan sipari�lerin bilgilerini raporlay�n�z ve orderidye g�re b�y�kten k����e g�re s�ralay�n�z.
--7- Tablolar�n kolon isimlerinin hepsinin t�rk�esini ��reniyorsunuz.

--1- select * from Products where CategoryID=5 and UnitPrice>20 and UnitPrice<300 and UnitsInStock is not null
--2- select * from Orders where CustomerID='DUMON' or CustomerID='ALFKI' and EmployeeID=1
--4- select top 10 with TIES * from [Order Details] where UnitPrice>50 order by  Quantity desc
--5- SELECT * FROM Products WHERE UnitPrice BETWEEN 10 AND 75 AND UnitsInStock != '0' AND ProductName LIKE 'C%' ORDER BY UnitPrice ASC
--6- Select * from Orders where DATENAME (WEEKDAY,OrderDate)='Wednesday' and Freight between 20 and 75  and ShippedDate is not null order by OrderID desc

-- sadece 3,5,7,12,8 ifadelerini i�ermeyen �r�nleri bulunuz
--select * from Products where ProductID!=3 and ProductID!=5 and ProductID!=7 and ProductID!=8 and ProductID!=12 and ProductID!=4
 --select * from Products where  ProductID not in (3,5,4,7,12,8)
 --select * from Products where ProductName in ('Chai')

-- Order Line s�ralama
--select * from Products Order by ProductName
--select * from Products order by ProductID Desc -- tersi 
-- m��terilerin idlerini �irket adlar�n� ve �r�nlerini listeleyiniz �irket f�rans�z �irketi olacak idleri tersten s�ralanacak
--select CustomerID,CompanyName, Country from customers where Country='France' order by CustomerID desc

-- �r�nlerimizin adlar�n� �cretlerini stok miktarlar�n� g�steriniz stok miktar� 50den b�y�k ve �cretlere g�re s�ralama

--select ProductName,UnitPrice,UnitsInStock from Products where UnitsInStock>50 order by UnitPrice

--select top 30 ProductName,UnitPrice from Products order by UnitPrice

-- en fazla kargo �creti �denen sipari�in �deme ve id g�steriniz

--select top 1  OrderID,Freight from orders order by Freight desc

--sat�� detay tablosunda �r�nid �r�n fiyat� ve miktar� gelsin 
--select ProductID,UnitPrice,Quantity from [Order Details] order by ProductID
-- belli bir de�er aral���nda verilen stok miktar� 20den b�y�k 49den k���k �r�nler
--select * from Products where UnitsInStock between 20 and 49 -- 20 ve 50 aras�ndaki �r�nler 
--4- fiyat� 50den b�y�k olan �r�nlerden sat�� adeti en fazla olan 10 �r�n� listeleyiniz.e�it olanlar� g�stersin
--5- 01 01 1997 ile 06 06 1998 aras�ndaki sipari�leri listeleyiniz.

--select * from Orders where OrderDate between '1997-01-01' and '1998-06-06' order by OrderDate desc

--5- ba� harfi c olan stoklarda mevcut 10 ile 250 dolar aras� �creti olan �r�nlerin fiyatlar�na g�re listeleyiniz.i
--6- �ar�amba g�n� al�nan kargo �creti 20 ile 75 aras�nda olan teslim tarihi null olmayan sipari�lerin bilgilerini raporlay�n�z ve orderidye g�re b�y�kten k����e g�re s�ralay�n�z.

-- like tablolar i�erisinde arama ger�ekle�tirmek istiyorsak 

-- �lkesi olmayan ingiltere olmayan ad� a ile ba�lay�p soyad� r ile biten do�um tarihi 1985ten �nce olan �al��an kimdir?
--select * from Employees where FirstName like 'D%' and LastName like '%U' and BirthDate>1985 and Country!= 'UK'

--select * from Employees where notes like '%japan%'

-- stokta bulunan ka� �r�n vard�r

--select COUNT( *) from Products where UnitsInStock!=0

-- 1996dan sonra al�nm�� ka� adet sipari� vard�r

--select * from Orders where OrderDate>1996

-- ka� �lkede m��terimiz bulunmaktad�r. 

--select   country from Customers where Country='Turkey'