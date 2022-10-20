--- �DEV ---

--1- baeveres kategorisine ait amerikal� toptanc�lar taraf�ndan al�nm�� stoklar�ndan mevcut �r�nlerin adlar�n� �cretlerini ve kdvli �cretlerini g�steren view tasarla (ba�l� bulundu�u kolonlar asla silinmemeli ve view kodlar� g�r�nmemeli
--with schemabinding,encryption)
go
create view Odev
with schemabinding,encryption
as
select   p.ProductName,p.UnitPrice,(p.UnitPrice*1.18) as 'KDV DAH�L',c.CategoryName,s.Country,UnitsInStock from dbo.Categories c 
inner join dbo.Products p on p.CategoryID=c.CategoryID
inner join dbo.Suppliers s on s.SupplierID=p.SupplierID
inner join dbo.[Order Details] oD on od.ProductID=p.ProductID
where c.CategoryName= 'Beverages' and s.Country='USA' and UnitsInStock is not null
group by p.ProductName,p.UnitPrice,c.CategoryName,s.Country,p.UnitsInStock

go