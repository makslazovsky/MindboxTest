create table dbo.Categories
(
	Id int primary key,
	Name nvarchar(128) not null,
)
 
insert into dbo.Categories(Id, Name) values (1, 'p1')
insert into dbo.Categories(Id, Name) values (2, 'p2')
insert into dbo.Categories(Id, Name) values (3, 'p3')

create table dbo.Products
(
	Id int primary key,
	Name nvarchar(128) not null,
)
 
insert into dbo.Products(Id, Name) values (1, 'cheese')
insert into dbo.Products(Id, Name) values (2, 'milk')
insert into dbo.Products(Id, Name) values (3, 'water')
insert into dbo.Products(Id, Name) values (4, 'bread')

create table dbo.CategoryProducts
(
	Id int primary key,
	CategoryId int,
	ProductsId int
)
 
insert into dbo.CategoryProducts(Id, CategoryId, ProductsId) values (1, 1, 1)
insert into dbo.CategoryProducts(Id, CategoryId, ProductsId) values (2, 2, 2)
insert into dbo.CategoryProducts(Id, CategoryId, ProductsId) values (3, 3, 3)
insert into dbo.CategoryProducts(Id, CategoryId, ProductsId) values (4, 0, 4)



SELECT Categories.Name AS Categories_Name, Products.Name AS Products_Name
FROM Products LEFT JOIN (Categories RIGHT JOIN CategoryProducts ON Categories.[Id] = CategoryProducts.[CategoryId]) ON Products.[Id] = CategoryProducts.[ProductsId];
