﻿create Database PulsacionGrupo01
use PulsacionGrupo01
create table Persona(
Identificion varchar(11) Primary Key,
Nombre varchar(50) Not null,
Edad int not null,
Sexo varchar(1) not null,
pulsacion decimal (2,1)
)

select * from persona
insert into persona (Identificaion, Nombre, sexo, Edad, Pulsaciones) values ('1', 'Ana','F', 18,1 )

update persona set Nombre='Juan', Edad=1,Sexo='M', pulsacion=19 where Identificacion='106';