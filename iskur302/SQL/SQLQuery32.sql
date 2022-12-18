--group by yap�s�
--grupland�rma i�lemi i�in kullan�lan anahtar kelimedir as�l ortaya ��k�� amac� avg max min sum count gibi aggregate
--fonksiyonlarla birlikte ba�l� bulunduklar� kolonlar�da sorgu i�erisine dahil etmektir.
-- �Lkelere g�re �al��an say�m�z?
--select country, count (Country) as 'Toplam �al��an' from Employees group by Country
--select country from Employees
--select [CategoryID3,],count (CategoryID) as '�r�n Adeti'  from Products group by CategoryID order by ProductID desc

--select EmployeeID,count(EmployeeID) as 'A' from Orders group by EmployeeID order by 'A' desc
--�lkere g�re sipari� say�lar�n� s�ralay�n�z en �ok sipari� veren �lkeyi 
--select top 3 ShipCountry, count(OrderID) as 'Sayi' from Orders group by ShipCountry order by Sayi desc

--her bir kategoride �cret bazl� toplam ne kadarl�k �r�n vard�r 
--select SUM (UnitPrice*UnitsInStock) as 'Toplam' from Products group by CategoryID order by Toplam desc

--hangi personel ka� sat��ta yer alm��t�r
 --select EmployeeID,count(EmployeeID) as 'Personel' from Orders group by EmployeeID order by Personel desc

 --hangi m��teri ka� kere al��veri� yapm��t�r.

--select CustomerID,count(CustomerID) as 'M��teri' from Orders group by CustomerID order by M��teri desc

--hangi tedarik�i hangi kategorideki �r�nden ka� dolarl�k mevcuttur
--select SupplierID,Sum(UnitPrice*UnitsInStock) as'Toplam' from Products group by SupplierID order by Toplam desc

--i� i�e sorgular SUBQUERY YAPISI--

-- i� i�e select sorgular�d�r  i�teki select sorgusundan gelen cevab�n d��taki select sorgusuna dahil edilerek 
-- bir sonu� dahilinde raporlanmas� i�lemine yard�mc� olur
--inner join yetersiz oldu�u durumlarda, having i�leminin size cevap vermedi�i durumlarda

-- ortalama �cretin �zerinde yer alan �r�nleri g�steriniz

--select ProductName, UnitPrice from Products 
--where UnitPrice> (select AVG(UnitPrice) from Products)

--select ProductName,UnitPrice, avg (UnitPrice) as 'a' from Products
--where UnitPrice >a

-- nacy vermi� oldu�u sipari�lerin idlerini raporlay�n�z
--select OrderID,EmployeeID from Orders  where
--EmployeeID=(select EmployeeID from Employees 
--where FirstName='nancy')

