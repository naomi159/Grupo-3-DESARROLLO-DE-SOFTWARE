/* 
** CREABASE.SQL
**
*/
/* ********************************************************************
      CREACION DE LA BASE DE DATOS
 ******************************************************************** */
USE MASTER
GO
IF EXISTS (SELECT * FROM SYSDATABASES WHERE NAME = 'TutoriaDB')
BEGIN
	DROP DATABASE TutoriaDB
END
GO
CREATE DATABASE TutoriaDB 
GO
/* ********************************************************************
      CREACION DE TIPOS
 ******************************************************************** */
USE TutoriaDB 
-- EXEC sp_addtype TCod_CP,   'varchar(2)', 'not null'
EXEC sp_addtype TCod_Alumno,  'varchar(6)', 'not null'
EXEC sp_addtype TCod_Matricula, 'varchar(5)', 'not null'
EXEC sp_addtype TCod_Tutor, 'varchar(3)', 'not null'
EXEC sp_addtype TCod_Ayudante, 'varchar(3)', 'not null'
EXEC sp_addtype TCod_Docente, 'varchar(3)', 'not null'
EXEC sp_addtype TCod_Tutoria,  'varchar(7)', 'not null'
EXEC sp_addtype TSemestre,  'varchar(7)', 'not null'
GO
/* ********************************************************************
      CREACION DE TABLAS
 ******************************************************************** */
-----------------------------------------------------------------------
create table Alumno
(	-- lista de atributos
	Cod_Alumno   TCod_Alumno,
	-- definición de claves
	primary key (Cod_Alumno)
)
go
-----------------------------------------------------------------------
create table Tutor
(	-- lista de atributos
	Cod_Tutor   TCod_Tutor,
	-- definición de claves
	primary key (Cod_Tutor)
)
go
-----------------------------------------------------------------------
create table Ayudante
(	-- lista de atributos
	Cod_Ayudante   TCod_Ayudante,
	-- definición de claves
	primary key (Cod_Ayudante)
)
go
-----------------------------------------------------------------------
create table Docente
(	-- lista de atributos
	Cod_Docente   TCod_Docente,
	-- definición de claves
	primary key (Cod_Docente)
)
go
-----------------------------------------------------------------------
create table Matricula
(	-- lista de atributos
	Cod_Matricula		TCod_Matricula,
	Cod_Alumno   		TCod_Alumno,
	Cod_Docente   		TCod_Docente,
	Cod_Curso			varchar(8)  not null,
	Semestre			TSemestre,
	-- definición de claves
	primary key (Cod_Matricula),
	foreign key (Cod_Alumno) references Alumno(Cod_Alumno),
	foreign key (Cod_Docente) references Docente(Cod_Docente)
)
go
-----------------------------------------------------------------------
create table Tutoria
(	-- lista de atributos
	Cod_Tutoria			TCod_Tutoria,
	Cod_Tutor			TCod_Tutor,
	Cod_Ayudante		TCod_Ayudante,
	Horario				varchar(80)  not null,
	Salon				varchar(5)   not null,
	Semestre			TSemestre,
	 -- definición de claves
	primary key (Cod_Tutoria),
	foreign key (Cod_Tutor) references Tutor(Cod_Tutor),
	foreign key (Cod_Ayudante) references Ayudante(Cod_Ayudante)
)
go
-----------------------------------------------------------------------
create table RegistroTutoria
(	-- lista de atributos
	Cod_Tutoria			TCod_Tutoria,
	Cod_Alumno			TCod_Alumno,
	Fecha				date  not null,
	 -- definición de claves
	primary key (Cod_Tutoria, Cod_Alumno, Fecha),
	foreign key (Cod_Tutoria) references Tutoria(Cod_Tutoria),
	foreign key (Cod_Alumno) references Alumno(Cod_Alumno)
)
go
-----------------------------------------------------------------------

/* ******************************************************************** */
/*        INSERTAR DATOS       */
/* ******************************************************************** */
USE TutoriaDB 
go
/* ***************** ALUMNOS ************************** */
insert into Alumno values('130322')
insert into Alumno values('150559')
insert into Alumno values('181526')
insert into Alumno values('120356')
insert into Alumno values('132656')
go
/* ***************** TUTOR ************************** */
insert into Tutor values('T01')
insert into Tutor values('T02')
insert into Tutor values('T03')
insert into Tutor values('T04')
go
/* ***************** AYUDANTE ************************** */
insert into Ayudante values('A01')
insert into Ayudante values('A02')
insert into Ayudante values('A03')
go
/* ***************** DOCENTE ************************** */
insert into Docente values('D01')
insert into Docente values('D02')
insert into Docente values('D03')
insert into Docente values('D04')
go
/* ***************** MATRICULA ************************** */
insert into Matricula values('Mat01','130322','D01','ME305IN','2013-II')
insert into Matricula values('Mat02','150559','D02','IF101IN','2015-I')
insert into Matricula values('Mat03','181526','D03','FI401IN','2016-II')
insert into Matricula values('Mat04','120356','D01','ME306IN','2013-I')
insert into Matricula values('Mat05','132656','D04','DE901IN','2015-II')
go
/* ***************** TUTORIA ************************** */
insert into Tutoria values('TUTO001','T01','A01','19:00-21:00','IF101','2021-I')
insert into Tutoria values('TUTO002','T02','A01','17:00-19:00','IF102','2020-II')
insert into Tutoria values('TUTO003','T01','A02','13:00-15:00','IF101','2021-II')
insert into Tutoria values('TUTO004','T03','A03','7:00-9:00','IF102','2020-I')
go
/* ***************** REGISTRO TUTORIA ************************** */
--insert into RegistroTutoria values('TUTO001','130322','11-03-2021')
--insert into RegistroTutoria values('TUTO001','181526','11-02-2021')
--insert into RegistroTutoria values('TUTO001','120356','19-02-2021')
--insert into RegistroTutoria values('TUTO002','150559','13-10-2020')
--insert into RegistroTutoria values('TUTO002','130322','21-08-2020')
--insert into RegistroTutoria values('TUTO002','120356','30-09-2020')
--insert into RegistroTutoria values('TUTO003','181526','17-08-2021')
--insert into RegistroTutoria values('TUTO003','120356','14-07-2021')
--insert into RegistroTutoria values('TUTO004','132656','21-03-2020')
--go