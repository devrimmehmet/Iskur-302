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



�DEVLER
-- �r�nlerle birlikte �r�n sat�� adetini listeleyen sorgu

select * from Products
select Quantity from [Order Details]

-- hangi sat��ta ka� adet �r�n sat�lm��t�r
select * from Orders
select * from [Order Details]

-- VINET ID isimli m��terinin sat��lar�n� listeleyiniz orders ve orderdetails