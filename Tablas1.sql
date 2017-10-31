USE GD2C2017
GO


/*  Se eliminan objetos preexistentes, //////////////////////// acá encontre 2 formas de eliminar, tirar un IF exist pero igual ahi vas a comparar si existe el objeto en la tabla, Algunos post en foros en internet plantean que es mas performante el IF EXIST, otros dicen que es similar. El atributo U hace referencia a que es un User Table. P para stored procedures, TR triggers, etc , habria que investigar con cual nos quedamos  */



/*//////////////////////// TO DO - Verificar si los drops estan en el orden correcto*/

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


/*//////////////////////// Se crea schema, lo dejo comentado porque me tira error porque ya lo tengo creado 

GO

CREATE SCHEMA QEPD AUTHORIZATION gd
*/


/* Se crean las tablas */

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
Telefono_Cliente numeric(18,0) NULL, 
IdDomicilio int FOREIGN KEY REFERENCES QEPD.Domicilio(IdDomicilio),
Estado_Cliente BIT DEFAULT 1  /* todos los clientes arrancan como activos ? */
);

create table qepd.Rubro(
IdRubro numeric IDENTITY(1,1) PRIMARY KEY,
Nro_Rubro numeric (18,0) NOT NULL,
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

create table qepd.Factura(
Nro_Factura numeric(18,0) PRIMARY KEY,
FechaAlta_Factura datetime NOT NULL,
Fecha_Venc_Factura datetime NOT NULL,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
IdCliente int FOREIGN KEY REFERENCES QEPD.Cliente(IdCliente),
Total_Factura numeric(18,2) NOT NULL,
/*//////////////////////// Siguiendo la logica que pago tiene un BIT para saber si fue rendido o no, aca no deberiamos tener un BIT
para saber consultamos en la otra tabla ? */

)

create table qepd.Renglon_Factura(
IdRenglon_Factura int IDENTITY(1,1) PRIMARY KEY, /*//////////////////////// corresponde autogenerada no ? */
Item_Monto_Factura numeric(18,2) NOT NULL,
Item_Cant_Factura numeric(18,0) NOT NULL,
Item_descripcion nvarchar(255) NOT NULL,
Nro_Factura numeric(18,0) FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura)
)

create table qepd.Forma_Pago(
IdForma_Pago int IDENTITY(1,1) PRIMARY KEY,
Descripcion_Pago nvarchar(255) NOT NULL,
)

create table qepd.Pago(
Nro_Pago numeric PRIMARY KEY,
Fecha_Cobro_Pago datetime NULL,
CodigoPostal_Sucursal numeric FOREIGN KEY REFERENCES QEPD.Sucursal(CP_Sucursal),
Total_Pago numeric(18,2) NULL,  /* Lo que paga el cliente, no calculado como la suma de las facturas que contiene*/
Tipo_pago int FOREIGN KEY REFERENCES QEPD.Forma_Pago(IdForma_Pago),
Estado_Pago BIT DEFAULT 0 /* Indica si el pago fue rendido o no? */

)


create table qepd.Renglon_Pago(
IdRenglon_Pago int IDENTITY(1,1) PRIMARY KEY,
Nro_Factura numeric FOREIGN KEY REFERENCES QEPD.Factura(Nro_Factura),
Nro_Pago numeric FOREIGN KEY REFERENCES QEPD.Pago(Nro_Pago),
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa)
)

