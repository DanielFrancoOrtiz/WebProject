
create database bd_empleados_bibis;
use bd_empleados_bibis;

create table empleados(
id			int 		primary key auto_increment,
Nombre		varchar(30)	not null,
Apellidos	varchar(50) not null,
Usuario		varchar(30) not null,
Puesto		varchar(30) not null,
Email		varchar(50) null,
Telefono	varchar(16) null,
Direccion	text		not null,
Pass		varchar(50) not null
);

create view empleadosv as 
select Nombre, Apellidos, Puesto, Email, Telefono, Direccion from
empleados;

use bd_empleados_bibis;
insert into Empleados(Nombre, Apellidos, Usuario, Puesto, Email,Telefono, Direccion, Pass)
				values('Andre', 'Gonza', 'usiario1','Empleado',  'email.user1@bibid.com.mx',
                '4451211549','direccion', sha1('pass'));
select * from empleados;

delete from empleados where id = 4;




