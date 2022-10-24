-- select o.id as 'Sipariş-Id',
-- CONCAT(LEFT( c.first_name,1),'. ',c.last_name) as 'Ad-Soyad',
-- o.order_date as 'Sipariş Tarihi' 
-- from orders o 
-- inner join customers c
-- on o.customer_id=c.id
-- where c.city='New York'


-- select o.id as 'Sipariş-Id',
-- p.product_name as 'Ürün Adı',
-- (od.unit_price*od.quantity) as 'Toplam Tutar',
-- CONCAT(c.first_name,' ',c.last_name) as AdSoyad,
-- o.order_date as 'Sipariş Tarihi' 
-- from orders o 
-- inner join customers c on o.customer_id=c.id
-- inner join order_details od on od.order_id=o.id
-- inner join products p on p.id=od.product_id
-- order by AdSoyad

-- select o.id as 'Sipariş-Id',
-- p.product_name as 'Ürün Adı',
-- SUM((od.unit_price*od.quantity)) as 'Toplam Tutar',
-- concat ( c.first_name, ' ', c.last_name ) as AdSoyad,
-- o.order_date as 'Sipariş Tarihi'
-- from orders o 
-- inner join customers c on o.customer_id=c.id
-- inner join order_details od on od.order_id=o.id
-- inner join products p on p.id=od.product_id
-- group by o.id

-- select c.first_name,o.id as Orderid from customers c
-- Left join orders o
-- on o.customer_id=c.id
-- where o.id is null
-- order by c.first_name

-- select p.id,p.product_name from products p
-- left join order_details od on p.id =od.product_id
-- where od.id is null

-- select o.id,e.first_name from orders o right join employees e on o.employee_id=e.id
-- where o.id is null
-- order by o.id

-- Hangi üründen kaç kere sipariş verilmiş?
-- select p.id,p.product_name,count(*) as 'Adet' from products p inner join order_details od on p.id=od.product_id group by p.id order by adet desc


-- En çok kazandıran ilk 3 ürün hangisidir?
-- select  p.id,p.product_name, sum(od.quantity*od.unit_price) as 'kazanc' from products p inner join order_details od on p.id=od.product_id group by p.id order by kazanc desc limit 3


-- Hangi kargo şirketleirne toplam ne kadar ödeme yapılmış? 

-- select s.company, SUM(o.shipping_fee) as 'Toplam kargo Ücreti' from orders o left join shippers s on s.id=o.shipper_id  group by o.shipper_id order by SUM(o.shipping_fee)


-- En uygun Kargo ücreti hangisidir?
-- select s.company, avg(o.shipping_fee) from orders o inner join shippers s on s.id=o.shipper_id  where shipping_fee >0 group by  s.id having count(o.id)>10

-- seçilen kayıtların farklı tabloya eklenmesi
-- insert into employee_performans (employee_id,fullname,email,satis_adeti)
-- select e.id, concat(e.first_name,' ',e.last_name) as fullname, e.email_address,count( o.id) as Adet from employees e left join  orders o on e.id=o.employee_id group by e.id

-- join ile update

-- update employees e inner join employee_performans ep on e.id=ep.employee_id set e.email_address=ep.email where ep.email like '%updated%'

-- siparişi olmayan müşterileri siliniz.
-- select c.id,c.first_name from customers c left join orders o on o.customer_id=c.id where o.customer_id is null

-- delete customers from customers left join orders on orders.customer_id=customers.id where orders.customer_id is null and customers.id=13

-- union ile çalışma // alt alta birleştirme işlemi

-- select email from employee_performans union all select email_address from employees
-- select city from employees union select city from customers

-- select id,order_date from orders where status_id= (select id from  orders_status where status_name='Shipped' )

-- select c.first_name, c.last_name, (select count(o.id) from orders o where o.customer_id=c.id)as ordercount from customers c

-- select id,product_name from products where id in ( select product_id from order_details where quantity>100 )

-- sql exist kullanımı 

-- select id, first_name from customers c where EXISTS(select id from orders o where c.id=o.customer_id and payment_type='Credit Card')

-- select id, first_name,last_name from customers c where EXISTS (select count(*) from orders o where c.id=o.customer_id group by o.customer_id having count(*)>2)

-- DERS: ANY & ALL --
-- select id,product_name,list_price from products where id in (2,3,5,10)
-- (id=2) or (id=3) or (id=5) or (id=10)

-- select id, product_name,list_price from products where id = any( select product_id from order_details where quantity>10)

-- (id=2) and (id=3) and (id=5) and  (id=10)
-- select id, product_name,list_price from products where id > all( select product_id from order_details where quantity>10)

