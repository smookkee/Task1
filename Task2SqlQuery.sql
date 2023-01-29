CREATE TABLE Products (
    Id int IDENTITY(1,1) primary key,
    Title varchar(256),
);

INSERT INTO Products (Title)
VALUES  ('prod1'),
		('prod2'),
		('prod3'),
		('prod4'),
		('prod5'),
		('prod6'),
		('prod7'),
		('prod8'),
		('prod9');

CREATE TABLE Categories (
    Id int IDENTITY(1,1) primary key,
    Title varchar(256),
);

INSERT INTO Categories (Title)
VALUES  ('Cat1'),
		('Cat2'),
		('Cat3');


Create table Products_to_categories(
	Id int IDENTITY(1,1) primary key,
	ProductId int FOREIGN KEY REFERENCES Products(Id),
	CategoryId int FOREIGN KEY REFERENCES Categories(Id),
)

INSERT INTO Products_to_categories (ProductId, CategoryId)
VALUES  (1, 1),
		(1, 2),
		(1, 3),
		(3, 1),
		(4, 2),
		(5, 3),
		(7, 1),
		(7, 2),
		(8, 2),
		(8, 3);

Select Products.Title, Categories.Title
From Products 
Left join Products_to_categories
ON Products.Id = Products_to_categories.ProductId
Left Join Categories 
ON Categories.Id = Products_to_categories.CategoryId
