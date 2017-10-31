USE GD2C2017
GO

CREATE TABLE QEPD.Domicilio(
IdDomicilio int IDENTITY(1,1) PRIMARY KEY,
Direccion nvarchar(255)  NOT NULL,
Cod_Postal nvarchar(255) NOT NULL
);

CREATE TABLE QEPD.Cliente(
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Dni_Cliente numeric NOT NULL,
Nombre_Cliente nvarchar(255) NOT NULL,
Apellido_Cliente nvarchar(255)  NOT NULL,
Email_Cliente nvarchar(255) NOT NULL,
Fecha_Nac_Cliente datetime NOT NULL,
Telefono_Cliente numeric(18,0) NOT NULL,
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
Estado_Cliente BIT DEFAULT 1
);

create table qepd.Rubro(
IdRubro numeric IDENTITY(1,1) PRIMARY KEY,
Descripcion_Rubro nvarchar(50) NOT NULL
)

create table qepd.Empresa(
IdEmpresa int IDENTITY(1,1) PRIMARY KEY,
Nombre_Empresa nvarchar(255) NOT NULL,
Cuit nvarchar(50) NOT NULL,
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
IdRubro numeric FOREIGN KEY REFERENCES QEPD.Rubro(IdRubro),
Estado_Empresa BIT DEFAULT 1
)

create table qepd.Sucursal(
CP_Sucursal numeric(18,0) PRIMARY KEY,
Nombre_Sucursal nvarchar(50) NOT NULL,
Direccion_Sucursal nvarchar(50) NOT NULL,
Estado_Sucursal BIT default 1	
)

create table qepd.Forma_Pago(
IdForma_Pago int IDENTITY(1,1) PRIMARY KEY,
Descripcion_Pago nvarchar(255) NOT NULL,
)

create table qepd.Pago(
Nro_Pago numeric PRIMARY KEY,
Fecha_Cobro_Pago datetime NOT NULL,
IdSucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
Total_Pago numeric(18,0) NOT NULL,  /* Lo que paga el cliente, no calculado como la suma de las facturas que contiene*/
Tipo_pago int FOREIGN KEY REFERENCES QEPD.Forma_Pago(IdForma_Pago),
Estado_Pago BIT DEFAULT 0 /* Indica si el pago fue rendido o no */
)

create table qepd.Devolucion(
IdDevolucion int IDENTITY(1,1) PRIMARY KEY,
Motivo_Devolucion nvarchar(255) NOT NULL,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago)
)



create table qepd.Factura(
Nro_Factura numeric(18,0) PRIMARY KEY,
FechaAlta_Factura datetime NOT NULL,
Fecha_Venc_Factura datetime NOT NULL,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
IdCliente int FOREIGN KEY REFERENCES QEPD.Cliente(IdCliente),
Total_Factura numeric(18,0) NOT NULL,

)

create table qepd.Renglon_Pago(
IdRenglon_Pago int IDENTITY(1,1) PRIMARY KEY,
Nro_Factura numeric FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura),
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa)
)


create table qepd.Renglon_Factura(
IdRenglon_Factura int PRIMARY KEY,
Item_Monto_Factura numeric(18,0) NOT NULL,
Item_Cant_Factura numeric(18,0) NOT NULL,
Nro_Factura numeric(18,0) FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura)
)


create table qepd.Rendicion(
IdRendicion numeric(18,0) PRIMARY KEY,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
Cantidad_Facturas numeric(18,0) NULL, /*caculable*/
Fecha_Rendicion datetime NOT NULL,
porcentaje_comision numeric(18,0) NOT NULL,
importe_comision numeric(18,0) NULL, /* calcuable a partir de partir del total de facturas y porcentaje*/
Total_Rendicion numeric(18,0) NULL /*caculable*/
)

create table qepd.Renglon_Rendicion(
IdRenglon_Rendicion int IDENTITY(1,1) PRIMARY KEY,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
Monto_Pago numeric(18,0) NOT NULL,
IdRendicion numeric FOREIGN KEY REFERENCES QEPD.Rendicion(IdRendicion)
)



create table qepd.Funcionalidad(
IdFuncionalidad int IDENTITY(1,1) PRIMARY KEY,
Nombre_Funcionalidad nvarchar(255) NOT NULL
)

create table qepd.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre_Rol nvarchar(255) NOT NULL,
Estado_Rol BIT DEFAULT 1
)

create table qepd.RolPorFuncionalidad(
IdRol int FOREIGN KEY REFERENCES QEPD.Rol(IdRol),
IdFuncionalidad int FOREIGN KEY REFERENCES QEPD.Funcionalidad(IdFuncionalidad),
CONSTRAINT IdRolPorFuncionalidad PRIMARY KEY(IdFuncionalidad,IdRol)
)

create table qepd.Usuario(
IdUsuario int IDENTITY(1,1) PRIMARY KEY,
Nombre_Usuario nvarchar(255) NOT NULL,
Pass_Usuario nvarchar(255) NOT NULL,
Logs_Fallidos int DEFAULT 0,
Estado_Usuario BIT DEFAULT 1
)

create table qepd.UsuarioPorSucursal(
IdUsuario int FOREIGN KEY REFERENCES QEPD.Usuario(IdUsuario),
CP_Sucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
CONSTRAINT IdUsuarioPorSucursal PRIMARY KEY(IdUsuario,CP_Sucursal)
)

create table qepd.RolPorUsuario(
IdRol int FOREIGN KEY REFERENCES QEPD.Rol(IdRol),
IdUsuario int FOREIGN KEY REFERENCES QEPD.Usuario(IdUsuario),
CONSTRAINT IdRolPorUsuario PRIMARY KEY(idUsuario,IdRol)
)



/* GO

Vi un par de cosas y todavia no me quedo claro si en los precedure ya les pegamos a las tablas para ir cargandolas o no, porque supuestamente el momento de la carga es la migracion.

CREATE PROCEDURE QEPD.sp_Crear_Sucursal

    @sucursal_nombre nvarchar(50),
	@sucursal_descripcion nvarchar(50),
	@sucursal_CP NUMERIC(18,0)

AS

BEGIN

INSERT INTO QEPD.Sucursal(CP_Sucursal,Nombre_Sucursal,Direccion_Sucursal)
	VALUES (@sucursal_CP,@sucursal_nombre,@sucursal_descripcion)




END

*/
