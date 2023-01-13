
--Создание таблицы Customers
CREATE TABLE Customers

(Id int identity(1,1) not null primary key,
Name varchar(50) not null)
--Создание таблицы Orders
CREATE TABLE Orders

(Id int identity(1,1) not null primary key,
CustomerId int not null)

--Заполнение таблицы Customers
insert Customers values('Max')
insert Customers values('Pavel')
insert Customers values('Ivan')
insert Customers values('Leonid')
--Заполнение таблицы Orders
insert Orders values(2)
insert Orders values(4)

--Запрос на вывод пользователей, которые не совершали покупок
SELECT Customers.Name AS Customers
FROM Customers 
FULL JOIN Orders ON Orders.CustomerId = Customers.Id
WHERE Orders.CustomerId IS NULL