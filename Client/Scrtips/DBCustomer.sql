
Create Database DBCustomer
go

Use DBCustomer

Create Table Client(
IdClient int primary key identity,
NameClient varchar(50),
Ege int,
BirthDate DateTime,
Direction varchar(50)
)
go

Insert Into Client(NameClient,Ege,BirthDate,direction)
Values
('Miguel',32, 2021-08-15, 'Calle 10 # 5-51'),
('Juan',46, 1974-11-06, 'Avenida 19 No. 98-03'),
('Pedro',26, 1996-02-31, 'Calle 53 No 10-60/46'),
('Antonio',52, 1879-01-20, 'Avenida Calle 26 No 59-51'),
('Estiven',60, 1654-07-11, 'Calle 9 # 9 – 62'),
('Maikol',15, 2021-09-04, 'Calle 19 # 80A-40'),
('Carlos',23, 2020-04-29, 'Carrera 21 # 17 -63'),
('Laura',24, 1999-06-09, 'Carrera 42 # 54-77'),
('Sofia',55, 1843-07-13, 'Calle 100 # 11B-27'),
('Natalia',10, 2023-01-19, 'Carrera 20 B # 29-18')
