USE GD2C2017
GO

CREATE TABLE QEPD.Domicilio(
IdDomicilio int IDENTITY(1,1) PRIMARY KEY,
Direccion nvarchar(255),
Cod_Postal nvarchar(255)
);

CREATE TABLE QEPD.Cliente(
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Dni_Cliente numeric,
Nombre_Cliente nvarchar(255),
Apellido_Cliente nvarchar(255),
Email_Cliente nvarchar(255),
Fecha_Nac_Cliente datetime,
Telefono_Cliente int,
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
Estado_Cliente int
);

create table qepd.Rubro(
IdRubro numeric IDENTITY(1,1) PRIMARY KEY,
Descripcion_Rubro nvarchar(50)
)

create table qepd.Empresa(
IdEmpresa int IDENTITY(1,1) PRIMARY KEY,
Nombre_Empresa nvarchar(255),
Cuit nvarchar(50),
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
IdRubro numeric FOREIGN KEY REFERENCES QEPD.Rubro(IdRubro),
Estado_Empresa int
)

create table qepd.Sucursal(
CP_Sucursal numeric PRIMARY KEY,
Nombre_Sucursal nvarchar(50),
Direccion_Sucursal nvarchar(50),
Estado_Sucursal int
)

create table qepd.Forma_Pago(
IdForma_Pago int IDENTITY(1,1) PRIMARY KEY,
Descripcion_Pago nvarchar(255),
)

create table qepd.Pago(
Nro_Pago numeric PRIMARY KEY,
Fecha_Cobro_Pago datetime,
IdSucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
Total_Pago numeric,  /* Lo que paga el cliente, no calculado como la suma de las facturas que contiene*/
Tipo_pago int FOREIGN KEY REFERENCES QEPD.Forma_Pago(IdForma_Pago),
Estado_Pago int /* Indica si el pago fue rendido o no */
)

create table qepd.Devolucion(
IdDevolucion int IDENTITY(1,1) PRIMARY KEY,
Motivo_Devolucion nvarchar(255),
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago)
)



create table qepd.Factura(
Nro_Factura numeric PRIMARY KEY,
FechaAlta_Factura datetime,
Fecha_Venc_Factura datetime,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
IdCliente int FOREIGN KEY REFERENCES QEPD.Cliente(IdCliente),
Total_Factura numeric,

)

create table qepd.Renglon_Pago(
IdRenglon_Pago int IDENTITY(1,1) PRIMARY KEY,
Nro_Factura numeric FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura),
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa)
)


create table qepd.Renglon_Factura(
IdRenglon_Factura int PRIMARY KEY,
Item_Monto_Factura numeric,
Item_Cant_Factura numeric,
Nro_Factura numeric FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura)
)


create table qepd.Rendicion(
IdRendicion numeric PRIMARY KEY,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
Cantidad_Facturas int, /*caculable*/
Fecha_Rendicion datetime,
porcentaje_comision numeric,
importe_comision numeric, /* calcuable a partir de partir del total de facturas y porcentaje*/
Total_Rendicion numeric /*caculable*/
)

create table qepd.Renglon_Rendicion(
IdRenglon_Rendicion int IDENTITY(1,1) PRIMARY KEY,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
Monto_Pago numeric,
IdRendicion numeric FOREIGN KEY REFERENCES QEPD.Rendicion(IdRendicion)
)



create table qepd.Funcionalidad(
IdFuncionalidad int IDENTITY(1,1) PRIMARY KEY,
Nombre_Funcionalidad nvarchar(255)
)

create table qepd.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre_Rol nvarchar(255),
Estado_Rol int
)

create table qepd.RolPorFuncionalidad(
IdRol int FOREIGN KEY REFERENCES QEPD.Rol(IdRol),
IdFuncionalidad int FOREIGN KEY REFERENCES QEPD.Funcionalidad(IdFuncionalidad),
CONSTRAINT IdRolPorFuncionalidad PRIMARY KEY(IdFuncionalidad,IdRol)
)

create table qepd.Usuario(
IdUsuario int IDENTITY(1,1) PRIMARY KEY,
Nombre_Usuario nvarchar(255),
Pass_Usuario nvarchar(255),
Logs_Fallidos int,
Estado_Usuario int
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