create database farmacias
go

use farmacias

go

create table sucursal(idsucursal int identity primary key not null,
nombre nvarchar(30) not null,
direccion nvarchar(30)not null,
telefono nvarchar(10))

go

create table puestos(idpuesto int identity primary key not null,
nombre nvarchar(20) not null)

go

create table empleados(idempleado int identity primary key not null,
nombre nvarchar(20) not null,
apellidos nvarchar(30),
idpuesto int not null,
idsucursal int not null,
estado bit not null)

go

create table usuarios(idusuario int identity primary key not null,
usuario nvarchar(20) not null,
contraseña nvarchar(20) not null)

go

create table almacen(idalmacen int primary key not null,
idsucursal int not null)

go

create table proveedor(idproveedor int identity primary key not null,
Nombre nvarchar(30),
Responsable nvarchar(30),
Direccion nvarchar(150),
RFC nvarchar (20),
Telefono nvarchar(10),
Correo nvarchar(30))

go

create table detallefactura(idfactura int not null,
idproducto int not null,
cantidad int not null,
precio int not null)

go

create table viaAdministracion(idvia int primary key not null,
descripcion nvarchar(30))

go

create table productos(idproducto int identity primary key not null,
producto nvarchar(30) not null,
Activo nvarchar(50) not null,
idvia int not null,
reqReceta bit not null,
Precio int not null,
idproveedor int not null)

go

create table inventario(existencias int not null,
idalmacen int not null,
idproducto int not null,
fecha nvarchar(10),
comentarios nvarchar(200))

go

create table factura(idfactura int identity primary key not null,
fecha nvarchar(10) not null,
total int not null,
idempleado int not null)

go

create table receta(idreceta int identity primary key not null,
idfactura int,
nombreDoctor nvarchar(30) not null,
Cedula int not null)


alter table empleados add foreign key (idpuesto) references puestos(idpuesto)/*agrega llave foranea*/
alter table empleados add foreign key (idsucursal) references sucursal(idsucursal)/*agrega llave foranea*/
/*alter table empleados drop constraint FK__empleados__idpue__4F7CD00D; elimina llave foranea*/
alter table receta add foreign key (idfactura) references factura(idfactura)/*agrega llave foranea*/
alter table usuarios add foreign key(idusuario) references empleados(idempleado)/*relacion 1:1, agrega llave foranea*/
/*alter table usuarios drop constraint FK__usuarios__idusua__30F848ED; elimina llave foranea*/
alter table almacen add foreign key (idsucursal) references sucursal(idsucursal)/*agrega llave foranea*/
alter table detallefactura add foreign key (idfactura) references factura(idfactura)/*agrega llave foranea*/
alter table detallefactura add foreign key (idproducto) references productos(idproducto)/*agrega llave foranea*/
alter table productos add foreign key (idvia) references viaadministracion(idvia)/*agrega llave foranea*/
alter table productos add foreign key (idproveedor) references proveedor(idproveedor)/*agrega llave foranea*/
/*alter table productos drop constraint FK__productos__idrec__49C3F6B7; elimina llave foranea*/
/*truncate table productos elimina un tabla borra el identity*/
alter table inventario add foreign key (idproducto) references productos(idproducto)/*agrega llave foranea*/
alter table inventario add foreign key (idalmacen) references almacen(idalmacen)/*agrega llave foranea*/
alter table factura add foreign key (idempleado) references empleados(idempleado)/*agrega llave foranea*/

