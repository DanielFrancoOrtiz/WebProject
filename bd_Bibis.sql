

create database bd_Bibis;
use bd_Bibis;

create table empleados(
id			int 		primary key auto_increment,
Nombre		varchar(30)	not null,
Apellidos	varchar(50) not null,
Usuario		varchar(30) not null,
Puesto		varchar(30) not null,
Email		varchar(50) null,
Telefono	varchar(16) null,
Direccion	text		not null,
Pass		varchar(30) not null
);

create table clientes(
id				int 		primary key auto_increment,
Nombre			varchar(30)	not null,
Apellidos		varchar(50) not null,
Email			varchar(50) not null,
Telefono		varchar(16) not null,
Direccion		text		not null,
Ciudad			varchar(30) not null,
Codigo_postal	char(5)		not null

);

create table categorias(
id			int 		primary key auto_increment,
Nombre		varchar(30)	not null,
Descripcion	text null
);

create table proveedores(
id					int			primary key auto_increment,
Nombre 			 	varchar(50)	not null,
Email				varchar(50)	not null,
Telefono			varchar(16)	not null,
Direccion			text		not null,
Ciudad				varchar(30)	not null
);


create table productos(
id				int 			primary key auto_increment,
nombre			varchar(30) 	not null,
modelo      	varchar(30) 	not null,
cantidad		int not null,
precio_compra	decimal(10,2) 	not null,
precio_venta	decimal(10,2) 	not null,
foto			text			not null,
id_Proveedor	int 			null,
id_Categoria	int				not null,
constraint foreign key (id_Proveedor) references proveedores(id),
constraint foreign key (id_Categoria) references categorias(id) 
);

create table mensajeria(
id					int 			primary key auto_increment,
Nombre				varchar(50) 	not null,
Email				varchar(50)		not null,
Telefono			varchar(16)		not null
);

create table ordenes (
id				int 			primary key auto_increment,
Fecha_envio		date			not null,
Fecha_entrega	date			not null,
Ciudad			varchar(30)		not null,
Direccion		text			not null,
Precio_envio	decimal(10,2)	not null,
id_Cliente		int 			not null,
id_Mensajeria	int				not null,	
constraint foreign key(id_Cliente) references clientes(id),
constraint foreign key(id_Mensajeria) references mensajeria(id)
);

create table detalles_ordenes(
id				int				primary key auto_increment,
precio			decimal(10,2)	not null,
cantidad		smallint(5)		not null,
id_orden		int				not null,
constraint	foreign key(id_orden)references	ordenes(id)
);

select * from proveedores;
insert into proveedores values(null,'proveedor1','pro1@email.com','4434534352','pro1direccion','pro1city');




