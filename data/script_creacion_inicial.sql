USE GD2C2017
GO


/*  Se eliminan objetos preexistentes*/


/* Se eliminan tablas preexistentes */

IF OBJECT_ID('QEPD.RolPorUsuario','U') IS NOT NULL    
	DROP TABLE QEPD.RolPorUsuario;

IF OBJECT_ID('QEPD.UsuarioPorSucursal','U') IS NOT NULL     
	DROP TABLE QEPD.UsuarioPorSucursal;

IF OBJECT_ID('QEPD.Usuario','U') IS NOT NULL   
	DROP TABLE QEPD.Usuario;

IF OBJECT_ID('QEPD.RolPorFuncionalidad','U') IS NOT NULL   
	DROP TABLE QEPD.RolPorFuncionalidad;

IF OBJECT_ID('QEPD.Rol','U') IS NOT NULL   
	DROP TABLE QEPD.Rol;

IF OBJECT_ID('QEPD.Funcionalidad','U') IS NOT NULL    
	DROP TABLE QEPD.Funcionalidad;

IF OBJECT_ID('QEPD.Renglon_Rendicion','U') IS NOT NULL   
	DROP TABLE QEPD.Renglon_Rendicion;

IF OBJECT_ID('QEPD.Rendicion','U') IS NOT NULL  
	DROP TABLE QEPD.Rendicion;

IF OBJECT_ID('QEPD.Renglon_Factura','U') IS NOT NULL   
	DROP TABLE QEPD.Renglon_Factura;

IF OBJECT_ID('QEPD.Renglon_Pago','U') IS NOT NULL   
	DROP TABLE QEPD.Renglon_Pago;

IF OBJECT_ID('QEPD.Factura','U') IS NOT NULL    
	DROP TABLE QEPD.Factura;

IF OBJECT_ID('QEPD.Devolucion','U') IS NOT NULL    
	DROP TABLE QEPD.Devolucion;

IF OBJECT_ID('QEPD.Pago','U') IS NOT NULL    
	DROP TABLE QEPD.Pago;

IF OBJECT_ID('QEPD.Forma_Pago','U') IS NOT NULL    
	DROP TABLE QEPD.Forma_Pago;

IF OBJECT_ID('QEPD.Sucursal','U') IS NOT NULL   
	DROP TABLE QEPD.Sucursal;

IF OBJECT_ID('QEPD.Empresa','U') IS NOT NULL   
	DROP TABLE QEPD.Empresa;

IF OBJECT_ID('QEPD.Rubro','U') IS NOT NULL  
	DROP TABLE QEPD.Rubro;

IF OBJECT_ID('QEPD.Cliente','U') IS NOT NULL   
	DROP TABLE QEPD.Cliente;

IF OBJECT_ID('QEPD.Domicilio','U') IS NOT NULL  
	DROP TABLE QEPD.Domicilio;

IF OBJECT_ID('QEPD.RolPorUsuario','U') IS NOT NULL  
	DROP TABLE QEPD.RolPorUsuario;

IF OBJECT_ID('QEPD.UsuarioPorSucursal','U') IS NOT NULL  
	DROP TABLE QEPD.UsuarioPorSucursal;

IF OBJECT_ID('QEPD.RolPorFuncionalidad','U') IS NOT NULL  
	DROP TABLE QEPD.RolPorFuncionalidad;

IF OBJECT_ID('QEPD.Usuario','U') IS NOT NULL  
	DROP TABLE QEPD..Usuario;

IF OBJECT_ID('QEPD.Rol','U') IS NOT NULL  
	DROP TABLE QEPD.UsuarioPorSucursal;

IF OBJECT_ID('QEPD.Funcionalidad','U') IS NOT NULL  
	DROP TABLE QEPD.RolPorFuncionalidad;



/* SE DROPEAN PROCEDURES Y FUNCIONES */ 

