INSERT INTO tienda(nombre, direccion, telefono, email) VALUES ('MAPA', 'Plaza Riviera de Tola, Tola', '+50589483920', 'contact@mapa.com');
GO

INSERT INTO roles(nombre_rol) VALUES('Admin');
GO


INSERT INTO taller(nombre, direccion, telefono, email, id_tienda) VALUES('Taller central', 'Plaza Riviera de Tola, Tola', '+50588773233', 'const@mapa.com',1);
GO


INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Mark', 'Onell', 'R003-3923-1290', 'marko19@outlook.com', '+50587576478',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Carlos', 'Centeno', '234-3234-1000J', 'carlos.chavarria@est.ni', '+50557628049',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Denisse', 'Isabel', '223-9022-2323M', 'denisseaguilar@gmail.com', '+50543323445',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Francisco', 'Meléndez', '345-2344-1034D', 'melendez2@gmail.com', '+50556748932',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Zoro', 'Mugiwara', '245-9089-1084L', 'zoromugiwara@oda.com', '+50523423323',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Elon', 'Musk', 'R009-4345-1002', 'eloncoin@outlook.com', '+50534323443',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Daniel', 'Rosewood', '232-2321-1000L', 'rosewood34@hotmail.com', '+50587574838',1);
INSERT INTO clientes(nombre, apellido, cedula, email, telefono, id_tienda) VALUES('Danilo', 'Lacayo', '343-2123-1231D', 'daniellacayo12@gmail.com', '+50589382932',1);
GO

INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Mueble de madera maciza para sala de estar', '2023-05-08',1,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Silla de comedor con respaldo alto', '2023-05-07',2,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Mesa de centro de cristal templado', '2023-05-06',3,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Armario de madera con puertas corredizas', '2023-05-05',4,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Sofá modular de piel sintética', '2023-05-04',5,2);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Mueble de televisión de madera blanca', '2023-05-03',6,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Mesa de comedor extensible de vidrio', '2023-05-02',7,3);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Sofá cama con chaise longue', '2023-05-01', 8,2);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Armario de baño con espejo y luces LED', '2023-04-30', 1,1);
INSERT INTO pedidos (descripcion, fecha_pedido, id_cliente,id_estado) VALUES ('Silla ergonómica para oficina', '2023-04-29', 2,1);
GO

INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Madera maciza', 'Tabla de madera de roble de alta calidad', 10, 'lbs', 50.00, 500.00,1);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tela de tapicería', 'Tela de algodón de alta calidad, resistente a las manchas', 25, 'mts', 12.50, 312.50,2);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Herrajes de metal', 'Juego de bisagras, manijas y tornillos para muebles', 5, 'simpl', 25.00, 125.00,1);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Espuma de alta densidad', 'Relleno para asientos de muebles', 3, 'pulg', 40.00, 120.00,3);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Pintura en aerosol', 'Pintura en aerosol de alta calidad para muebles de madera', 20, 'ltrs', 8.00, 160.00,5);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Madera contrachapada', 'Panel de madera de pino de calidad industrial', 15, 'simpl', 20.00, 300.00,5);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tornillos para madera', 'Paquete de 100 tornillos para madera de 2 pulgadas', 2, 'simpl', 10.00, 20.00,7);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Cuero sintético', 'Tela de cuero sintético de alta calidad para tapicería', 20, 'mts', 15.00, 300.00,6);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Pintura acrílica', 'Pintura acrílica de calidad artística para detalles de muebles', 5, 'ltrs', 25.00, 125.00,5);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Hojas de sierra para madera', 'Paquete de 5 hojas de sierra para madera de 10 pulgadas', 3, 'simpl', 8.00, 24.00,4);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Laca para madera', 'Laca transparente para proteger la madera de muebles', 10, 'ltrs', 18.00, 180.00,3);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tela para cojines', 'Tela de algodón suave para cojines de muebles', 30, 'mts', 9.50, 285.00,2);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Pies de goma', 'Juego de 4 pies de goma para proteger pisos y muebles', 5, 'simpl', 6.00, 30.00,5);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Clavos para madera', 'Paquete de 50 clavos para madera de 1 pulgada', 5, 'simpl', 3.50, 17.50,1);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Relleno de espuma', 'Relleno de espuma suave para cojines de muebles', 8, 'pulg', 25.00, 200.00,2);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tornillos para madera', 'Juego de 100 tornillos para madera de alta calidad', 1, 'simpl', 10.00, 10.00,4);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Cuero para tapicería', 'Cuero sintético de alta calidad, fácil de limpiar', 15, 'mts', 20.00, 300.00,1);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Almohadillas de fieltro', 'Set de 4 almohadillas de fieltro para proteger los muebles del piso', 20, 'simpl', 5.00, 100.00,3);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Lijas para madera', 'Set de 10 lijas para madera de grano fino y grueso', 3, 'simpl', 15.00, 45.00,2);	
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tela de lino', 'Tela de lino de alta calidad, suave al tacto', 18, 'mts', 18.00, 324.00,1);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Molduras de madera', 'Juego de 4 molduras de madera tallada a mano', 1, 'simpl', 50.00, 50.00,7);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Adhesivo de contacto', 'Adhesivo de contacto de alta calidad para unir madera y cuero', 2, 'ltrs', 30.00, 60.00,3);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Tela de terciopelo', 'Tela de terciopelo de alta calidad, ideal para tapicería de muebles', 10, 'mts', 25.00, 250.00,2);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Barniz para madera', 'Barniz para madera de alta calidad, resistente a los rayos UV', 4, 'ltrs', 40.00, 160.00,6);
INSERT INTO materiales (nombre_material, descripcion, cantidad, unidad_de_medida, precio_por_unidad, precio_total, id_pedido) 
VALUES ('Pegamento para madera', 'Pegamento para madera de alta resistencia, ideal para construir muebles', 3, 'ltrs', 25.00, 75.00,9);
GO


INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Muebles y Decoración S.A.', 'mueblesdeco@mail.com', '555-1234', 'Catálogo de muebles modernos', '12345678901', 'Av. Paseo de la Reforma 123, Ciudad de México', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Maderas del Sur S.A.', 'maderasur@mail.com', '555-5678', 'Catálogo de madera dura y suave', '23456789012', 'Calle San Martín 456, Santiago de Chile', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Tapicería y Telas S.A.', 'tapiceriatelas@mail.com', '555-9012', 'Catálogo de telas para tapicería', '34567890123', 'Carrera 7 # 71-52, Bogotá', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Herrajes y Accesorios S.A.', 'herrajesaccesorios@mail.com', '555-3456', 'Catálogo de herrajes y accesorios para muebles', '45678901234', 'Rua Oscar Freire 379, São Paulo', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Pinturas y Barnices S.A.', 'pinturasbarnices@mail.com', '555-6789', 'Catálogo de pinturas y barnices para madera', '56789012345', 'Calle Pellegrini 2735, Rosario', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Acero y Aluminio S.A.', 'aceroaluminio@mail.com', '555-0123', 'Catálogo de perfiles de acero y aluminio', '67890123456', 'Avenida Dos de Mayo 123, Lima', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Tapicería Fina S.A.', 'tapiceriafina@mail.com', '555-4567', 'Catálogo de telas finas para tapicería', '78901234567', 'Calle 72 # 12-32, Bogotá', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Materiales de Construcción S.A.', 'materialesconstruccion@mail.com', '555-8901', 'Catálogo de materiales de construcción', '89012345678', 'Avenida Libertador 876, Caracas', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Talleres de Carpintería S.A.', 'tallerescarpinteria@mail.com', '555-2345', 'Catálogo de muebles clásicos', '90123456789', 'Avenida Presidente Kennedy 1234, Santiago de Chile', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Fábrica de Muebles Metálicos S.A.', 'mueblesmetalicos@mail.com', '555-6789', 'Catálogo de muebles de metal', '01234567890', 'Rua Augusta 1837, São Paulo', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Diseños en Vidrio S.A.', 'disenosvidrio@mail.com', '555-0123', 'Catálogo de muebles con detalles en vidrio', '12345678901', 'Carrera 7 # 71-52, Bogotá', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Telas y Tapicería de Cuero S.A.', 'tapiceriacuero@mail.com', '555-4567', 'Catálogo de telas y cuero para tapicería', '23456789012', 'Calle 72 # 12-32, Bogotá', 1);
INSERT INTO proveedores (nombre, email, telefono, catalogo, ruc, direccion, id_tienda) 
VALUES ('Fábrica de Puertas y Ventanas S.A.', 'puertasventanas@mail.com', '555-8901', 'Catálogo de puertas y ventanas de madera y metal', '34567890123', 'Avenida Los Leones 293, Santiago de Chile', 1);
GO


INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(1,2);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(5,2);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(5,6);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(12,4);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(23,9);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(24,10);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(15,4);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(16,3);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(20,11);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(13,11);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(13,4);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(17,2);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(16,8);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(22,6);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(14,12);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(12,13);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(18,2);
INSERT INTO materiales_por_proveedor(id_materiales, id_proveedor) VALUES(21,1);
GO

INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (800.00, 600.00, 200.00, '2023-02-07',1);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (300.00, 200.00, 100.00, '2023-03-14',2);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (450.00, 300.00, 150.00, '2023-04-05',3);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (1200.00, 800.00, 400.00, '2023-05-19',4);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (600.00, 500.00, 100.00, '2023-06-21',5);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (950.00, 700.00, 250.00, '2023-07-02',6);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (1750.00, 1200.00, 550.00, '2023-08-09',7);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (500.00, 400.00, 100.00, '2023-09-12',8);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (900.00, 600.00, 300.00, '2023-10-07',9);
INSERT INTO facturas (precio_total, precio_materiales, mano_de_obra, fecha, id_pedido) 
VALUES (700.00, 500.00, 200.00, '2023-11-23',10);
GO

INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (800.00, 'Mueble de madera maciza para sala de estar', 1, 1);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (300.00, 'Silla de comedor con respaldo alto', 1, 2);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (450.00, 'Mesa de centro de cristal templado', 1, 3);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (1200.00, 'Armario de madera con puertas corredizas', 1, 4);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (600.00, 'Sofá modular de piel sintética', 1, 5);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (950.00, 'Mueble de televisión de madera blanca', 1, 6);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (1750.00, 'Mesa de comedor extensible de vidrio', 1, 7);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (500.00, 'Sofá cama con chaise longue', 1, 8);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (900.00, 'Armario de baño con espejo y luces LED', 1, 9);
INSERT INTO ventas (cantidad, descripcion, id_tienda, id_factura) VALUES (700.00, 'Silla ergonómica para oficina', 1, 10);
GO
