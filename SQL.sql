--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
sElEcT * from Products where categoryId=1 or categoryId=3

select * from Products where categoryId=1 and UnitPrice>=10

select * from Products where categoryId=1 order by UnitPrice desc    --ascending  --descending

Select count(*) Adet from Products
Select count(*) Adet from Products where CategoryID=2

select * from Products group by CategoryID /* çalışmaz group by ile * olmaz*/
select categoryID from Products group by CategoryID
select categoryID,count(*) from products where UnitPrice>20 
/* hangi kategoride ürün varsa onları listele ki oraları destekleylim*/
select categoryID,count(*) from products where UnitPrice>20 
group by CategoryID having count(*)<10

/*tekrar etmemek için join,on durumda,şartında*/
select * 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10 /*iki tabloda da unitprice var ise products. koymana gerek yok*/
/*innerjoin ik tabloyuda getirir**/

--DTO Data Transformation object

Select * from Products p inner join [Order Details] od   /*Order Detail ayrı diye köşeli parantez birleşik olsa idi köşeli parantez olmaz, p ve od alias*/
on p.ProductID = od.ProductID


/*inner join eşleşenler 2155*/
Select * from Products p inner join [Order Details] od 
on p.ProductID = od.ProductID
/*hiç satış yapılmayan ürünler getir ki kampanya olsun*/
/*ürünlerde olup sipariş detaylarında olmayan eşit 2155 */
Select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID

Select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID
/*müşteri,sisteme kayıt olmuş ama ürün almamış müşterileri getirip onlara kampanya uygulamak istiyorum ki aktif olmaları için*/
/*soldaki tabloda olup sağda olmayan*/
/*FISSA ve PARIS hiç ürün almamış*/
/*null data yok demek.OrderId null, primary key kullanılca CustomerID*/
Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

/*right join de sağda olup solda olmayanlar*/

Select * from Orders o left join  Customers c
on c.CustomerID = o.CustomerID
where o.CustomerID is null

/*ikiden fazla tablo join işlemi*/
Select * from Products p inner join [Order Details] od   
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

