-- �r�nler tablosundaki tedarik�i id ile tedarik�i tablosundaki tedarik�i id'yi e�le�tir ve tedarik�iler tablosundaki 
-- �irket ad� tedarik�i id'ye g�re �ekilsin
--SELECT*, (SELECT CompanyName FROM Suppliers WHERE Products.SupplierID=Suppliers.SupplierID) FROM Products
 
 -- �r�nlerle birlikte �r�n�n sat�� adetini listeleyen sorgu (SUM, OrdersDetails, Products)
--SELECT *, (SELECT Quantity FROM [Order Details] WHERE Products.ProductID = [Order Details].ProductID) AS 'Sat�� Adeti' FROM Products
	
 -- Hangi sat��tan ka� adet �r�n sat�lm���r. (COUNT, Orders, OrderDetails)
 -- SELECT *, (SELECT COUNT(Quantity) FROM [Order Details] WHERE Orders.OrderID= [Order Details].OrderID) AS 'Adet' FROM Orders

 -- 'VINET' id'li m��terinin sat��lar�n� listeleyiniz. (Orders, OrderDetails)
-- SELECT * ,(SELECT CustomerID FROM Orders  WHERE [Order Details].OrderID = Orders.OrderID) FROM [Order Details] WHERE OrderID in ((SELECT o.OrderID FROM Orders o WHERE o.CustomerID = 'VINET' ))

 -- 3 numaral� �r�n�n sat�� yap�ld��� m��terilerin id'lerini listeleyiniz. (OrderDetails, Orders)
 --SELECT *,(SELECT ProductID FROM [Order Details] WHERE
 --Orders.OrderID = [Order Details].OrderID AND ProductID = 3 ) AS ProductId FROM Orders 
 --WHERE OrderID in ((SELECT OrderID FROM [Order Details] WHERE ProductID = 3))
 
 --select CustomerID from orders in (select from )


 --select * from Products where ProductID=3
 --select CustomerID from Orders 
 --where OrderID in (select OrderID from [Order Details] where ProductID=3)

 --select * from Orders
 --select OrderID from [Order Details] where ProductID=3

-- select customerId from Orders where OrderID in ( select OrderID from [Order Details] where ProductID=3)


--hangi sat��ta ka� adet �r�n sat�lm��t�r.
--select *,(select * from [Order Details]) from Orders 
--select * from [Order Details]
--select * from [Order Details]
-- �r�nlerle birlikte �r�n�n sat�� adetini listeleyen sorgu 
--select * from Products
--select * from [Order Details] where ProductID=3

--hangi personel 