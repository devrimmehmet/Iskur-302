
--GO
--create proc ZamYapıcı
--(
--@miktar money

--)
--as 
--update Products
--set UnitPrice+=@miktar
--go 
--ZamYapıcı 5
--select * from Products

-- dışardan girilen kategori adına ait ürünleri listeleyen proceduru tasarlayın

--GO
--create proc KategoriEkle
--(
--@KategoriEkle nvarchar(15)

--)
--as 
--select * from  Products p inner join Categories c on c.CategoryID=p.CategoryID where CategoryName=@KategoriEkle


--go 
--KategoriEkle 'Condiments'
--select * from Products

-- dışardan girilen kargo firmawsı tarafından taşınmış 
--ve yine dışardan girilen kargo ödemesi değer aralığındaki siparişleri listeleyen bir procedur tasarlayın

--GO
--create proc SiparisGetirici1
--(
--@KargoFirmasi nvarchar(40),
--@BaslangicFiyat int,
--@BitisFiyat int
--)
--as 
--select * from  Orders o inner join Shippers s on s.ShipperID =o.ShipVia where s.CompanyName=@KargoFirmasi and o.Freight<@BitisFiyat and o.Freight>@BaslangicFiyat
--go

--SiparisGetirici1 'United Package',80,100
--go 
--KategoriEkle 'Condiment


--dışardan girilen karakterlerin içerisinde barındıran müşteri adına sahip müşterilerce verilmiş siparişleri listeleyiniz

--GO
--create proc musteriSirketArama1
--(
--@MusteriSirketi nvarchar(40)
--)
--as 
--select * from Orders o inner join Customers c on c.CustomerID=o.CustomerID where c.CompanyName like '%'+@MusteriSirketi+'%'
--go
--musteriSirketArama1 'ak'
--SiparisGetirici1 'United Package',80,100
--go 

-- stok miktarı dışardan girilen iki değer arasında olan, ürün ücreti dışardan girilen iki değer arasında olan , toptancı firma adı dışardan girilen harfi barındıran ürünlerin adlarını, fiyatlarını, toptancı şirket adları , fiyatların kdv eklenmiş hallerini gösteren prosedürü tasarlayınız


--GO
--alter proc sirketadliarama
--(
--@StokBaslangic smallint,
--@StokBitis smallint,
--@FiyatBaslangic money,
--@FiyatBitis money,
--@SirketAdi nvarchar(40)
--)
--as 
--select p.ProductName,p.UnitPrice,s.CompanyName,(p.UnitPrice*1.18) as '+KDV' from  Suppliers s 
--inner join Products p on p.SupplierID=s.SupplierID 
--where (UnitsInStock BETWEEN @StokBaslangic and @StokBitis) and (UnitPrice between  @FiyatBaslangic and @FiyatBitis) and (s.CompanyName like '%'+@SirketAdi+'%')
--go
--sirketadliarama 10,40,40,110,'ltd'
--SiparisGetirici1 'United Package',80,100
--go 

--dışardan girilen çalışan idsi tarafından alınmış siparişleri listeleyiniz ancak dışardan kaç adet çalışan id geldiği bilinmemektedir.

--go
--alter proc CalisanaGore
--(
--@Id nvarchar(max)
--)
--as
--declare @sorgu nvarchar(max)
--set @sorgu= ('select OrderID,OrderDate,EmployeeID from Orders where EmployeeID in('+ @Id +') order by EmployeeID')
--execute (@sorgu)
--go

--CalisanaGore '1,5,7'

--dışardan girilen kategorinin adının ve tanımını ekleyen proceduryazınız giriniz

--select * from Categories

--go 
--create proc KategoriEkleee
--(
--@KategoriAdi nvarchar(15),
--@Tanim text
--)
--as
--IF (not exists (select * from Categories where CategoryName=@KategoriAdi))
--begin   insert into Categories (CategoryName,Description) values (@KategoriAdi,@Tanim) END
--ELSE BEGIN print  'Zaten Böyle Bir Kayıt Var';
--END;
--go
--insert into Categories (CategoryName,Description) values (@KategoriAdi,@Tanim)

--KategoriEkleee 'Deneme','Denemememememem'