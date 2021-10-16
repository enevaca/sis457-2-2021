USE [Minerva]
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transaccion] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idProveedor] [int] NOT NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [decimal](18, 0) NOT NULL,
	[precioUnitario] [decimal](18, 0) NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[idCompra] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cedulaIdentidad] [varchar](20) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[paterno] [varchar](50) NULL,
	[materno] [varchar](50) NULL,
	[fechaNacimiento] [date] NOT NULL,
	[direccion] [varchar](250) NOT NULL,
	[celular] [bigint] NOT NULL,
	[cargo] [varchar](100) NOT NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](12) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[unidadMedida] [varchar](20) NOT NULL,
	[saldo] [decimal](18, 0) NOT NULL,
	[precioVenta] [decimal](18, 0) NOT NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nit] [bigint] NOT NULL,
	[razonSocial] [varchar](250) NOT NULL,
	[direccion] [varchar](250) NULL,
	[telefono] [varchar](20) NULL,
	[representante] [varchar](100) NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](15) NOT NULL,
	[clave] [varchar](200) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[usuarioRegistro] [varchar](15) NOT NULL,
	[fechaRegistro] [datetime] NOT NULL,
	[registroActivo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 
GO
INSERT [dbo].[Empleado] ([id], [cedulaIdentidad], [nombres], [paterno], [materno], [fechaNacimiento], [direccion], [celular], [cargo], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (1, N'12346', N'Noel', N'Vaca', N'Moreno', CAST(N'2000-12-25' AS Date), N'Calle Junin # 777, Zona Central', 76862782, N'Administrador', N'usrminerva', CAST(N'2021-10-02T10:43:07.507' AS DateTime), 1)
GO
INSERT [dbo].[Empleado] ([id], [cedulaIdentidad], [nombres], [paterno], [materno], [fechaNacimiento], [direccion], [celular], [cargo], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (2, N'25467', N'Daniel', N'Sanchez', N'Nagata', CAST(N'1999-01-01' AS Date), N'Calle Loa N° 5', 77445568, N'Cajero', N'usrminerva', CAST(N'2021-10-14T19:00:29.237' AS DateTime), 1)
GO
INSERT [dbo].[Empleado] ([id], [cedulaIdentidad], [nombres], [paterno], [materno], [fechaNacimiento], [direccion], [celular], [cargo], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (3, N'4848400', N'Yulisa', N'Almendras', N'Arancibia', CAST(N'1998-07-20' AS Date), N'Calle Calvo N° 150', 48487070, N'Cajero', N'nvaca', CAST(N'2021-10-16T10:22:20.373' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (1, N'LB05-2020', N'El Principito', N'Pieza', CAST(20 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), N'usrminerva', CAST(N'2021-10-09T09:52:47.793' AS DateTime), 1)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (2, N'LB03254', N'Hojas bond tamaño carta', N'Paquete', CAST(50 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), N'nvaca', CAST(N'2021-10-09T10:20:43.753' AS DateTime), 1)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (3, N'HD5454', N'Bolígrafo', N'Caja', CAST(10 AS Decimal(18, 0)), CAST(5 AS Decimal(18, 0)), N'nvaca', CAST(N'2021-10-09T10:25:49.493' AS DateTime), 1)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (4, N'asfasdf', N'sfasdfsfasdfasfd', N'Caja', CAST(10 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), N'nvaca', CAST(N'2021-10-09T10:45:54.433' AS DateTime), 0)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (5, N'HG20', N'descrip', N'Caja', CAST(600 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), N'nvaca', CAST(N'2021-10-09T10:56:15.080' AS DateTime), 0)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (6, N'DFD252', N'Clips', N'Caja', CAST(500 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), N'nvaca', CAST(N'2021-10-14T18:58:25.750' AS DateTime), 1)
GO
INSERT [dbo].[Producto] ([id], [codigo], [descripcion], [unidadMedida], [saldo], [precioVenta], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (7, N'DFSDF52', N'Perforadora', N'Docena', CAST(10 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), N'dsanchez', CAST(N'2021-10-14T19:06:12.253' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([id], [usuario], [clave], [idEmpleado], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (1, N'nvaca', N'XqUPUtrfOqPb8qUrRsI2yA==', 1, N'usrminerva', CAST(N'2021-10-02T10:43:07.510' AS DateTime), 1)
GO
INSERT [dbo].[Usuario] ([id], [usuario], [clave], [idEmpleado], [usuarioRegistro], [fechaRegistro], [registroActivo]) VALUES (2, N'dsanchez', N'XqUPUtrfOqPb8qUrRsI2yA==', 2, N'usrminerva', CAST(N'2021-10-14T19:01:15.010' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Empleado__9FE1EA2437899C39]    Script Date: 16/10/2021 11:27:54 ******/
ALTER TABLE [dbo].[Empleado] ADD UNIQUE NONCLUSTERED 
(
	[cedulaIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Producto__40F9A206B0A819A5]    Script Date: 16/10/2021 11:27:54 ******/
ALTER TABLE [dbo].[Producto] ADD UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Proveedo__DF97D0E4D514FE56]    Script Date: 16/10/2021 11:27:54 ******/
ALTER TABLE [dbo].[Proveedor] ADD UNIQUE NONCLUSTERED 
(
	[nit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Usuario__9AFF8FC67724EB4F]    Script Date: 16/10/2021 11:27:54 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT (getdate()) FOR [fecha]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Compra] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[CompraDetalle] ADD  DEFAULT ((0)) FOR [precioUnitario]
GO
ALTER TABLE [dbo].[CompraDetalle] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[CompraDetalle] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[CompraDetalle] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [saldo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [precioVenta]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (suser_sname()) FOR [usuarioRegistro]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (getdate()) FOR [fechaRegistro]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((1)) FOR [registroActivo]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedor] ([id])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Compra] FOREIGN KEY([idCompra])
REFERENCES [dbo].[Compra] ([id])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Compra]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Producto]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empleado] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleado] ([id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empleado]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD CHECK  (([cantidad]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[paEmpleadoListar]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[paEmpleadoListar] @parametro VARCHAR(50)
AS
  SELECT * FROM Empleado
  WHERE registroActivo=1
        AND cedulaIdentidad+nombres+paterno+materno LIKE '%'+@parametro+'%'
GO
/****** Object:  StoredProcedure [dbo].[paProductoListar]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[paProductoListar] @parametro VARCHAR(30)
AS 
	SELECT id, codigo, descripcion, unidadMedida, saldo,
		   precioVenta, usuarioRegistro, fechaRegistro 
	FROM Producto 
	Where registroActivo=1 AND codigo+descripcion LIKE '%'+@parametro+'%'
GO
/****** Object:  StoredProcedure [dbo].[paUsuarioListar]    Script Date: 16/10/2021 11:27:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[paUsuarioListar] @parametro VARCHAR(100)
AS
	SELECT e.id AS idEmpleado, u.id as idUsuario, e.cedulaIdentidad, e.nombres, 
			e.paterno, e.materno, e.fechaNacimiento,
			e.direccion, e.celular, e.cargo, u.usuario
	FROM Empleado e
	INNER JOIN Usuario u ON e.id=u.idEmpleado
	WHERE u.registroActivo=1 AND
			e.cedulaIdentidad+e.nombres+e.paterno+e.materno+u.usuario LIKE '%'+@parametro+'%'

--EXECUTE paUsuarioListar @parametro='noel'
--EXEC paUsuarioListar 'noel'