IF OBJECT_ID('QEPD.validarUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.validarUsuario;

IF OBJECT_ID('QEPD.rehabilitarUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.rehabilitarUsuario;

IF OBJECT_ID('QEPD.bloquearUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.bloquearUsuario;

IF OBJECT_ID('QEPD.getUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getUsuario;

IF OBJECT_ID('QEPD.getRoles','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRoles;

IF OBJECT_ID('QEPD.getFuncionalidades','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFuncionalidades;

IF OBJECT_ID('QEPD.getRol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRol;

IF OBJECT_ID('QEPD.getFuncionalidad','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFuncionalidad;

IF OBJECT_ID('QEPD.modificarRol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.modificarRol;

IF OBJECT_ID('QEPD.eliminarRol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.eliminarRol;

IF OBJECT_ID('QEPD.agregarFuncionalidadARol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.agregarFuncionalidadARol;

IF OBJECT_ID('QEPD.eliminarFuncionalidadARol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.eliminarFuncionalidadARol;

IF OBJECT_ID('QEPD.getCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getCliente;

IF OBJECT_ID('QEPD.getClientes','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getClientes;

IF OBJECT_ID('QEPD.getClientesActivos','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getClientesActivos;

IF OBJECT_ID('QEPD.newCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newCliente;

IF OBJECT_ID('QEPD.modificarCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.modificarCliente;

IF OBJECT_ID('QEPD.eliminarCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.eliminarCliente;

IF OBJECT_ID('QEPD.habilitarCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.habilitarCliente;

IF OBJECT_ID('QEPD.validarCliente','P') IS NOT NULL  
	DROP PROCEDURE QEPD.validarCliente;

IF OBJECT_ID('QEPD.getRolesUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRolesUsuario;

IF OBJECT_ID('QEPD.getEmpresas','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresas;
	
IF OBJECT_ID('QEPD.getEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresa;

IF OBJECT_ID('QEPD.getEmpresasActivas','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresasActivas;

IF OBJECT_ID('QEPD.getEmpresaCuit','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresaCuit;

IF OBJECT_ID('QEPD.getEmpresaNombre','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresaNombre;

IF OBJECT_ID('QEPD.newEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newEmpresa;

IF OBJECT_ID('QEPD.modificarEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.modificarEmpresa;

IF OBJECT_ID('QEPD.eliminarEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.eliminarEmpresa;

IF OBJECT_ID('QEPD.habilitarEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.habilitarEmpresa;

IF OBJECT_ID('QEPD.validarEmpresa','P') IS NOT NULL  
	DROP PROCEDURE QEPD.validarEmpresa;

IF OBJECT_ID('QEPD.CrearRol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.CrearRol;
	
IF OBJECT_ID('QEPD.getSucursales','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getSucursales;

IF OBJECT_ID('QEPD.getUsuarioSucursales','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getUsuarioSucursales;

IF OBJECT_ID('QEPD.modificarSucursal','P') IS NOT NULL  
	DROP PROCEDURE QEPD.modificarSucursal;

IF OBJECT_ID('QEPD.newSucursal','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newSucursal;

IF OBJECT_ID('QEPD.getSucursalNombre','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getSucursalNombre;

IF OBJECT_ID('qepd.asignarRolUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.asignarRolUsuario;

IF OBJECT_ID('QEPD.getFuncionalidadesDeUnRolDeUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFuncionalidadesDeUnRolDeUsuario;

IF OBJECT_ID('QEPD.getFuncionalidadesDeTodosLosRolesDeUsuario','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFuncionalidadesDeTodosLosRolesDeUsuario;

IF OBJECT_ID('QEPD.getFuncionalidadesDeUnRol','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFuncionalidadesDeUnRol;

IF OBJECT_ID('QEPD.getSucursalNombre','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getSucursalNombre;

IF OBJECT_ID('QEPD.EliminarSucursal','P') IS NOT NULL  
	DROP PROCEDURE QEPD.EliminarSucursal;

IF OBJECT_ID('qepd.getFactura','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFacturas;

IF OBJECT_ID('QEPD.newSucursal ','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newSucursal;

IF OBJECT_ID('qepd.getFacturas','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getFacturas;

IF OBJECT_ID('qepd.newSucursal','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newSucursal;

IF OBJECT_ID('qepd.getTotaldeFactura','P') IS NOT NULL  
	DROP PROCEDURE qepd.getTotaldeFactura;

IF OBJECT_ID('qepd.getFactura','P') IS NOT NULL  
	DROP PROCEDURE qepd.getFactura;

IF OBJECT_ID('qepd.getRenglonesFactura','P') IS NOT NULL  
	DROP PROCEDURE qepd.getRenglonesFactura;

IF OBJECT_ID('qepd.newRenglonFactura','P') IS NOT NULL  
	DROP PROCEDURE qepd.newRenglonFactura;

IF OBJECT_ID('qepd.getTotaldeFactura','P') IS NOT NULL  
	DROP PROCEDURE qepd.getTotaldeFactura

IF OBJECT_ID('qepd.newFactura','P') IS NOT NULL 
	DROP PROCEDURE qepd.newFactura

IF OBJECT_ID('QEPD.getRendiciones','P') IS NOT NULL   
	DROP PROCEDURE QEPD.getRendiciones
	
IF OBJECT_ID('qepd.getRendicionesHistoricasxEmpresa','P') IS NOT NULL  
	DROP PROCEDURE qepd.getRendicionesHistoricasxEmpresa

IF OBJECT_ID('QEPD.getEmpresasARendirHoy','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getEmpresasARendirHoy

IF OBJECT_ID('QEPD.getRenglonesRendicion','P') IS NOT NULL 
	DROP PROCEDURE QEPD.getRenglonesRendicion

IF OBJECT_ID('QEPD.getRenglonRendicion','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRenglonRendicion

IF OBJECT_ID('QEPD.getCantidadFacturasRendicion ','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getCantidadFacturasRendicion 

IF OBJECT_ID('QEPD.newRendicion','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newRendicion

IF OBJECT_ID('QEPD.getTotalValoresPagos','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getTotalValoresPagos

IF OBJECT_ID('QEPD.getPago','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getPago

IF OBJECT_ID('QEPD.getPagos','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getPagos

IF OBJECT_ID('QEPD.getRenglonFactura','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRenglonFactura

IF OBJECT_ID('QEPD.getRenglonPago','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRenglonPago

IF OBJECT_ID('QEPD.getRenglonesPago','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getRenglonesPago

IF OBJECT_ID('QEPD.newRenglonPago','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newRenglonPago

IF OBJECT_ID('QEPD.newPago','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newPago

IF OBJECT_ID('QEPD.getTotalValorFacturas','P') IS NOT NULL  
	DROP PROCEDURE QEPD.getTotalValorFacturas

IF OBJECT_ID('QEPD.newRenglonRendicion','P') IS NOT NULL  
	DROP PROCEDURE QEPD.newRenglonRendicion
	


/* Se dropea schema */ 


IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'QEPD')
    DROP SCHEMA QEPD

GO



/* Se crea schema */ 

CREATE SCHEMA QEPD AUTHORIZATION gd

GO

/* Se crean las tablas */

CREATE TABLE QEPD.Domicilio(
IdDomicilio int IDENTITY(1,1) PRIMARY KEY,
Direccion nvarchar(255)  NOT NULL,
Cod_Postal nvarchar(255) NULL
);

CREATE TABLE QEPD.Cliente(
IdCliente int IDENTITY(1,1) PRIMARY KEY,
Dni_Cliente numeric NOT NULL UNIQUE, /*el dni lo hice unique*/
Nombre_Cliente nvarchar(255) NOT NULL,
Apellido_Cliente nvarchar(255)  NOT NULL,
Email_Cliente nvarchar(255) NOT NULL,
Fecha_Nac_Cliente datetime NOT NULL,
Telefono_Cliente numeric(18,0) NULL, 
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
Estado_Cliente BIT DEFAULT 1 
);

create table qepd.Rubro(
Nro_Rubro numeric IDENTITY(1,1) NOT NULL,  /* Se elimina idRubro dado que el Nro es unico y se puede utilizar como PK */
Descripcion_Rubro nvarchar(50) NULL, /* Se setea NULL dado que al cargar la empresa solo definimos su Nro de Rubro,*/
PRIMARY KEY (Nro_Rubro)            /*no se cuenta con ABM rubro para completar la descripcion del mismo */
)

create table qepd.Empresa(
IdEmpresa int IDENTITY(1,1) PRIMARY KEY,
Nombre_Empresa nvarchar(255) NOT NULL,
Cuit nvarchar(50) NOT NULL,
Fecha_Rendicion datetime NULL,
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
IdRubro numeric FOREIGN KEY REFERENCES QEPD.Rubro(Nro_Rubro),
Estado_Empresa BIT DEFAULT 1
)

create table qepd.Sucursal(
CP_Sucursal numeric(18,0) PRIMARY KEY,
Nombre_Sucursal nvarchar(50) NOT NULL,
Direccion_Sucursal nvarchar(50) NOT NULL,
Estado_Sucursal BIT default 1	
)

create table qepd.Factura(
Nro_Factura numeric(18,0) PRIMARY KEY,
FechaAlta_Factura datetime NOT NULL,
Fecha_Venc_Factura datetime NOT NULL,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
IdCliente int FOREIGN KEY REFERENCES QEPD.Cliente(IdCliente),
Total_Factura numeric(18,2) NOT NULL,
Pago_Estado bit default 1
)

create table qepd.Renglon_Factura(
IdRenglon_Factura int IDENTITY(1,1) PRIMARY KEY, 
Item_Monto_Factura numeric(18,2) NOT NULL,
Item_Cant_Factura numeric(18,0) NOT NULL,
Item_descripcion nvarchar(255) NULL,
Nro_Factura numeric(18,0) FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura)
)

create table qepd.Forma_Pago(
IdForma_Pago int IDENTITY(1,1) PRIMARY KEY,
Descripcion_Pago nvarchar(255) NOT NULL,
)

create table qepd.Pago(
Nro_Pago numeric IDENTITY(1,1) PRIMARY KEY,
Fecha_Cobro_Pago datetime NULL,
CodigoPostal_Sucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
Total_Pago numeric(18,2) NULL,  /* Lo que paga el cliente, no calculado como la suma de las facturas que contiene*/
Tipo_pago int FOREIGN KEY REFERENCES QEPD.Forma_Pago(IdForma_Pago),
Estado_Rendicion_Pago BIT DEFAULT 0 /* Indica si el pago fue rendido o no? */

)


create table qepd.Renglon_Pago(
IdRenglon_Pago int IDENTITY(1,1) PRIMARY KEY,
Nro_Factura numeric(18,0) FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura),
Nro_Pago numeric(18,0) FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa)
)

create table qepd.Rendicion(
IdRendicion numeric IDENTITY(1,1) PRIMARY KEY NOT NULL,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
Cantidad_Facturas numeric(18,0) NULL, /*caculable*/
Fecha_Rendicion datetime NOT NULL,
Porcentaje_Comision numeric(18,2) DEFAULT 0.1,
Importe_Comision numeric(18,2) NULL, /* calcuable a partir de partir del total de facturas y porcentaje*/
Total_Rendicion numeric(18,2) NULL 
)

create table qepd.Renglon_Rendicion(
IdRenglon_Rendicion int IDENTITY(1,1) PRIMARY KEY,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
Monto_Pago numeric(18,2) NOT NULL,
IdRendicion numeric FOREIGN KEY REFERENCES QEPD.Rendicion(IdRendicion)
)

create table qepd.Devolucion(
IdDevolucion int IDENTITY(1,1) PRIMARY KEY,
Motivo_Devolucion nvarchar(255) NOT NULL,
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago)
)



create table qepd.Funcionalidad(
IdFuncionalidad int IDENTITY(1,1) PRIMARY KEY,
Nombre_Funcionalidad nvarchar(255) NOT NULL
)

create table qepd.Rol(
IdRol int IDENTITY(1,1) PRIMARY KEY,
Nombre_Rol nvarchar(255) NOT NULL UNIQUE,
Estado_Rol BIT DEFAULT 1
)

create table qepd.RolPorFuncionalidad(
IdRol int FOREIGN KEY REFERENCES QEPD.Rol(IdRol),
IdFuncionalidad int FOREIGN KEY REFERENCES QEPD.Funcionalidad(IdFuncionalidad),
CONSTRAINT IdRolPorFuncionalidad PRIMARY KEY(IdFuncionalidad,IdRol)
)

create table qepd.Usuario(
IdUsuario int IDENTITY(1,1) PRIMARY KEY,
Nombre_Usuario nvarchar(255) NOT NULL UNIQUE,
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


/********************** Migración de  tablas **************************/


/* Migracion domicilio */ 


INSERT INTO QEPD.Domicilio(Direccion,Cod_Postal)
           SELECT DISTINCT  m.Cliente_Direccion, m.Cliente_Codigo_Postal
           FROM gd_esquema.Maestra m
           WHERE m.Cliente_Direccion IS NOT NULL
UNION ALL
           SELECT DISTINCT  e.Empresa_Direccion, NULL
           FROM gd_esquema.Maestra e
           WHERE e.Empresa_Direccion IS NOT NULL

/* Migracion  Cliente */

INSERT INTO QEPD.Cliente(Dni_Cliente,Nombre_Cliente,Apellido_Cliente, Email_Cliente,Fecha_Nac_Cliente,IdDomicilio)
			SELECT DISTINCT m.[Cliente-Dni], m.[Cliente-Nombre], m.[Cliente-Apellido], m.Cliente_Mail, m.[Cliente-Fecha_Nac], c.IdDomicilio
			FROM gd_esquema.Maestra m, QEPD.Domicilio c
			WHERE m.[Cliente-Dni] IS NOT NULL AND c.Direccion = m.Cliente_Direccion

/* Migracion Rubro */
SET IDENTITY_INSERT  QEPD.Rubro ON

INSERT INTO QEPD.Rubro(Nro_Rubro,Descripcion_Rubro)
			SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion
			FROM gd_esquema.Maestra
			WHERE Empresa_Rubro IS NOT NULL
SET IDENTITY_INSERT  QEPD.Rubro OFF

/* Migracion Empresa */
SET ANSI_WARNINGS OFF ----- VER

INSERT INTO QEPD.Empresa(Nombre_Empresa,Cuit,IdDomicilio,IdRubro,Fecha_Rendicion)
			SELECT DISTINCT m.Empresa_Nombre, m.Empresa_Cuit, d.IdDomicilio, r.Nro_Rubro, MAX(Rendicion_Fecha)
			FROM gd_esquema.Maestra m, QEPD.Domicilio d, QEPD.Rubro r
			WHERE  m.Empresa_Cuit IS NOT NULL AND m.Empresa_Direccion = d.Direccion AND m.Empresa_Rubro = r.Nro_Rubro
			GROUP BY m.Empresa_Nombre, m.Empresa_Cuit, d.IdDomicilio, r.Nro_Rubro
SET ANSI_WARNINGS ON
/* Migracion Sucursal */

INSERT INTO QEPD.Sucursal(CP_Sucursal,Nombre_Sucursal,Direccion_Sucursal)
			SELECT DISTINCT Sucursal_Codigo_Postal, Sucursal_Nombre, Sucursal_Dirección
			FROM gd_esquema.Maestra 
			WHERE Sucursal_Codigo_Postal IS NOT NULL



/* Migracion Factura */

INSERT INTO QEPD.Factura(Nro_Factura,FechaAlta_Factura,Fecha_Venc_Factura,IdEmpresa,IdCliente,Total_Factura)
		SELECT DISTINCT m.Nro_Factura, m.Factura_Fecha, m.Factura_Fecha_Vencimiento, e.IdEmpresa, c.IdCliente,m.Factura_Total
		FROM gd_esquema.Maestra m, QEPD.Empresa e, QEPD.Cliente c
		WHERE Nro_Factura IS NOT NULL AND m.[Cliente-Dni] = c.Dni_Cliente AND m.Empresa_Cuit = e.Cuit

/* Migracion Renglon Factura */

INSERT INTO QEPD.Renglon_Factura(Item_Monto_Factura,Item_Cant_Factura,Nro_Factura) 
		SELECT m.ItemFactura_Monto, m.ItemFactura_Cantidad, m.Nro_Factura
		FROM gd_esquema.Maestra m , QEPD.Factura f
		WHERE m.ItemFactura_Cantidad IS NOT NULL AND m.Nro_Factura = f.Nro_Factura

/* Migracion Forma de Pago */


INSERT INTO QEPD.Forma_Pago(Descripcion_Pago) 
			SELECT DISTINCT FormaPagoDescripcion
			FROM gd_esquema.Maestra
			WHERE FormaPagoDescripcion IS NOT NULL

/* Migracion Pago */

set identity_insert qepd.pago on
INSERT INTO QEPD.Pago(Nro_Pago,Fecha_Cobro_Pago, CodigoPostal_Sucursal, Total_Pago, Tipo_pago)
			SELECT DISTINCT m.Pago_nro, m.Pago_Fecha, s.CP_Sucursal, m.Total, fp.IdForma_Pago
			FROM gd_esquema.Maestra m, QEPD.Sucursal s, QEPD.Forma_Pago fp
			WHERE m.Pago_nro IS NOT NULL AND m.Sucursal_Codigo_Postal = s.CP_Sucursal AND m.FormaPagoDescripcion = fp.Descripcion_Pago
set identity_insert qepd.pago off

/* Migracion Renglon Pago  */ 

INSERT INTO QEPD.Renglon_Pago(Nro_Factura,Nro_Pago,IdEmpresa) 
		SELECT m.Nro_Factura, m.ItemPago_nro, e.IdEmpresa
		FROM gd_esquema.Maestra m 
		LEFT JOIN QEPD.Factura f
		ON  f.Nro_Factura= m.Nro_Factura
		LEFT JOIN QEPD.Pago p
		ON m.ItemPago_nro = p.Nro_Pago
		INNER JOIN QEPD.Empresa e
		ON m.Empresa_Cuit = e.Cuit   
		WHERE p.Nro_Pago IS NOT NULL  


/* Migracion Rendicion */ 

SET IDENTITY_INSERT  QEPD.Rendicion ON

INSERT INTO QEPD.Rendicion(IdRendicion, IdEmpresa,Fecha_Rendicion,Total_Rendicion)
		SELECT DISTINCT tb.Rendicion_Nro, e.IdEmpresa, tb.Rendicion_Fecha, tb.ItemRendicion_Importe
		FROM gd_esquema.Maestra tb, QEPD.Empresa e 
		WHERE tb.Rendicion_Nro IS NOT NULL

SET IDENTITY_INSERT  QEPD.Rendicion OFF

/* Migracion Renglon Rendicion  */


INSERT INTO QEPD.Renglon_Rendicion(Nro_Pago,Monto_Pago,IdRendicion)
		SELECT  p.Nro_Pago, tb.Total ,r.IdRendicion
		FROM gd_esquema.Maestra tb/*, QEPD.Pago p, QEPD.Rendicion r*/
		LEFT JOIN QEPD.Pago p
		ON  p.Nro_Pago = tb.Pago_nro
		LEFT JOIN QEPD.Rendicion r
		ON r.IdRendicion = tb.Rendicion_Nro
		WHERE Rendicion_Nro IS NOT NULL


/* Carga Rol */

INSERT INTO QEPD.Rol(Nombre_Rol) VALUES ('Administrador') /* 1 */

INSERT INTO QEPD.Rol(Nombre_Rol) VALUES ('Cobrador') /* 2 */

/* Carga Funcionalidades */

INSERT INTO QEPD.Funcionalidad(Nombre_Funcionalidad) 
		VALUES	('ABM Cliente'),  /* 1 */
				('ABM Factura'), /* 2 */
				('Cobrar Factura'),  /* 3 */
				('ABM Rol'), /* 4 */
				('ABM Empresa'), /* 5*/
				('ABM Sucursal'), /* 6*/
				('Rendir Pago'), /* 7 */
				('Devolver Pago') /* 8*/


/* Carga RolxFuncionalidad */

INSERT INTO QEPD.RolPorFuncionalidad(IdRol,IdFuncionalidad)
	VALUES	(1,2),
			(1,3),
			(1,4),
			(1,5),
			(1,6),
			(1,7),
			(1,8),
			(2,1),
			(2,2),
			(2,3),
			(2,8)

/* Usuario */

INSERT INTO QEPD.Usuario(Nombre_Usuario,Pass_Usuario)
		VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7'),
		('Gonza', '05607a38d929755d5c4466d72c9b9ba8261b6be94c6fd5477503c83ed8d50f09'),
		('Jesus', 'a54e71f0e17f5aaf7946e66ab42cf3b1fd4e61d60581736c9f0eb1c3f794eb7c')


/* Carga RolxUsuario */

INSERT INTO QEPD.RolPorUsuario(IdRol,IdUsuario)
		VALUES (1,1),
				(2,2),
				(2,3)

INSERT INTO QEPD.UsuarioPorSucursal(IdUsuario,CP_Sucursal)
		VALUES	(1,7210),
				(2,7210),
				(3,7210)



/***********************************************************************Procedures*****************************************************************************************************************/

/*-------------------Los dividi Por Repositorios----------------------*/



/*Repo Usuarios*/
/*
-validarUsuario
-bloquearUsuario
-reabilitarUsuario
-getUsuario
-getRolesUsuario
-asignarRolUsuario
-getFuncionalidadesDeUnRolDeUsuario
-getFuncionalidadesDeTodosLosRolesDeUsuario
*/

GO
create procedure QEPD.validarUsuario
@usuarioNombre nvarchar(255),
@pass nvarchar(255)
as
begin
if exists (select s.Nombre_Usuario, s.Pass_Usuario, s.Estado_Usuario from qepd.Usuario s where s.Nombre_Usuario = @usuarioNombre and s.Pass_Usuario = @pass and s.Estado_Usuario = 1)
	begin
		update QEPD.Usuario set Logs_Fallidos = 0 WHERE Nombre_Usuario = @usuarioNombre
		return 1
	end
else
	if exists (select s.Nombre_Usuario, s.Estado_Usuario from qepd.Usuario s WHERE s.Nombre_Usuario = @usuarioNombre and s.Estado_Usuario = 1)
		begin
			update QEPD.Usuario set Logs_Fallidos = Logs_Fallidos + 1 WHERE Nombre_Usuario = @usuarioNombre 
			return 0
		end
	else
		return -1
end


GO
create procedure qepd.bloquearUsuario /*En el metodo validar usuario del controller, no solo se llama al metodo validarUsuario del repo, sino tambien
										existira un metodo del repo que se llamara bloquear usuario que usara este procedure
										En el codigo del metodo validar usuario del CONTROLLER, valida el usuario, y puede hacerlo hasta 4 veces
										si llego a la cuarta, el metodo del controller, llama a bloquearUsuario del repo, y este usa este procedure*/
@usuarioId int
as
update QEPD.Usuario set Estado_Usuario = 0 where IdUsuario =  @usuarioId


GO
create procedure qepd.rehabilitarUsuario /* Para rehabilitar un usuario previamente bloqueado */
@usuarioId int
as
update QEPD.Usuario set Estado_Usuario = 1 where IdUsuario =  @usuarioId


GO
create procedure qepd.getUsuario
@usuarioNombre nvarchar(255)
as
select * from QEPD.Usuario s where s.Nombre_Usuario = @usuarioNombre

GO

CREATE PROCEDURE QEPD.getUsuarioSucursales /* Paso idUsuario , devuelve todas las sucursales en las cuales puede ingresar el usuario */
@idUsuario int
AS                                           
       SELECT CP_Sucursal, Nombre_Sucursal FROM QEPD.Sucursal
			WHERE CP_Sucursal = (SELECT us.CP_Sucursal FROM UsuarioPorSucursal us WHERE IdUsuario = @idUsuario)       
	
GO


create procedure QEPD.getRolesUsuario /*cuando necesites una lista de roles de un usuario*/
@IdUsuario int
as
begin
	select r.IdRol, Nombre_Rol, Estado_Rol 
	from qepd.Usuario s 
		join QEPD.RolPorUsuario rs
			on rs.IdUsuario = s.IdUsuario
		join QEPD.Rol r
			on rs.IdRol = r.IdRol

	where s.IdUsuario = @IdUsuario
end


GO
create procedure qepd.asignarRolUsuario /*En el metodo del repo, por parametro recibe un OBJETO usuario, y el Nombre de un rol
							 Teniendo este objeto rol, saco su ID
						     Paso el ID a este procedure*/
@usuarioId int,
@nombreRol int
as
begin
	declare @usuario int
	declare @rol int
	set @usuario = (select u.IdUsuario from QEPD.Usuario u where u.IdUsuario = @usuarioId)
	insert into QEPD.Rol (Nombre_Rol) values (@nombreRol)
	set @rol = (select r.IdRol from QEPD.Rol r where r.Nombre_Rol = @nombreRol)
	insert into QEPD.RolPorUsuario (IdRol,IdUsuario) values (@rol, @usuario)
end

GO
create procedure QEPD.getFuncionalidadesDeUnRolDeUsuario /*cuando necesites una lista de funcionalidades de un rol de un usuario*/
@usuarioId int,
@rolId int
as
begin
	select f.IdFuncionalidad, f.Nombre_Funcionalidad 
	from Usuario u
		join RolPorUsuario ru
			on ru.IdUsuario = u.IdUsuario
		join Rol r
			on r.IdRol = ru.IdRol
		join RolPorFuncionalidad rf
			on rf.IdRol = r.IdRol
		join Funcionalidad f
			on f.IdFuncionalidad = rf.IdFuncionalidad
	where r.IdRol = @rolId and u.IdUsuario = @usuarioId
end


GO
create procedure QEPD.getFuncionalidadesDeTodosLosRolesDeUsuario /*cuando necesites una lista de funcionalidades de un usuario*/
@usuarioId int
as
begin
	select f.IdFuncionalidad, f.Nombre_Funcionalidad 
	from Usuario u
		join RolPorUsuario ru
			on ru.IdUsuario = u.IdUsuario
		join Rol r
			on r.IdRol = ru.IdRol
		join RolPorFuncionalidad rf
			on rf.IdRol = r.IdRol
		join Funcionalidad f
			on f.IdFuncionalidad = rf.IdFuncionalidad
	where u.IdUsuario = @usuarioId
end



/*Repo Roles*/

/*
-getRol
-getRoles
-modificarRol
-eliminarRol (deberia ser trigger)
-getFuncionalidadesDeUnRol
-agregarFuncionalidadARol
-eliminarFuncionalidadARol
*/

GO
create procedure qepd.getRol
@rolNombre nvarchar(255)
as
select * from QEPD.Rol r where r.Nombre_Rol = @rolNombre

 
GO
 create procedure qepd.getRoles   
 as
 select * from QEPD.Rol


GO 
 create procedure qepd.modificarRol 								    								   
 @rolId int,
 @rolNombreNuevo nvarchar(255)
 as
 update QEPD.Rol set Nombre_Rol = @rolNombreNuevo where IdRol = @rolId


GO
create procedure qepd.eliminarRol
@rolId int
as
update qepd.Rol set Estado_Rol = 0 where IdRol = @rolId

GO
create procedure QEPD.getFuncionalidadesDeUnRol /*cuando necesites una lista de funcionalidades de un rol*/
@rolId int
as
begin
	select f.IdFuncionalidad, f.Nombre_Funcionalidad 
	from Rol r
		join RolPorFuncionalidad rf
			on rf.IdRol = r.IdRol
		join Funcionalidad f
			on f.IdFuncionalidad = rf.IdFuncionalidad
	where r.IdRol = @rolId
end


GO
create procedure qepd.agregarFuncionalidadARol /*es para agregar una funcionalidad a un rol, probablemente el ABM rol*/
										        /*el metodo del repo recibe un objeto rol del cual se obtiene su ID y ademas el id de una funcionalidad*/
@rolId int,
@funcionalidadId int
as
	insert into QEPD.RolPorFuncionalidad values (@rolId, @funcionalidadId)


GO
create procedure qepd.eliminarFuncionalidadARol /*es para eliminar una funcionalidad de un rol, probablemente el ABM rol*/
										        /*el metodo del repo recibe un objeto rol del cual se obtiene su ID y ademas el id de una funcionalidad*/
@rolId int,
@funcionalidadId int
as
	delete from QEPD.RolPorFuncionalidad where IdRol = @rolId and IdFuncionalidad = @funcionalidadId


/*Repo Funcionalidades*/
/*
-getFuncionalidad
-getFuncionalidades
*/

GO
create procedure qepd.getFuncionalidad /*cundo necesites solo UNA Funcionalidad*/
@nombreFuncionalidad nvarchar(255)
as
select * from QEPD.Funcionalidad f where f.Nombre_Funcionalidad = @nombreFuncionalidad

GO
create procedure qepd.getFuncionalidades
as
select * from qepd.Funcionalidad


/*Repo Clientes*/

GO
create procedure qepd.getClientes
as
select * from qepd.Cliente


GO
create procedure qepd.getCliente
@Dni_Cliente nvarchar(255) /*  */ 
as
select * from QEPD.Cliente c where c.Dni_Cliente = @Dni_Cliente /* cambio @clienteNombre*/


GO
CREATE PROCEDURE QEPD.getClientesActivos
AS
SELECT * FROM QEPD.CLIENTE WHERE IdCliente = 1


GO
create procedure qepd.newCliente
@nombre nvarchar(255),
@apellido nvarchar(255),
@dni numeric,
@mail nvarchar(255),
@telefono numeric(18,0),
@fnacimiento datetime,
@direccion nvarchar(255),
@cp nvarchar(255)
as
begin
	declare @direction int

	insert into QEPD.Domicilio values (@direccion,@cp)

	set @direction = (select d.IdDomicilio from QEPD.Domicilio d where d.Cod_Postal = @cp and d.Direccion = @direccion)

	insert into QEPD.Cliente (Dni_Cliente, Nombre_Cliente,Apellido_Cliente,Email_Cliente,Fecha_Nac_Cliente,Telefono_Cliente,IdDomicilio)
	values (@dni, @nombre, @apellido, @mail, @fnacimiento, @telefono, @direction)
end


GO
create procedure qepd.modificarCliente /*el metodo del repo recibe un objeto cliente del cual sacamos su Id*/
@idCliente int,
@nombre nvarchar(255),
@apellido nvarchar(255),
@dni numeric,
@mail nvarchar(255),
@telefono numeric(18,0),
@fnacimiento datetime,
@estado bit,
@direccion nvarchar(255),
@cp nvarchar(255)
as
begin
	declare @direction int

	insert into QEPD.Domicilio
	values (@direccion,@cp)

	set @direction = (select d.IdDomicilio from QEPD.Domicilio d where d.Cod_Postal = @cp and d.Direccion = @direccion)

	update QEPD.Cliente set Dni_Cliente = @dni, Nombre_Cliente = @nombre, Apellido_Cliente = @apellido, Email_Cliente = @mail, Fecha_Nac_Cliente = @fnacimiento, Telefono_Cliente = @telefono, IdDomicilio = @direction where IdCliente = @idCliente
	
end


GO
create procedure qepd.eliminarCliente
@idCliente int
as
update QEPD.Cliente set Estado_Cliente = 0 where IdCliente = @idCliente


GO
CREATE PROCEDURE  QEPD.habilitarCliente /* recibo el dni*/
@dniCliente numeric(18,0)
as
update QEPD.Cliente set Estado_Cliente = 1 where Dni_Cliente = @dniCliente


GO
create procedure qepd.validarCliente
@dniCliente numeric
as
if exists (select c.Dni_Cliente from qepd.Cliente c where c.Dni_Cliente = @dniCliente)
	return 1
else
	return 0



 /* Repo Empresas */

GO
CREATE PROCEDURE QEPD.getEmpresas /* Devuelve todas las empresas */
AS
SELECT * FROM QEPD.Empresa

GO 

CREATE PROCEDURE QEPD.getEmpresasActivas /* Devuelve todas las empresas activas */
AS
SELECT * FROM QEPD.Empresa WHERE Estado_Empresa = 1

GO

CREATE PROCEDURE QEPD.getEmpresaCuit /* Devuelve UNA empresa, buscandola por cuit x-xxxxxxx-x */
@Cuit_Empresa nvarchar(50)
AS
	SELECT * FROM QEPD.Empresa e WHERE e.Cuit = @Cuit_Empresa

GO

CREATE PROCEDURE QEPD.getEmpresaNombre /* Devuelve UNA empresa, buscandola por nombre (nvarchar (255)) */
@Nombre_Empresa nvarchar(255)
AS
	SELECT * FROM QEPD.Empresa e WHERE e.Nombre_Empresa = @Nombre_Empresa

GO

CREATE PROCEDURE QEPD.newEmpresa /* Creo una empresa, rubro lo seteo por su descripcion, valido que no repita ni domicilio */
@Nombre_Empresa nvarchar(255),          /* ni rubro de la empresa si ya existen en sus tablas*/
@Cuit_Empresa nvarchar(50),
@Direccion_Empresa nvarchar(255),
@descripcionRubro_Empresa nvarchar(50)

AS
	BEGIN
		DECLARE @direction INT
		DECLARE @rubro nvarchar(50)

		IF NOT EXISTS(SELECT d.Direccion FROM QEPD.Domicilio d WHERE d.Direccion = @Direccion_Empresa) /* VALIDACION DIRECCION EXISTENTE */
			INSERT INTO QEPD.Domicilio(Direccion) VALUES (@Direccion_Empresa)
			
		SET @direction = (SELECT dom.IdDomicilio FROM QEPD.Domicilio dom WHERE dom.Direccion = @Direccion_Empresa)
		
		 
		IF NOT EXISTS (SELECT r.Nro_Rubro FROM QEPD.Rubro r WHERE r.Descripcion_Rubro = @descripcionRubro_Empresa)/* VALIDACION RUBRO EXISTENTE */ 
			INSERT INTO QEPD.Rubro (Descripcion_Rubro) VALUES (@descripcionRubro_Empresa)

		SET @rubro = (SELECT r.Nro_Rubro FROM QEPD.Rubro r WHERE r.Descripcion_Rubro = @descripcionRubro_Empresa)
		
		INSERT INTO QEPD.Empresa(Nombre_Empresa,Cuit,IdDomicilio,IdRubro,Fecha_Rendicion)
			VALUES (@Nombre_Empresa,@Cuit_Empresa,@direction,@rubro,GETDATE())
	END

GO

CREATE PROCEDURE QEPD.modificarEmpresa /* el metodo del repo recibe un objeto empresa del cual sacamos su id */
@idEmpresa int,
@Nombre_Empresa nvarchar(255),
@Cuit_Empresa nvarchar(50),
@Direccion_Empresa nvarchar(255),
@descripcionRubro_Empresa nvarchar(50),
@Fecha_Rendicion datetime,
@estado bit
AS
	BEGIN
		DECLARE @direction INT
		DECLARE @rubro nvarchar(50)
		
		IF NOT EXISTS(SELECT d.Direccion FROM QEPD.Domicilio d WHERE d.Direccion = @Direccion_Empresa) /* VALIDACION DIRECCION EXISTENTE */
		INSERT INTO QEPD.Domicilio(Direccion) VALUES (@Direccion_Empresa) /* Agrego domicilio a tabla domicilio */ 
		/* Obtengo el id del domicilio */	
		SET @direction = (SELECT dom.IdDomicilio FROM QEPD.Domicilio dom WHERE dom.Direccion = @Direccion_Empresa)
		

		IF NOT EXISTS (SELECT r.Nro_Rubro FROM QEPD.Rubro r WHERE r.Descripcion_Rubro = @descripcionRubro_Empresa)/* VALIDACION RUBRO EXISTENTE */ 
			INSERT INTO QEPD.Rubro (Descripcion_Rubro) VALUES (@descripcionRubro_Empresa)
		/* obtengo el rubroId para cargar */
		SET @rubro = (SELECT r.Nro_Rubro FROM QEPD.Rubro r WHERE r.Descripcion_Rubro = @descripcionRubro_Empresa) 
		
		UPDATE QEPD.Empresa SET Nombre_Empresa = @Nombre_Empresa, Cuit = @Cuit_Empresa, IdDomicilio = @direction, IdRubro = @rubro, Fecha_Rendicion = @Fecha_Rendicion
		WHERE IdEmpresa = @idEmpresa 
	END

GO

CREATE PROCEDURE QEPD.eliminarEmpresa /* recibo el id de la empresa a eliminar */
@idEmpresa int
AS
	UPDATE QEPD.Empresa SET Estado_Empresa = 0 WHERE IdEmpresa = @idEmpresa

GO

CREATE PROCEDURE QEPD.habilitarEmpresa /* recibo el cuit de la empresa x-xxxxxx-x nvarchar */
@cuitEmpresa nvarchar(50)
AS
	UPDATE QEPD.Empresa SET Estado_Empresa = 1 WHERE Cuit = @cuitEmpresa

GO


CREATE PROCEDURE QEPD.validarEmpresa /* Valida si existe la empresa por el cuit ingresado x-xxxxxxx-x */
@cuitEmpresa nvarchar(55)
AS
	IF EXISTS( SELECT e.Cuit FROM QEPD.Empresa e WHERE e.Cuit = @cuitEmpresa)
		RETURN 1
	ELSE
		RETURN 0

GO

/* Repo Sucursal */

CREATE PROCEDURE QEPD.getSucursales /* Devuelve todas las sucursales para el listado de ABM, donde el listado debe poder filtrar por cualquiera */
AS                                           /* de sus campos (CP_Sucursal numeric(18,0) PRIMARY KEY, Nombre_Sucursal nvarchar(50) NOT NULL, */
       SELECT * FROM QEPD.Sucursal          /*  Direccion_Sucursal nvarchar(50) NOT NULL, */
	
GO

CREATE PROCEDURE QEPD.getSucursalNombre
@SucursalNombre nvarchar(50)
AS                                           
       SELECT * FROM QEPD.Sucursal WHERE Nombre_Sucursal = @SucursalNombre         
	
GO


CREATE PROCEDURE QEPD.modificarSucursal /* el metodo del repo recibe un objeto sucursal del cual sacamos su id */
@CodPostalDeSucursalAModificar numeric(18,0),
@CodPostal numeric(18,0),
@SucursalNombre nvarchar(50),
@SucursalDirecc nvarchar(50)

AS
	UPDATE QEPD.Sucursal set CP_Sucursal = @CodPostal, Nombre_Sucursal = @SucursalNombre, Direccion_Sucursal = @SucursalDirecc 
	WHERE CP_Sucursal = @CodPostalDeSucursalAModificar


GO

CREATE PROCEDURE QEPD.newSucursal 
@CodPostal numeric(18,0),
@SucursalNombre nvarchar(50),
@SucursalDirecc nvarchar(50)
AS
      

	IF NOT EXISTS(SELECT s.CP_Sucursal FROM QEPD.Sucursal s WHERE s.CP_Sucursal = @CodPostal ) /* VALIDACION Sucursal existente */
			INSERT INTO QEPD.Sucursal(CP_Sucursal,Nombre_Sucursal,Direccion_Sucursal) VALUES (@CodPostal,@SucursalNombre, @SucursalDirecc)
		
GO

--TO DO - Eliminar Sucursal /* TRIGGER ? */

CREATE PROCEDURE QEPD.EliminarSucursal /* Recibe IdSucursal */
@CP_Sucursal numeric(18,0)
AS 
	UPDATE QEPD.Sucursal set Estado_Sucursal = 0 where CP_Sucursal = @CP_Sucursal


GO


/*Repo facturas*/
/*
getFacturas
getFactura
getRenglonesFactura
getRenglonFactura
newFactura
newRenglonFactura
getTotaldeFactura
*/

GO
create procedure qepd.getFacturas
as
select * from qepd.Factura f


GO
create procedure qepd.getFactura
@idFactura numeric(18,0)
as
select * from QEPD.Factura f where f.Nro_Factura = @idFactura


GO
create procedure qepd.getRenglonesFactura
@idFactura numeric(18,0)
as
select * from qepd.Renglon_Factura r where r.Nro_Factura = @idFactura


GO
create procedure qepd.getRenglonFactura
@idRenglon int
as
select * from qepd.Renglon_Factura r where r.IdRenglon_Factura = @idRenglon


GO
create procedure qepd.newFactura
@nroFactura numeric(18,0),
@fecha_vto datetime,
@idEmpresa int,
@idCliente int
as
begin
insert into Factura (Nro_Factura,FechaAlta_Factura,Fecha_Venc_Factura,IdEmpresa, IdCliente, Total_Factura) values (
@nroFactura, 
GETDATE(), 
@fecha_vto, 
@idEmpresa, 
@idCliente, 
(select sum(r.Item_Cant_Factura*r.Item_Monto_Factura) from Renglon_Factura r where r.Nro_Factura = @nroFactura)
)
end


GO
create procedure qepd.newRenglonFactura
@idFactura numeric(18,0),
@monto numeric(18,2),
@cantidad numeric(18,0),
@descripcion nvarchar(255)
as
insert into Renglon_Factura(Item_Monto_Factura,Item_Cant_Factura,Item_descripcion,Nro_Factura) values (@monto, @cantidad, @descripcion, @idFactura)


GO
create procedure qepd.getTotaldeFactura
@idFactura numeric(18,0)
as
select sum(r.Item_Cant_Factura*r.Item_Monto_Factura) from Renglon_Factura r where r.Nro_Factura = @idFactura



/*Repo Pagos*/
/*
getPago
getPagos
getRenglonesPago
getRenglonPago
newRenglonPago
newPago
getTotalValorFacturas
*/

GO
create procedure qepd.getPago
@idPago numeric
as
select * from QEPD.Pago p where p.Nro_Pago = @idPago

GO
create procedure qepd.getPagos
as
select * from qepd.Pago


GO
create procedure qepd.getRenglonesPago
@idPago numeric(18,0)
as
select * from QEPD.Renglon_Pago r where r.Nro_Pago = @idPago 


GO
create procedure qepd.getRenglonPago
@idRenglon int
as
select * from qepd.Renglon_Pago r where r.IdRenglon_Pago = @idRenglon


GO
create procedure qepd.newRenglonPago
@nroFactura numeric(18,0),
@idEmpresa int
as
insert into qepd.Renglon_Pago (Nro_Factura, IdEmpresa) values(@nroFactura, @idEmpresa)


GO
create procedure qepd.newPago
@cpSucursal numeric,
@pagoTotal numeric(18,2),
@tipoPago int
as
begin
insert into qepd.Pago (Fecha_Cobro_Pago, CodigoPostal_Sucursal, Total_Pago, Tipo_pago)
	values(GETDATE(), @cpSucursal, @pagoTotal, @tipoPago)
end


GO
create procedure qepd.getTotalValorFacturas
@idPago numeric
as
begin
select sum(f.Total_Factura) 
from qepd.Renglon_Pago r
	join QEPD.Factura f
		on f.Nro_Factura = r.Nro_Factura
where r.Nro_Pago = @idPago
end

GO

/* Repo Rendiciones */ 

/*
getRendiciones
getRendicionesHistoricasxEmpresa
getEmpresasARendirHoy
getRenglonesRendicion
getRenglonRendicion
newRenglonRendicion 
getCantidadFacturasRendicion 
newRendicion
getTotalValoresPagos



*/

 
CREATE PROCEDURE QEPD.getRendiciones /* Toma todas las rendiciones */
AS
	SELECT * FROM QEPD.Rendicion 

GO

CREATE PROCEDURE QEPD.getRendicionesHistoricasxEmpresa /* Devuelve el historico de rendiciones por empresa con su ID */
@idEmpresa int
AS
	SELECT * FROM QEPD.Rendicion r
	WHERE IdEmpresa = @idEmpresa


GO


CREATE PROCEDURE QEPD.getEmpresasARendirHoy /* Devuelve empresas a rendir hoy */
AS
	SELECT * FROM QEPD.Empresa
	WHERE Fecha_Rendicion = GETDATE()-30


GO

CREATE PROCEDURE QEPD.getRenglonesRendicion
@idRendicion int
AS
SELECT * FROM QEPD.Renglon_Rendicion WHERE IdRendicion = @idRendicion

GO

CREATE PROCEDURE QEPD.getRenglonRendicion
@idRenglonRend int
AS
SELECT * FROM QEPD.Renglon_Rendicion WHERE IdRenglon_Rendicion = @idRenglonRend

GO

CREATE PROCEDURE QEPD.newRenglonRendicion /* Inserto un nuevo renglon de rend, con el Nro de rendicion al que apunta */
@idRendicion int,                       /* El nro de pago que va a ser cargado como renglon y el monto del mismo */
@NroPago numeric(18,0),
@MontoPago numeric(18,2)
AS
INSERT INTO QEPD.Renglon_Rendicion (IdRendicion,Nro_Pago,Monto_Pago) VALUES (@idRendicion,@NroPago,@MontoPago)
	
GO

CREATE PROCEDURE QEPD.getCantidadFacturasRendicion /* devuelve cantidad de facturas por una determinada rendicion que le paso */
@idRendicion numeric(18,0)
AS
	SELECT COUNT(idRendicion) FROM QEPD.Renglon_Rendicion WHERE IdRendicion = @idRendicion

GO

CREATE PROCEDURE QEPD.newRendicion /* seteo solo empresa y fecha, el resto tengo que calcularlo cuando termine de cargarle los renglones.*/ 
@idEmpresa int
-- Fecha rend getdate
AS
INSERT INTO QEPD.Rendicion(IdEmpresa, Fecha_Rendicion) VALUES (@idEmpresa,GETDATE())

GO
/*
CREATE PROCEDURE getTotalValoresPagos
@idRendicion numeric(18,0)
AS
	BEGIN
		SELECT SUM(p.Total_Pago) FROM QEPD.Renglon_Rendicion rp
			JOIN QEPD.Pago p
				ON rp.Nro_Pago = p.Nro_Pago
			where rp.IdRendicion = @idRendicion
		END
GO
*/
/* TO DO

CREATE PROCEDURE RendirEmpresa 


GO*/