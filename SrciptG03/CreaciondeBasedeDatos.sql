create database PulsacionG01
use PulsacionG01
Create table Persona(
identificacion varchar(11) PRIMARY KEY,
Nombre Varchar(50) not null,
Sexo Varchar(1) not null,
Edad int not null,
Pulsacion decimal not null,
Estado varchar(2) default 'AC'
)

--Select identificacion, nombre, Sexo,Edad,Pulsacion From Persona
--Insert into Persona (identificacion, nombre, Sexo,Edad,Pulsacion) values ('4','Juan','M',18,19)
--update Persona set sexo ='M', Edad=18  where identificacion=1
--Drop table Persona
--Delete from Persona Where identificacion=1