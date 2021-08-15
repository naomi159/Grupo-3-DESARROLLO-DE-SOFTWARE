--------------------------------------------------------------------------
---- CREACION DE LA BASE DE DATOS BDTutoria
--------------------------------------------------------------------------
use master
go
if exists (select * from sysdatabases where name = 'BDTutoria')
drop database BDTutoria
go
create database BDTutoria
go

use BDTutoria
go

--------------------------------------------------------------------------
--- CREACION DE LA TABLA DOCENTE
--------------------------------------------------------------------------
create table Docente
(	-- lista de atributos
	--CodDocente   TCod_Docente,
	--CodDocente int identity(10000,1) not null,
	CodDocente  varchar(5)    not null,
    Nombres     varchar(20)  not null,
	ApellidoPaterno     varchar(25)  not null,
    ApellidoMaterno     varchar(25)  not null,
    Clase       varchar(20)  not null,
	Categoria   varchar(20)  not null,
	Regimen     varchar(20) not null,
    CarreraProfesional  varchar(4) not null,
	-- definición de claves
	primary key (CodDocente)
)
go

--------------------------------------------------------------------------
--- CREACION DE LA TABLA ESTUDIANTE
--------------------------------------------------------------------------
create table Estudiante
(	-- lista de atributos
 CodEstudiante			varchar(6)    not null,
 Nombres     			varchar(45)   not null,
 ApellidoPaterno		varchar(35)   not null,
 ApellidoMaterno		varchar(35)   not null,
 CarreraProfesional    varchar(4)   not null,
 Condicion		        varchar(10)   not null,
 --definicion de claves
 primary key (CodEstudiante)
)
go

--------------------------------------------------------------------------
--- CREACION DE LA TABLA TUTOR
--------------------------------------------------------------------------
create table Tutor(
	--CodDocente varchar(6) not null,
	--CodDocente int identity(10000,1) not null,
	CodDocente  varchar(5)    not null,
    Nombres     varchar(20)  not null,
	ApellidoPaterno     varchar(25)  not null,
    ApellidoMaterno     varchar(25)  not null,
	Clase varchar(20) not null,
	Categoria varchar(20) not null,
	Regimen varchar(20) not null,
	EscuelaProfesional varchar(4) not null,
	CantidadEstudiantes int,
	PRIMARY KEY (CodDocente),
	foreign key(CodDocente)references Docente(CodDocente)
)
go

--------------------------------------------------------------------------
--- CREACION DE LA TABLA TUTORIA
--------------------------------------------------------------------------
CREATE TABLE Tutoria
(
	-- Lista de atributos
	IDTutoria int identity(1000,1) not null,
	--IDTutoria varchar(6) not null,
	-- IDTutoria int IDENTITY(1,1),  
	CodDocente varchar(5) ,
	CodEstudiante varchar(6),
	Semestre VARCHAR(10) NOT NULL,
	Fecha date,
	-- Determinar las claves 
	PRIMARY KEY (IDTutoria),
	FOREIGN KEY (CodDocente) REFERENCES Docente(CodDocente),
  FOREIGN KEY (CodEstudiante) REFERENCES Estudiante(CodEstudiante),
);
GO

--------------------------------------------------------------------------
--- CREACION DE LA TABLA USUARIO
--------------------------------------------------------------------------
create table Usuario
( --lista de atributos  
  --CodDocente   int unique not null,
  CodDocente varchar(5)  not null,
  Hash     nvarchar(40) not null,
  primary key(CodDocente)
)
go

--------------------------------------------------------------------------
--- CREACION DE LA TABLA FICHA TUTORIA
--------------------------------------------------------------------------
create table FichaTutoria(
	-- Lista de atributos
	IDTutoria int identity(1000,1) not null, 
	CodDocente varchar(5) ,
	CodEstudiante varchar(6),
	Semestre VARCHAR(10) NOT NULL,
	Fecha date,
	Descripcion nvarchar(300),
	-- Determinar las claves 
	PRIMARY KEY (IDTutoria),
	FOREIGN KEY (CodDocente) REFERENCES Docente(CodDocente),
  FOREIGN KEY (CodEstudiante) REFERENCES Estudiante(CodEstudiante),
)
go