--Crear base de datos Fonda
CREATE DATABASE Fonda;
USE Fonda
GO
--Crear Tabla Usuario
Create table dbo.Usuario(
	id varchar(255) PRIMARY KEY NOT NULL,
	direccion varchar(255) NOT NULL,
	celular varchar(255) NOT NULL,
	nombre varchar(255) NOT NULL,
	apellido varchar(255) NOT NULL
);
GO
--Crear Tabla Libro
--dateEscrito Es la fecha en la que fue escrito el libro
--datePublicado Es la fecha en el que se publico el libro
Create table dbo.Libro(
	id varchar(255) PRIMARY KEY NOT NULL,
	titulo varchar(255) NOT NULL,
	editorial varchar(255) NOT NULL,
	dateEscrito varchar(255) NOT NULL,
	datePublicado varchar(255) NOT NULL,
	autor varchar(255) NOT NULL
);

GO
--Crear Tabla Prestamo
--myEstudiante es el id del Usuario
--datePrestamo Es la fecha en la que se presto el libro
--dateDevolucion  Es la fecha en la que se devolvio el libro
--dateMaximaEntrega Es la fecha en la que se debe entregar el
Create table dbo.Prestamo(
	isbn varchar(255)  NOT NULL,
	myUsuario varchar(255) NOT NULL,
	datePrestamo varchar(255) NOT NULL,
	dateDevolucion varchar(255) NULL,
	dateMaximaEntrega varchar(255) NOT NULL,

);

GO
--Alerrar la tabla Prestamo para que tenga una cable primaria compuesta
ALTER TABLE dbo.Prestamo
	ADD CONSTRAINT pk_myConstraint PRIMARY KEY (isbn,myUsuario)
;
GO