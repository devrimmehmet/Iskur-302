--- ÖDEV ---

--1- baeveres kategorisine ait amerikalý toptancýlar tarafýndan alýnmýþ stoklarýndan mevcut ürünlerin adlarýný ücretlerini ve kdvli ücretlerini gösteren view tasarla (baðlý bulunduðu kolonlar asla silinmemeli ve view kodlarý görünmemeli
--with schemabinding,encryption)
go
create view Odev
as
select   p.ProductName,p.UnitPrice,(p.UnitPrice*1.18) as 'KDV DAHÝL',c.CategoryName,s.Country,UnitsInStock from Categories c 
inner join Products p on p.CategoryID=c.CategoryID
inner join Suppliers s on s.SupplierID=p.SupplierID
inner join [Order Details] oD on od.ProductID=p.ProductID
where c.CategoryName= 'Beverages' and s.Country='USA' and UnitsInStock is not null
group by p.ProductName,p.UnitPrice,c.CategoryName,s.Country,p.UnitsInStock

go