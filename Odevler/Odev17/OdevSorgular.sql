-- Ürünler tablosundaki tedarikçi id ile tedarikçi tablosundaki tedarikçi id'yi eþleþtir ve tedarikçiler tablosundaki 
-- þirket adý tedarikçi id'ye göre çekilsin
-- SELECT*, (SELECT CompanyName FROM Suppliers WHERE Products.SupplierID=Suppliers.SupplierID) FROM Products
 
 -- Ürünlerle birlikte ürünün satýþ adetini listeleyen sorgu (SUM, OrdersDetails, Products)
-- SELECT *, (SELECT SUM(Quantity) FROM [Order Details] WHERE Products.ProductID = [Order Details].ProductID) AS 'Satýþ Adeti' FROM Products
	
 -- Hangi satýþtan kaç adet ürün satýlmýþýr. (COUNT, Orders, OrderDetails)
 -- SELECT *, (SELECT COUNT(Quantity) FROM [Order Details] WHERE Orders.OrderID= [Order Details].OrderID) AS 'Adet' FROM Orders

 -- 'VINET' id'li müþterinin satýþlarýný listeleyiniz. (Orders, OrderDetails)
-- SELECT * ,(SELECT CustomerID FROM Orders  WHERE [Order Details].OrderID = Orders.OrderID) FROM [Order Details] WHERE OrderID in ((SELECT o.OrderID FROM Orders o WHERE o.CustomerID = 'VINET' ))

 -- 3 numaralý ürünün satýþ yapýldýðý müþterilerin id'lerini listeleyiniz. (OrderDetails, Orders)
 --SELECT *,(SELECT ProductID FROM [Order Details] WHERE Orders.OrderID = [Order Details].OrderID AND ProductID = 3 ) AS ProductId FROM Orders
-- WHERE OrderID in ((SELECT OrderID FROM [Order Details] WHERE ProductID = 3))