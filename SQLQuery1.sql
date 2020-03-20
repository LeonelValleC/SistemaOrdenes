
select * from ConReporteTabla
select * from [Errores de pegado]
select * from Usuarios
select * from Departamentos
select * from Detalles_Orden
select * from Ordenes


select * from tb_Nivel
Select * from tb_Usuarios
select * from tb_Proveedores
select * from tb_Vehiculos
select * from tb_Departamentos


select id_proveedor, nombre, direccion, rfc, telefono, contacto, correo, extension from tb_Proveedores

select id_depto, nombre, encargado from tb_Departamentos
select id_proveedor, nombre, direccion, rfc, telefono, contacto, correo, extension from tb_Proveedores
select id_vehiculo, noecon, marca, modelo, departamento, linea, color, numserie, bajafecha from tb_Vehiculos
select id_maquina, noecon, marca, modelo, departamento, linea, color, numserie, bajafecha from tb_Maquinas

select id_usuario from tb_Usuarios where usuario='leonel' and password='123'

select n.nivel from tb_Usuarios u join tb_Nivel n on n.id_nivel = u.id_nivel where u.id_usuario = 1

select n.nivel from tb_Usuarios u, tb_Nivel n where n.id_nivel = u.id_nivel and u.id_usuario = 1

create database dbsistema

create table tb_Vehiculos([id_vehiculo] int primary key identity(1,1),[noecon] varchar(255) NULL,[marca] varchar(255) NULL,[linea] varchar(255) NULL,[tipo] varchar(255) NULL,[modelo] float NULL,	
[clase] varchar(255) NULL,[usuario] varchar(255) NULL,[placas] varchar(255) NULL,[numserie] varchar(255) NULL,[motor] varchar(255) NULL,[llantas] varchar(255) NULL,[bajafecha] varchar(255) NULL,[color] varchar(255) NULL,
[departamento] varchar(255) NULL) 

create table tb_Maquinas([id_maquina] int primary key identity(1,1),[noecon] varchar(255) NULL,[marca] varchar(255) NULL,[linea] varchar(255) NULL,[tipo] varchar(255) NULL,[modelo] float NULL,	
[clase] varchar(255) NULL,[usuario] varchar(255) NULL,[placas] varchar(255) NULL,[numserie] varchar(255) NULL,[motor] varchar(255) NULL,[llantas] varchar(255) NULL,[bajafecha] varchar(255) NULL,[color] varchar(255) NULL,
[departamento] varchar(255) NULL) 


create table tb_Nivel(id_nivel int primary key identity(1,1), nivel varchar(100))


create table tb_Proveedores(id_proveedor int primary key identity(1,1), nombre varchar(255), direccion varchar(255), rfc varchar(255), telefono varchar(80), contacto varchar(255), correo varchar(255), extension varchar(255))

create table tb_Moneda(id_moneda int primary key identity(1,1), monedas varchar(100))

create table tb_IVA(id_iva int primary key identity(1,1), iva int)

create table tb_Departamentos(id_depto int primary key identity(1,1), nombre varchar(255), encargado varchar(255))

create table tb_Usuarios(id_usuario int primary key identity(1,1), usuario varchar(255), password varchar(100),  activo bit, nombre varchar(255), apellido varchar(255), 
correo varchar(255), id_nivel int, id_depto int,
foreign key(id_nivel) references tb_Nivel(id_nivel),
foreign key(id_depto) references tb_Departamentos(id_depto))

create table tb_Ordenes(id_orden int primary key identity(1,1), orden int, fecha datetime, id_proveedor int, id_depto int, id_vehiculo int, almacen varchar(255), solicito varchar(255), reviso varchar(255),
autorizo varchar(255), parauso varchar(255), maquina varchar(255), obra varchar(255), unidad int, id_usuario int, id_maquina int,
foreign key(id_usuario) references tb_Usuarios(id_usuario),
foreign key(id_proveedor) references tb_Proveedores(id_proveedor),
foreign key(id_depto) references tb_Departamentos(id_depto),
foreign key(id_vehiculo) references tb_Vehiculos(id_vehiculo),
foreign key(id_maquina) references tb_Maquinas(id_maquina))

create table tb_DetalleOrdenes(id_dordenes int primary key identity(1,1), cantidad int, descripcion varchar(255), punitario float, id_moneda int, id_iva int, id_orden int,
foreign key(id_orden) references tb_Ordenes(id_orden),
foreign key(id_moneda) references tb_Moneda(id_moneda),
foreign key(id_iva) references tb_IVA(id_iva))

create table tbUnion_OrdenUsuario(id_unionOU int primary key identity(1,1), id_usuario int, id_orden int,
foreign key(id_usuario) references tb_Usuarios(id_usuario),
foreign key(id_orden) references tb_Ordenes(id_orden))


ALTER AUTHORIZATION ON DATABASE::dbsistema TO sa;
GO