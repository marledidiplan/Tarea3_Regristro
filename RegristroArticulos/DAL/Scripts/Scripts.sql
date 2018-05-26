CREATE DATABASE DBArticulos
GO
USE DBArticulos
GO
CREATE TABLE ArticulosP
(
	ArticuloId int primary key identity(1,1),
	FechaVencimiento Datetime,
	Descripcion Varchar(40),
	Precio int,
	Existencia Int,
	CantidadCotizada int


);