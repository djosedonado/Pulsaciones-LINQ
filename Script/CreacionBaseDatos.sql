create database Grupo02

create table Persona(
Codigo varchar(50) unique,
Identificacion varchar(11) primary key,
Nombre varchar(50) not null,
Sexo varchar(1) not null,
Edad int not null,
pulsacion decimal(3,2)
)