-- beverages ' in 
--select ProductID,ProductName from Products where CategoryID=(select CategoryID from Categories where CategoryName='Beverages'

-- 'nancy' yada 'andrew' yada 'janet' taraf�ndan al�nm�� speedy express ile ta��nm�� sipari�leri listeleyiniz

--select * from orders where ShipVia!=(select ShipperID from Shippers where CompanyName ='Speedy Express') and ( EmployeeID=(select EmployeeID from Employees where FirstName='Nancy') 
--or EmployeeID=(select EmployeeID from Employees where FirstName='Andrew')or EmployeeID=(select EmployeeID from Employees where FirstName='Janet'))


-- ALT SORGULAR -- 
-- Belli bir sorgu i�inde ba�ka bir sorgu �al��t�rma 
--select *, (select CompanyName from Suppliers s where p.SupplierID=s.SupplierID) from Products p



--�DEVLER
-- �r�nlerle birlikte �r�n sat�� adetini listeleyen sorgu

--select * from Products
--select Quantity from [Order Details]

-- hangi sat��ta ka� adet �r�n sat�lm��t�r
--select * from Orders
--select * from [Order Details]

-- VINET ID isimli m��terinin sat��lar�n� listeleyiniz orders ve orderdetails

-- JOINLER -- 
--�ki tabloyu ili�kili kolonlar �zerinden birbirine ba�lar
-- tablolar�n denormalize �eklinde sorgulanmalar�n� sa�lr
--inner join ili�kili kolonlarda 
--OUTER  join
--cross join

--SELECT * FROM kategoriler INNER JOIN urunler ON kategoriler.kat_id = urunler.kat_id;
--select * from Categories
--select * from Products
--select * from Products p  inner join Categories c on p.CategoryID=c.CategoryID

-- �r�nleri tedarik�i �irketlerin adlar� ile listeleyiniz 



--select ProductName,CompanyName 


--from Products p inner join Suppliers s 

--on p.SupplierID=s.SupplierID

--select * from Suppliers

--select * from Products1

-- �r�nlerin sat�� raporunu �r�n ad� sat�� fiyat� adet indirim kolonlar�n� rapor et

--select ProductName,oD.UnitPrice,Quantity,Discount from Products p inner join [Order Details] oD on p.ProductID=oD.ProductID 
--select * from [Order Details]

-- hangi sat��ta hangi �r�nler sat�lm��t�r.
--select o.OrderID,ProductName from Products p 
--inner join [Order Details] oD on p.ProductID=oD.ProductID
--inner join Orders o oN o.OrderID=oD.OrderID

--select * from [Order Details]
--select * from Products
--select * from orders

-- hangi personel hangi m��teriye hangi tarihte sat�� yapm��t�r.

--select * from [Order Details]
--select left( e.FirstName,1)+ '. '+e.LastName as 'Personel Ad Soyad',OrderDate as 'Sat�� Tarihi',c.ContactName as'M��teri Ad�-Soyad�' from Orders o 
--inner join Customers c on c.CustomerID=o.CustomerID
--inner join Employees e on o.EmployeeID=e.EmployeeID 

--select * from Customers

--inner join [Order Details] oD on p.ProductID=oD.ProductID
--inner join Orders o oN o.OrderID=oD.OrderID




-- �DEVVVVV
--1-hangi m��teri hangi �r�nden ka� dolarl�k al��veri� yapm��t�r
--select * from [Order Details]

--2-hangi personel hangi kategorideki hangi �r�nleri satm��t�r

--3-�r�nlerimizin adlar�n� ve kategori adlar�n� bir raporda g�steriniz


--4-Beverages  kategorisine ait stoklarda bulunan �r�nleri raporlay�n�z


--5- Federal Shipping ile ta��nm�� ne 'Nancy' nin alm�� oldu�u sipari�leri g�steriniz

--6- company name aras�nda a harfi ge�en m��terilerin vermi�  oldu�u Nancy Andrew Janet taraf�ndan al�nm�� Speedy Express taraf�ndan ta��nmam�� siparilere toplam ne kadarl�k kargo �creti �dendi�ini bulunuz

--7- en �ok �r�n ald���m�z 3 toptanc�y� alm�� oldu�umuz �r�n miktar�na g�re raporlay�n�z


--8- her bir �r�nden toplam ne kadarl�k sat�� yap�lm��t�r ve o �r�nler hangi kategorilere aittir


-- null olup olmamas�na ald�r�� etmez altered joindir left right full 
--left join sorgudan �nce yap�lm�� tablo ve left olan tablodaki t�m kay�tlar null dahil getirilir.
--right ise yeni ba�lanan tablodaki sadece ili�kili kay�tlar�n null dahil de�il getirilmesine 

--select * from Orders o left join Customers c on o.CustomerID=c.CustomerID

--select * from Products p left join Categories c on c.CategoryID=p.CategoryID

--select * from Products p right join Categories c on c.CategoryID=p.CategoryID

--select * from Products p full join Categories c on c.CategoryID=p.CategoryID

--�r�nleri ve ba�l� bulunduklar� kategorileri listeleyiniz ancak �r�n� olmayan kategorilerde sonuca dahil edilsin

--select ProductName,CategoryName from Categories c left join Products p on c.CategoryID=p.CategoryID

-- LEFT JOIN = Soldaki tablonun tamam�n� getirir ve solda tabloda bo� yerler varsa onu da getirir fakat sa�daki tablodan herhangi bir bo� getirmez.
-- RIGHT JOIN = Sa�daki tablonun tamam�n� getirir ve sa�da tabloda bo� yerler varsa onu da getirir fakat soldaki tablodan herhangi bir bo� getirmez.

-- �r�nleri ve ba�l� bulunduklar� katogorileri listeleyiniz 
--select ProductName,CategoryName from Categories c right join Products p on c.CategoryID=p.CategoryID

--hangi �r�n hangi nakliye firmas� ile ta��nm��t�r

--select ProductName,CompanyName from Orders o join Shippers s on o.ShipVia=s.ShipperID join [Order Details] oD on od.OrderID=o.OrderID join Products p on p.ProductID=oD.ProductID
--select * from Shippers

--hangi tedarik�iden toplam ka� tl �r�n sat�lm��t�r.
-- supplioer produc order deat
--select CompanyName as '�irket Ad�',  SUm(Quantity*od.UnitPrice) as 'Toplam Fiyat' from Suppliers s join Products p on p.SupplierID=s.SupplierID join [Order Details] oD on od.ProductID=p.ProductID group by CompanyName 

--select CompanyName as '�irket Ad�', Sum(Quantity*od.UnitPrice) from suppliers s join Products p on p.SupplierID=s.SupplierID join [Order Details] oD on od.ProductID=p.ProductID group by CompanyName

-- kategorilerin toplam sat��lar�n� raporlay�n�z

--select CategoryName,Sum(Quantity*od.UnitPrice)as 'Money Money'  from Categories c join Products p on c.CategoryID=p.CategoryID join [Order Details] oD on od.ProductID=p.ProductID group by CategoryName

--hangi personel hangi �r�n� toplam ka� dolarl�k satm��t�r
--employes order- order details

--- HAVING YAPISI ---
/* Agregate fonksiyonlar arac�l��� ile al�nan sonu�lar bir where kriteri i�erisinde kullan�lmamaktad�r.
Bunun yerine (where yerine) kulland���m�z anahtar kelime 'having' anahtar kelimesidir... */
/* Having group by'in fonksiyonudur. */
-- toplam sipari� miktar� 1200'�n �zerinde olan �r�nlerin adlar�n� ve sipari� miktarlar�n� g�steriniz.

--select p.ProductName,SUM(od.Quantity) as 'Toplam' from Orders o inner join [Order Details] od on o.OrderID=od.OrderID inner join Products p on p.ProductID=od.ProductID  group by ProductName  having SUM(Quantity)>1200 order by Toplam desc

-- hangi personel hangi �r�n� toplam ka� dolarl�k satm��t�r.

--select * from [Order Details] od inner join 

--SELECT e.FirstName+' '+e.LastName as 'Ad-Soyad', p.ProductName as '�r�n', SUM(od.Quantity * od.UnitPrice * (1-Discount)) As 'Toplam' FROM Products p 
--INNER JOIN [Order Details] od ON p.ProductID = od.ProductID 
--INNER JOIN Orders o ON o.OrderID = od.OrderID  
--inner join Employees e on e.EmployeeID=o.EmployeeID
--GROUP BY e.FirstName,e.LastName , p.ProductName
--having SUM(od.Quantity * od.UnitPrice * (1-Discount))>1000
--order by Toplam desc

-- 250den fazla kargo sipari� ta��m�� olan kargo firmalar�n�n adlar�n� telefon nolar�n� ve sipari� miktarlar�n� raporlay�n�z 

--select s.CompanyName,s.Phone,Count(o.ShipVia) As 'Toplam'  from Shippers s 
--inner join Orders o on o.ShipVia=s.ShipperID
--group by s.CompanyName,s.Phone,o.ShipVia
--having Count(o.ShipVia)>250


-- insert i�lemleri var olan bir veri kayna��na yeni bir veri eklemek i�in kullan�lan yap�d�r
-- e�er tablonuzdaki t�m kolonlara insert i�lemi ger�ekle�tiriyorsan�z tek tek kolon adlar�n� yazmak zorunda de�ilsiniz. ancak dikkat edilmesi gereken nokta kolon s�ralamalar�n� iyi biliyor olmam�z gereklidir.
-- insert into tabloISMI(kolon1,kolon2,kolon3,...) values (deger1,deger2,deger3)

-- varolan bir veri kayna��ndaki verilerinizin yeni de�erlerle g�ncellenmesini sa�layan yap�d�r e�er update i�leminde where kriterini unutursan�z b�t�n kay�tlar�n�z ayn� de�erlerle g�ncellenir.

--6 nolu kargo firmas�n�n telefon numaras�n� (212 888 4447) olarak g�ncelleyiniz.


--INSERT INTO Shippers
--         (CompanyName,Phone)
           
--    VALUES
----          ('302 Cemaat','5438887776')
--	  select * from Shippers
--update Shippers set Phone='0900 123 3456' where ShipperID=6

-- �al��anlar tablosundaki nancy adl� �al��an�n do�um tarihini 01 01 1967 olarak g�ncelleyiniz �ehiri erzincan olarak de�i�tiriniz

--select * from Employees where EmployeeID=1

--update Employees set BirthDate='01.01.1967' ,City='Kastamonu' where EmployeeID=1

--sto�u 10dna k���k �r�nlere %6 zam yap�n

--select UnitPrice,UnitPrice*1.06 from Products
--update Products set UnitPrice=UnitPrice*1.01 where UnitsInStock<10
--select * from Products

--select UnitPrice,UnitPrice*1.06 from Products where UnitsInStock<10
--select UnitPrice,UnitPrice*1.06 from Products where UnitsInStock<10i

--varolan bir veri kayna��ndaki verilerimizin tamamiyle silinmesi i�in gerkeen yap�d�r. 
--e�er delete i�leminde where kriterini unutursan�z b�t�n kay�tlar ayn� anda silinir.

--kargo tablosundaki 3ten b�y�k kay�tlar� silin
--select * from Shippers 
--delete from Shippers where ShipperID>3

-- view i�erisinde �ok fazla i�lem ger�ekle�tiriyorsan�z ve �stelik buna defalarca ihtiyac�n�z varsa view nesnesini kullan�rs�n�z sorgunuzun t�pk� bir sanal tabloymu�cas�na saklar ve her defas�nda art�k o tablodan sorgular�n �ekilmesini ister �rne�in 

-- amerikal� m��terilerden al�nm�� sipari�leri listeleyen bir sorgu tasarlay�n�z ve bir view i�erisinde saklay�n�z

--select * from Orders o inner join Customers c on o.CustomerID=c.CustomerID where Country='USA'

--go 
--create view  Amerikal�lar
-- as
--select c.CustomerID,CompanyName,OrderID,Country from Orders o 
--inner join Customers c on o.CustomerID=c.CustomerID 
--where c.Country='USA'
--go

--view ile sanal tablo olu�turulur bizzat veri tutmaz her �al��aca�� zaman compiler edilmez h�z kazand�r�r g�venlik sa�lar mesela personel tablosunda select yaparken sizin personel maa��n� g�rmeniz laz�mken ba�ka hi� kimse g�rmesin demektir. 