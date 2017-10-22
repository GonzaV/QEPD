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

create table qepd.Pago(
Nro_Pago numeric PRIMARY KEY,
Fecha_Cobro_Pago datetime,
IdSucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
Total_Pago numeric
)

create table qepd.Rendicion(
IdRendicion numeric PRIMARY KEY,
Fecha_Rendicion datetime,
)

create table qepd.Renglon_Rendicion(
IdRenglon_Rendicion int IDENTITY(1,1) PRIMARY KEY,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
Monto_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
IdRendicion numeric FOREIGN KEY REFERENCES QEPD.Rendicion(IdRendicion)
)

create table qepd.Forma_Pago(
IdForma_Pago int IDENTITY(1,1) PRIMARY KEY,
Descripcion_Pago nvarchar(255),
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago)
)

create table qepd.Factura(
Nro_Factura numeric PRIMARY KEY,
FechaAlta_Factura datetime,
Fecha_Venc_Factura datetime,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
IdCliente int FOREIGN KEY REFERENCES QEPD.Cliente(IdCliente),
Total_Factura numeric,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago)
)

create table qepd.Renglon_Factura(
IdRenglon_Factura int PRIMARY KEY,
Item_Monto_Factura numeric,
Item_Cant_Factura numeric,
Nro_Factura numeric FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura)
)

create table qepd.Funcionalidad(
IdFuncinalidad int IDENTITY(1,1) PRIMARY KEY,
Nombre_Funcionalidad nvarchar(255)
)

create table qepd.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre_Rol nvarchar(255),
Estado_Rol int
)

create table qepd.FuncionalidadPorRol(
IdRol int FOREIGN KEY REFERENCES QEPD.Rol(IdRol),
IdFuncinalidad int FOREIGN KEY REFERENCES QEPD.Funcionalidad(IdFuncinalidad),
CONSTRAINT IdFuncionalidadPorRol PRIMARY KEY(IdFuncinalidad,IdRol)
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
CONSTRAINT IdFuncionalidadPorRol PRIMARY KEY(IdUsuario,CP_Sucursal)
)