create table qepd.Rendicion(
IdRendicion numeric(18,0) PRIMARY KEY NOT NULL,
IdEmpresa int FOREIGN KEY REFERENCES QEPD.Empresa(IdEmpresa),
Cantidad_Facturas numeric(18,0) NULL, /*caculable*/
Fecha_Rendicion datetime NOT NULL,
porcentaje_comision numeric(18,0) NOT NULL,
importe_comision numeric(18,2) NULL, /* calcuable a partir de partir del total de facturas y porcentaje*/
Total_Rendicion numeric(18,2) NULL /*caculable*/
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



/*//////////////////////// Los procedure son para las acciones de las vistas según entendí, los invocamos con eso para que hagan lo que corresponda en las AMB por ej, entiendo que los functions que tienen retorno, seria para los valores estadisticos, o para devolver algun listado o tabla en la vista */





/********************** Migración de  tablas **************************/


/* Migracion domicilio, ////////////////////////como lo planteamos tenemos que levantarlo para Cliente y para Empresa*/ 


INSERT INTO QEPD.Domicilio(Direccion,Cod_Postal)
           SELECT DISTINCT m.Cliente_Direccion, m.Cliente_Codigo_Postal
           FROM gd_esquema.Maestra m
           WHERE m.Cliente_Direccion IS NOT NULL
UNION ALL
           SELECT DISTINCT e.Empresa_Direccion, e.Empresa_Direccion
           FROM gd_esquema.Maestra e
           WHERE e.Empresa_Direccion IS NOT NULL

/* Migracion Tabla Cliente */

/*////////////////////////hay que ver como agregarle el numero de telefono porque es un dato que hay que inventar, con un randomize o algo asi, le estoy seteando a estado 1, hay que definir eso*/



INSERT INTO QEPD.Cliente(Dni_Cliente,Nombre_Cliente,Apellido_Cliente,Email_Cliente,Fecha_Nac_Cliente,IdDomicilio)
			SELECT DISTINCT m.[Cliente-Dni], m.[Cliente-Nombre], m.[Cliente-Apellido], m.Cliente_Mail, m.[Cliente-Fecha_Nac], c.IdDomicilio
			FROM gd_esquema.Maestra m, QEPD.Domicilio c
			WHERE m.[Cliente-Dni] IS NOT NULL AND c.Direccion = m.Cliente_Direccion

/* Migracion Rubro //////////////////////// Agregue la columna Nro_Rubro en QEPD.RUBRO para poder matchearlo despues con la empresa */



INSERT INTO QEPD.Rubro(Nro_Rubro,Descripcion_Rubro)
			SELECT DISTINCT Empresa_Rubro, Rubro_Descripcion
			FROM gd_esquema.Maestra
			WHERE Empresa_Rubro IS NOT NULL

/* Migracion Empresa */



INSERT INTO QEPD.Empresa(Nombre_Empresa,Cuit,IdDomicilio,IdRubro)
			SELECT DISTINCT m.Empresa_Nombre, m.Empresa_Cuit, d.IdDomicilio, r.IdRubro
			FROM gd_esquema.Maestra m, QEPD.Domicilio d, QEPD.Rubro r
			WHERE  m.Empresa_Cuit IS NOT NULL AND m.Empresa_Direccion = d.Direccion AND m.Empresa_Rubro = r.Nro_Rubro


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

INSERT INTO QEPD.Pago(Nro_Pago,Fecha_Cobro_Pago, CodigoPostal_Sucursal, Total_Pago, Tipo_pago)
			SELECT DISTINCT m.Pago_nro, m.Pago_Fecha, s.CP_Sucursal, m.Total, fp.IdForma_Pago
			FROM gd_esquema.Maestra m, QEPD.Sucursal s, QEPD.Forma_Pago fp
			WHERE m.Pago_nro IS NOT NULL AND m.Sucursal_Codigo_Postal = s.CP_Sucursal AND m.FormaPagoDescripcion = fp.Descripcion_Pago



/* Migracion Renglon Pago */

INSERT INTO QEPD.Renglon_Pago(Nro_Factura,Nro_Pago,IdEmpresa) 
		SELECT DISTINCT f.Nro_Factura, p.Nro_Pago, e.IdEmpresa
		FROM QEPD.Factura f, QEPD.Pago p, QEPD.Empresa e
		WHERE p.Nro_Pago IS NOT NULL 
/* ////////////////////////aca creo que tire cualquiera porque no estaria matcheando condiciones bien en la cabeza */

/* Migracion Rendicion */ /* ////////////////////////TO DO 

INSERT INTO QEPD.Rendicion(IdRendicion, IdEmpresa, Fecha_Rendicion, 

*/

/* Migracion Rol */

INSERT INTO QEPD.Rol(Nombre_Rol) VALUES ('Administrador')

INSERT INTO QEPD.Rol(Nombre_Rol) VALUES ('Cobrador')



/* Carga Funcionalidades */

INSERT INTO QEPD.Funcionalidad(Nombre_Funcionalidad) VALUES ('Rendir Facturas')

INSERT INTO QEPD.Funcionalidad(Nombre_Funcionalidad) VALUES ('Cobrar Factura')

/* //////////////////////////////// HAY QUE DEFINIR LAS FUNCIONALIDADES QUE NECESITAMOS PARA EL MODELO */

/* Carga Rol x Funcionalidad   ////////// tenemos que definir cuales vienen asignadas*/

/* TODO  -- Carga Usuario // Carga Rol // Carga RolxUsuario*/

/*Login - boton Aceptar*/

create procedure QEPD.getUsuarioPass
@usuario nvarchar(255),
@pass nvarchar(255)
as
select s.Nombre_Usuario, s.Pass_Usuario from qepd.Usuario s where s.Nombre_Usuario = @usuario and s.Pass_Usuario = @pass


create procedure QEPD.getRoles
@usuario nvarchar(255)
as
begin
	select * 
	from qepd.Usuario s 
		join QEPD.RolPorUsuario rs
			on rs.IdUsuario = s.IdUsuario
		join QEPD.Rol r
			on rs.IdRol = r.IdRol

	where s.Nombre_Usuario = @usuario
end

/*Seleccion de rol - boton Aceptar*/

create procedure QEPD.getFuncionalidades
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

