

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

create view empleadosv as 
select Nombre, Apellidos, Puesto, Email, Telefono, Direccion from
empleados;


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
Foto			text			not null,
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


insert into Empleados(Nombre, Apellidos, Usuario, Puesto, Email,Telefono, Direccion, Pass)
				values('Empleado1', 'Apellidos 1', 'user1','Puesto',  'email.user1@bibid.com.mx',
                '4451211549','direccion', 'pass');

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


