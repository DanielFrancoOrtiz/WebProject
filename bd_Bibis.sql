create database bd_Bibis;
use bd_Bibis;


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
Nombre			varchar(30) 	not null,
Modelo      	varchar(30) 	not null,
Cantidad		int not null,
Precio_compra	decimal(10,2) 	not null,
Precio_venta	decimal(10,2) 	not null,
Foto			text			null,
id_Proveedor	int 			null,
id_Categoria	int				not null,
descripcion		text			null,
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



insert into categorias (nombre, descripcion) values('Categoria1','descripcion categoria 1');
insert into categorias (nombre, descripcion) values('Categoria2','descripcion categoria 2');
insert into categorias (nombre, descripcion) values('Categoria3','descripcion categoria 3');
insert into categorias (nombre, descripcion) values('Categoria4','descripcion categoria 4');



insert into clientes(Nombre, Apellidos, Email, Telefono, Direccion, Ciudad, Codigo_Postal)
				values('Cliente 1','Apellidos', 'email.cliente@email.com',
                '4451159243','direccion cliente', 'ciudad','23901');
                
insert into Proveedores(Nombre, Email, Telefono, Direccion, Ciudad)
				values('Proveedor1','proveedor.email@email.com','4451868321',
                'direccion proveedor','ciudad proveedor');


insert into Productos(Nombre, Modelo,Cantidad,Precio_Compra, 
						Precio_Venta, Foto, id_Proveedor, id_Categoria, descripcion)
				values('Producto1','Modelo1',15,129,150,'',1,1,'descripcion producto 1');
                
insert into Mensajeria(Nombre,Email,Telefono)
			values('Mensjeria 1','mensajeria.email@email.com','44524524525');
            
-- insert into detaller_ordenes (precio, cantidad, id_orden)values();

use bd_bibis;

-- ---------------------------------------- CARRITO DE VENTA
create table pre_venta
(
id_Pventa	int primary key auto_increment,
nombreP		varchar(60) not null,
precioV		double not null
);

create table detalles_venta
(
id_Dventa int primary key auto_increment,
cantidadP	int not null,
precioT		double not null,
id_Pventa	int,
constraint foreign key (id_Pventa) references pre_venta(id_Pventa)
);

select * from productos;

-- Agregar al carrito
insert into pre_venta values (null, (select nombre from productos where nombre='Perjum'), (select Precio_venta from productos where nombre='Perjum'));


select * from pre_venta;
-- Total de productos y total de precio
insert into detalles_venta values (null, (select count(*) from pre_venta), (select sum(precioV) from pre_venta), null);


select * from detalles_venta;
show databases;
