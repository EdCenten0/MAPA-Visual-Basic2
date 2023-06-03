USE [MAPA]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[cedula] [nvarchar](20) NOT NULL,
	[email] [nvarchar](30) NULL,
	[telefono] [nvarchar](12) NOT NULL,
	[id_tienda] [int] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materiales]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materiales](
	[id_material] [int] IDENTITY(1,1) NOT NULL,
	[nombre_material] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](300) NOT NULL,
	[cantidad] [int] NOT NULL,
	[unidad_de_medida] [nvarchar](5) NOT NULL,
	[precio_por_unidad] [float] NOT NULL,
	[precio_total] [float] NOT NULL,
	[id_pedido] [int] NULL,
 CONSTRAINT [PK_materiales] PRIMARY KEY CLUSTERED 
(
	[id_material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedidos]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedidos](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](300) NOT NULL,
	[fecha_pedido] [date] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_estado] [int] NULL,
 CONSTRAINT [PK_pedidos] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vista_pedidos]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[vista_pedidos] AS
SELECT c.nombre AS nombre_cliente, m.descripcion, m.cantidad, m.unidad_de_medida, (m.cantidad * m.precio_total) AS precio_total, p.descripcion AS descripcion_pedido
FROM clientes c
JOIN pedidos p ON c.id_cliente = p.id_cliente
JOIN materiales m ON p.id_pedido = m.id_pedido;
GO
/****** Object:  Table [dbo].[estados]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[facturas]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[precio_total] [float] NOT NULL,
	[precio_materiales] [float] NOT NULL,
	[mano_de_obra] [float] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_pedido] [int] NOT NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materiales_por_proveedor]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materiales_por_proveedor](
	[id_materiales_por_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [int] NULL,
	[id_materiales] [int] NULL,
 CONSTRAINT [PK_materiales_por_proveedor] PRIMARY KEY CLUSTERED 
(
	[id_materiales_por_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
	[telefono] [nvarchar](12) NOT NULL,
	[catalogo] [nvarchar](100) NOT NULL,
	[ruc] [nvarchar](15) NULL,
	[direccion] [nvarchar](300) NOT NULL,
	[id_tienda] [int] NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[nombre_rol] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[taller]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taller](
	[id_taller] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](200) NOT NULL,
	[telefono] [nvarchar](12) NOT NULL,
	[email] [nvarchar](50) NULL,
	[id_tienda] [int] NOT NULL,
 CONSTRAINT [PK_taller] PRIMARY KEY CLUSTERED 
(
	[id_taller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tienda]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tienda](
	[id_tienda] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[direccion] [nvarchar](200) NOT NULL,
	[telefono] [nvarchar](12) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tienda] PRIMARY KEY CLUSTERED 
(
	[id_tienda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[clave] [nvarchar](50) NOT NULL,
	[correo_electronico] [nvarchar](50) NOT NULL,
	[id_rol] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ventas]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ventas](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [float] NOT NULL,
	[descripcion] [nvarchar](200) NOT NULL,
	[id_tienda] [int] NULL,
	[id_factura] [int] NULL,
 CONSTRAINT [PK_ventass] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[clientes]  WITH CHECK ADD  CONSTRAINT [FK_clientes_tienda] FOREIGN KEY([id_tienda])
REFERENCES [dbo].[tienda] ([id_tienda])
GO
ALTER TABLE [dbo].[clientes] CHECK CONSTRAINT [FK_clientes_tienda]
GO
ALTER TABLE [dbo].[facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_pedidos] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedidos] ([id_pedido])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[facturas] CHECK CONSTRAINT [FK_facturas_pedidos]
GO
ALTER TABLE [dbo].[materiales]  WITH CHECK ADD  CONSTRAINT [FK_materiales_pedidos] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedidos] ([id_pedido])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[materiales] CHECK CONSTRAINT [FK_materiales_pedidos]
GO
ALTER TABLE [dbo].[materiales_por_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_materiales_por_proveedor_materiales] FOREIGN KEY([id_materiales])
REFERENCES [dbo].[materiales] ([id_material])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[materiales_por_proveedor] CHECK CONSTRAINT [FK_materiales_por_proveedor_materiales]
GO
ALTER TABLE [dbo].[materiales_por_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_materiales_por_proveedor_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([id_proveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[materiales_por_proveedor] CHECK CONSTRAINT [FK_materiales_por_proveedor_proveedores]
GO
ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes] ([id_cliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_clientes]
GO
ALTER TABLE [dbo].[pedidos]  WITH CHECK ADD  CONSTRAINT [FK_pedidos_estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[estados] ([id_estado])
GO
ALTER TABLE [dbo].[pedidos] CHECK CONSTRAINT [FK_pedidos_estados]
GO
ALTER TABLE [dbo].[proveedores]  WITH CHECK ADD  CONSTRAINT [FK_proveedores_tienda] FOREIGN KEY([id_tienda])
REFERENCES [dbo].[tienda] ([id_tienda])
GO
ALTER TABLE [dbo].[proveedores] CHECK CONSTRAINT [FK_proveedores_tienda]
GO
ALTER TABLE [dbo].[taller]  WITH CHECK ADD  CONSTRAINT [FK_taller_tienda] FOREIGN KEY([id_tienda])
REFERENCES [dbo].[tienda] ([id_tienda])
GO
ALTER TABLE [dbo].[taller] CHECK CONSTRAINT [FK_taller_tienda]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id_rol])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[facturas] ([id_factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_facturas]
GO
ALTER TABLE [dbo].[ventas]  WITH CHECK ADD  CONSTRAINT [FK_ventas_tienda] FOREIGN KEY([id_tienda])
REFERENCES [dbo].[tienda] ([id_tienda])
GO
ALTER TABLE [dbo].[ventas] CHECK CONSTRAINT [FK_ventas_tienda]
GO
/****** Object:  StoredProcedure [dbo].[id_cliente_nombre]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[id_cliente_nombre]
AS
	SET NOCOUNT ON;
SELECT pedidos.id_pedido, pedidos.descripcion, pedidos.fecha_pedido, pedidos.id_cliente, pedidos.estado, clientes.nombre, clientes.apellido
FROM     pedidos INNER JOIN
                  clientes ON pedidos.id_cliente = clientes.id_cliente
GO
/****** Object:  StoredProcedure [dbo].[SP_Material_original123]    Script Date: 31/05/2023 10:54:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[SP_Material_original123]
@descripcion nvarchar(300)

AS

Select * 
From vista_pedidos
where descripcion_pedido LIKE '%'+@descripcion+'%'
GO
