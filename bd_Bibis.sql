
create database bd_Bibis;
use bd_Bibis;

create table empleados(
id			int 		primary key auto_increment,
nombre		varchar(30)	not null,
apellidos	varchar(50) not null,
usuario		varchar(30) not null,
puesto		varchar(30) not null,
email		varchar(50) null,
telefono	varchar(16) null,
direccion	text		not null,
pass		varchar(30) not null
);

create table clientes(
id				int 		primary key auto_increment,
nombre			varchar(30)	not null,
apellidos		varchar(50) not null,
email			varchar(50) not null,
telefono		varchar(16) not null,
direccion		text		not null,
ciudad			varchar(30) not null,
codigo_postal	char(5)		not null

);

create table catergorias(
id			int 		primary key auto_increment,
nombre		varchar(30)	not null,
descripcion	text null
);

create table proveedores(
id					int			primary key auto_increment,
nombre_proveedor  	varchar(50)	not null,
email_proveedor		varchar(50)	not null,
telefono_proveedor	varchar(16)	not null,
direccion_proveedor	text		not null,
ciudad_proveedor	varchar(30)	not null
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
constraint foreign key (id_Categoria) references catergorias(id) 
);

create table mensajeria(
id					int 			primary key auto_increment,
nombre_mensajeria	varchar(50) 	not null,
email_mensajeria	varchar(50)		not null,
telefono_mensajeria	varchar(16)		not null
);

create table ordenes (
id				int 			primary key auto_increment,
fecha_envio		date			not null,
fecha_entrega	date			not null,
ciudad			varchar(30)		not null,
direccion		text			not null,
precio_envio	decimal(10,2)	not null,
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





