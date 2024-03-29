CREATE DATABASE FARMACHINCHA
GO

USE FARMACHINCHA
GO

-- USUARIO = Luy06
-- CONTRASE�A = 12345

CREATE TABLE personas
(
	idpersona		INT IDENTITY(1,1) PRIMARY KEY,
	nombres			VARCHAR(40)		NOT NULL,
	apellidos		VARCHAR(40)		NOT NULL,
	direccion		VARCHAR(80)		NULL,
	dni				CHAR(8)			NOT NULL,
	telefono		CHAR(9)			NULL,
	correo			VARCHAR(60)		NULL,
	CONSTRAINT ck_dni_per CHECK (dni LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT ck_tel_per CHECK (telefono LIKE('[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT uk_dni_per UNIQUE (dni),
	CONSTRAINT uk_tel_per UNIQUE (telefono)
)
GO

--ELIMINANDO LA RESTRICCION uk_tel_per

ALTER TABLE personas DROP CONSTRAINT uk_tel_per;  
GO  

INSERT INTO personas (nombres, apellidos, dni, telefono) VALUES
		('Luis David','Cusi Gonzales','73196921','934651825'),
		('Jes�s','Camacho Carrasco','74254765','935446756'),
		('Rodrigo Fabrizio','Barrios Saavedra','72234657','965722315'),
		('Alejandro Jes�s','Gallardo Ya�ez','76534565','956766435'),
		('Alex Ed�','Quiroz Ccaulla','75673655','933098675'),
		('Alexander', 'Lopez', '74364764','965418265'),
		('Roberto', 'Guillen', '74366764','986512340'),
		('Eduardo', 'Garcia', '74368764','986523142'),
		('Aldair', 'Carbajal', '77365764','965214523')
		
GO





CREATE TABLE usuarios
(
	idusuario		INT IDENTITY(1,1) PRIMARY KEY,
	idpersona		INT				NOT NULL,
	nomusuarios		VARCHAR(30)		NOT NULL,
	claveacceso		VARCHAR(100)	NOT NULL,
	estado			BIT				NOT NULL DEFAULT 1,
	CONSTRAINT fk_idper_usu FOREIGN KEY (idpersona) REFERENCES personas (idpersona),
	CONSTRAINT	uk_nom_usu UNIQUE(nomusuarios)
)
GO




INSERT INTO usuarios ( idpersona ,nomusuarios, claveacceso) VALUES
	(1,'Luy06','12345'),
	(2,'komancho11','12345'),
	(3,'elfabri02','12345'),
	(4,'zocer_mono','12345'),
	(5,'eduin11','12345'),
	( 6,'Alexander','12345'),
	( 7,'Roberto','12345'),
	( 8,'Eduardo','12345'),
	(9,'Aldair','12345')
GO



SELECT * FROM usuarios

update usuarios set claveacceso = '$2a$06$tVBMuKRoxunGnj6zZCIWtucDJgRNl9lpNJRL1gfByvS69K9rYJKjK' 
go






CREATE TABLE laboratorios
(
	idlaboratorio		INT IDENTITY(1,1) PRIMARY KEY,
	nombre				VARCHAR(40)		NOT NULL,
	direccion			VARCHAR(80)		NULL,
	telefono			CHAR(9)			NOT NULL,
	CONSTRAINT ck_tel_lab CHECK (telefono LIKE('[9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT uk_nom_lab UNIQUE (nombre),
	CONSTRAINT uk_tel_lab UNIQUE (telefono)
)
GO

INSERT INTO laboratorios (nombre,telefono) VALUES
	('PFIZER','965865736'),
	('NOVARTIS','954765832'),
	('JANSSEN','970597542'),
	('ASTRAZENECA', '978456112')
GO

CREATE TABLE categorias
(
	idcategoria			INT IDENTITY(1,1) PRIMARY KEY,
	nombrecategoria		VARCHAR(60)		NOT NULL,
	numestanteria		TINYINT			NOT NULL,
	CONSTRAINT uk_nom_cat UNIQUE(nombrecategoria)
)
GO


INSERT INTO categorias( nombrecategoria, numestanteria) VALUES
	('Medicamentos Orales', 1),
	('Medicamentos Inyectables',2 ),
	('Soluciones de perfusi�n',3 ),
	('Vacunas, inmunoglobulinas y sueros', 4 ),
	('Medicamentos de uso externo y antis�pticos', 5),
	('Desinfectantes', 6)
GO



CREATE TABLE compraproductos
(
	idcompraproducto	INT IDENTITY(1,1) PRIMARY KEY,
	idusuario			INT		NOT NULL,
	idlaboratorio		INT		NOT NULL,
	fechacompra			DATETIME	NOT NULL DEFAULT GETDATE(),
	CONSTRAINT fk_idusu_com FOREIGN KEY (idusuario) REFERENCES usuarios (idusuario),
	CONSTRAINT fk_idlab_com FOREIGN KEY (idlaboratorio) REFERENCES laboratorios (idlaboratorio)
)
GO



INSERT INTO compraproductos (idusuario,idlaboratorio) VALUES
	(1, 3 ),
	(1, 1 ),
	(4, 2 ),
	(4, 4 )
GO



CREATE TABLE productos
(
	idproducto			INT IDENTITY(1,1) PRIMARY KEY,
	idlaboratorio		INT				NOT NULL,
	idcategoria			INT				NOT NULL,
	nombreproducto		VARCHAR(50)		NOT NULL,
	descripcion			VARCHAR(100)	NOT NULL,
	cantidad			SMALLINT		NOT NULL,
	precio				DECIMAL(7,2)	NOT NULL,
	fechaproduccion		DATETIME		NOT NULL,
	fechavencimiento	DATETIME		NOT NULL,
	numlote				VARCHAR(15)		NOT NULL,
	recetamedica		CHAR(1)			NOT NULL, -- OBLIGATORIO = O / NO NECESARIO = N
	estado				BIT				NOT NULL DEFAULT 1, 
	CONSTRAINT fk_idlab_pro FOREIGN KEY (idlaboratorio) REFERENCES laboratorios (idlaboratorio),
	CONSTRAINT fk_idcat_pro FOREIGN KEY (idcategoria) REFERENCES categorias (idcategoria),
	CONSTRAINT ck_pre_pro CHECK (precio > 0),
	CONSTRAINT ck_rec_pro CHECK(recetamedica IN ('O','N')),
	CONSTRAINT ck_can_pro CHECK (cantidad >= 0)
)
GO

ALTER TABLE productos ADD barcode VARCHAR(20) NOT NULL
GO

INSERT INTO productos (idlaboratorio, idcategoria, nombreproducto, descripcion, cantidad,
						precio, fechaproduccion, fechavencimiento, numlote, recetamedica,barcode) VALUES
	(3, 1 , 'Paracetamol 500mg','Dolor leve o moderado y fiebre ', 50 , 10.00 , '02/11/2022','02/11/2025', 'G-1','N',10000000001),
	(1, 1, 'Paracetamol 120mg/5ml','Dolor leve o moderado y fiebre',30 , 1.70 , '02/11/2022','02/11/2025', 'G-1','N',20000000002),
	(2, 1, 'Amoxicilina�500�mg�Tableta�-�Caja�100�UN','Infecciones',20 , 10.00 , '02/11/2022','02/11/2025', 'G-1','N',30000000003),
	(2, 6, 'Alcohol Puro 1000ml','Desinfectar',40, 8.20  , '02/11/2022','02/11/2025', 'G-1','N',40000000004),
	(4, 6, 'Agua Oxigenada Alkofarma 1000ml','Desinfectar', 30  , 4.90  , '02/11/2022','02/11/2025', 'G-1','N',50000000005),
	(4, 6 ,'Lidocaina Lusa 5% Ung�ento', 'bloquear el dolor al reducir la conducci�n de impulsos nerviosos', 20, 18.00,'03/01/2022','02/12/2025',' G-2',  'O',60000000006),
	(4, 6 ,'Vick Vaporub Ung�ento t�pico', 'Ayuda a descongestionar las v�as respiratorias, Calma la tos', 50, 2.25,'03/01/2022','02/12/2025',' G-2',  'N',70000000007),
	(1, 1 , 'Panadol Forte Tableta', 'Alivia los dolores fuertes', 40, 1.69, '03/01/2022', '02/12/2025', 'G-2', 'N',80000000008)
GO





CREATE TABLE detalle_compras
(
	iddetallecompra		INT IDENTITY(1,1) PRIMARY KEY,
	idcompraproducto	INT				NOT NULL,
	idproducto			INT				NOT NULL,
	cantidad			SMALLINT		NOT NULL, 
	preciocompra		DECIMAL(7,2)	NOT NULL, 
	CONSTRAINT fk_idcom_detc FOREIGN KEY (idcompraproducto) REFERENCES compraproductos (idcompraproducto),
	CONSTRAINT fk_idpro_detc FOREIGN KEY (idproducto) REFERENCES productos (idproducto),
	CONSTRAINT ck_can_detc CHECK (cantidad > 0)
)
GO
-- AGREGANDO UN CAMPO FECHADETALLE A LA TABLA DETALLE_COMPRAS

ALTER TABLE detalle_compras ADD fechadetalle DATETIME NOT NULL DEFAULT GETDATE()
GO



INSERT INTO detalle_compras (idcompraproducto, idproducto, cantidad, preciocompra) VALUES
	(1, 1, 2, 10.00),
	(2, 7, 10, 2.25 ),
	(3, 6, 20, 18.00),
	(4, 3, 10, 10.00)

GO

SELECT * FROM detalle_compras
GO


-- SUMA LA CANTIDAD DE INVENTARIO CON LA COMPRA
-- Y DEVUELTE LAS COMPRAS DE LA FECHA ACTUAL
SELECT	PRO.idproducto,PRO.nombreproducto, 
		SUM(PRO.cantidad) +  SUM (DC.cantidad) AS totalInventario,
		DAY(DC.fechadetalle) AS Fecha_compraActual	
FROM productos PRO
INNER JOIN detalle_compras DC ON DC.idproducto = PRO.idproducto
WHERE DAY(DC.fechadetalle) = DAY(GETDATE())
GROUP BY PRO.idproducto, PRO.nombreproducto, DC.fechadetalle ,PRO.cantidad, DC.cantidad
GO





-- CREANDO LA ENTIDAD EMPRESAS
CREATE TABLE empresas
(
	idempresa		INT IDENTITY(1,1) PRIMARY KEY,
	nombre			VARCHAR(50)		NOT NULL,
	ruc				CHAR(11)		NOT NULL,
	CONSTRAINT	ck_ruc_emp CHECK (ruc LIKE('[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	CONSTRAINT	uk_ruc_emp UNIQUE(ruc)
)
GO

INSERT INTO empresas(nombre, ruc) VALUES
	('Sanofi', 10793420394),
	('Bayer', 20693023598),
	('Lilly', 17702394689),
	('Dormunt',20604932946)
GO


CREATE TABLE ventas
(
	idventa				INT IDENTITY(1,1) PRIMARY KEY,
	idcliente			INT			NULL,
	idusuario			INT			NOT NULL,
	idempresa			INT			NULL,
	fechaventa			DATETIME	NOT NULL DEFAULT GETDATE(),
	tipocomprobante		VARCHAR(20)	NOT NULL,
	CONSTRAINT fk_idcli_ven FOREIGN KEY (idcliente) REFERENCES personas (idpersona),
	CONSTRAINT fk_idusu_ven FOREIGN KEY (idusuario) REFERENCES usuarios (idusuario),
	CONSTRAINT fk_idem_ven FOREIGN KEY (idempresa) REFERENCES empresas (idempresa)
)
GO

-- Modificamos al campo idusuario
ALTER TABLE ventas ALTER COLUMN idusuario INT NULL
GO

INSERT INTO ventas (idcliente, idusuario, tipocomprobante) VALUES
	(6, 1, 'BOLETA')
GO


SELECT * FROM productos
GO

CREATE TABLE detalle_ventas
(
	iddetalleventa		INT IDENTITY(1,1) PRIMARY KEY,
	idventa				INT				NOT NULL,
	idproducto			INT				NOT NULL,
	cantidad			SMALLINT		NOT NULL,
	unidad				VARCHAR(30)		NOT NULL,
	precioventa			DECIMAL(7,2)	NOT NULL,
	CONSTRAINT fk_idpro_detv FOREIGN KEY (idproducto) REFERENCES productos (idproducto),
	CONSTRAINT fk_idven_detv FOREIGN KEY (idventa) REFERENCES ventas (idventa),
	CONSTRAINT ck_pre_detv CHECK (precioventa > 0),
	CONSTRAINT ck_can_detv CHECK (cantidad > 0)
)
GO

INSERT INTO detalle_ventas(idventa, idproducto, cantidad, unidad, precioventa) VALUES
	(1, 1, 2 , 'BLISTER', 10.00 ),
	(1, 2, 1, 'BLISTER', 1.70)
GO

select * from ventas 
go

select * from detalle_ventas
go



CREATE TABLE pagos
(
	idpago			INT IDENTITY(1,1) PRIMARY KEY,
	idventa			INT				NOT NULL,
	tipopago		VARCHAR(20)		NOT NULL, 
	fechapago		DATETIME		NOT NULL DEFAULT GETDATE(),
	CONSTRAINT fk_idven_pag FOREIGN KEY (idventa) REFERENCES ventas(idventa)
)
GO

INSERT INTO pagos (idventa, tipopago) VALUES
	(1,'EFECTIVO')
GO
















