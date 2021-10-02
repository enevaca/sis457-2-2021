-- Eliminación de Tablas
--DROP PROC paUsuarioListar;
--DROP TABLE CompraDetalle;
--DROP TABLE Compra;
--DROP TABLE Usuario;
--DROP TABLE Producto;
--DROP TABLE Proveedor;
--DROP TABLE Empleado;

-- Creación de Tablas
CREATE TABLE Empleado (
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	cedulaIdentidad VARCHAR(20) NOT NULL UNIQUE,
	nombres VARCHAR(50) NOT NULL,
	paterno VARCHAR(50) NULL,
	materno VARCHAR(50) NULL,
	fechaNacimiento DATE NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	celular BIGINT NOT NULL,
	cargo VARCHAR(100) NOT NULL
);
CREATE TABLE Proveedor(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nit BIGINT NOT NULL UNIQUE,
	razonSocial VARCHAR(250) NOT NULL,
	direccion VARCHAR(250) NULL,
	telefono VARCHAR(20) NULL,
	representante VARCHAR(100) NULL
);
CREATE TABLE Producto(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	codigo VARCHAR(12) NOT NULL UNIQUE,
	descripcion VARCHAR(200) NOT NULL,
	unidadMedida VARCHAR(20) NOT NULL,
	saldo DECIMAL NOT NULL DEFAULT 0,
	precioVenta DECIMAL NOT NULL DEFAULT 0
);
CREATE TABLE Usuario (
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	usuario VARCHAR(15) NOT NULL UNIQUE,
	clave VARCHAR(200) NOT NULL,
	idEmpleado INT NOT NULL,
	usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME(),
	fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
	registroActivo BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
CREATE TABLE Compra (
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	transaccion INT NOT NULL,
	fecha DATE NOT NULL DEFAULT GETDATE(),
	idProveedor INT NOT NULL,
	usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME(),
	fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
	registroActivo BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_Compra_Proveedor FOREIGN KEY(idProveedor) REFERENCES Proveedor(id)
);
CREATE TABLE CompraDetalle (
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	cantidad DECIMAL NOT NULL CHECK(cantidad > 0),
	precioUnitario DECIMAL NOT NULL DEFAULT 0,
	total DECIMAL NOT NULL,
	idCompra INT NOT NULL,
	idProducto INT NOT NULL,
	usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME(),
	fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
	registroActivo BIT NOT NULL DEFAULT 1,
	CONSTRAINT FK_CompraDetalle_Compra FOREIGN KEY(idCompra) REFERENCES Compra(id),
	CONSTRAINT FK_CompraDetalle_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)
);

ALTER TABLE Empleado ADD usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME();
ALTER TABLE Empleado ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Empleado ADD registroActivo BIT NOT NULL DEFAULT 1;

ALTER TABLE Proveedor ADD usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME();
ALTER TABLE Proveedor ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Proveedor ADD registroActivo BIT NOT NULL DEFAULT 1;

ALTER TABLE Producto ADD usuarioRegistro VARCHAR(15) NOT NULL DEFAULT SUSER_SNAME();
ALTER TABLE Producto ADD fechaRegistro DATETIME NOT NULL DEFAULT GETDATE();
ALTER TABLE Producto ADD registroActivo BIT NOT NULL DEFAULT 1;

INSERT INTO Empleado(cedulaIdentidad, nombres, paterno, materno,
					 fechaNacimiento, direccion, celular, cargo)
VALUES('12346','Noel','Vaca','Moreno','25/12/2000',
	'Calle Junin # 777', 76862782, 'Administrador')

UPDATE Empleado SET direccion='Calle Junin # 777, Zona Central' WHERE id=1 

SELECT * FROM Empleado

INSERT INTO Usuario(usuario, clave, idEmpleado)
VALUES('nvaca', '123456', 1)
SELECT * FROM Usuario;

GO
CREATE PROC paUsuarioListar @parametro VARCHAR(100)
AS
	SELECT e.id AS idEmpleado, u.id as idUsuario, e.cedulaIdentidad, e.nombres, 
			e.paterno, e.materno, e.fechaNacimiento,
			e.direccion, e.celular, e.cargo, u.usuario
	FROM Empleado e
	INNER JOIN Usuario u ON e.id=u.idEmpleado
	WHERE u.registroActivo=1 AND
			e.cedulaIdentidad+e.nombres+e.paterno+e.materno+u.usuario LIKE '%'+@parametro+'%'

--EXECUTE paUsuarioListar @parametro='noel'
EXEC paUsuarioListar 'noel'

