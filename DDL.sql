--Script de SQL Server
--comentario de un renglon
/*Comentario
de varios
renglones*/

/*Instrucciones DDL: Data Definition Language
son instrucciones usadas para la manipulacion
de objetos de base de datos (tablas, bases de datos,
llaves, usuarios)
Las mas conocidas son: CREATE, DROP, ALTER, TRUNCATE, USE.*/

--Crear una base de datos
CREATE DATABASE Gerardo
GO
--toda instruccion del DDL se recomienda colocar la instruccion GO despues de cada
--una de ellas, esto se hace para evitar que se ejecute la instruccion siguiente
--hasta que se termine de procesar la instruccion antes del GO.


--eliminar una base de datos
--se recomienda primero reiniciar el SQL SERVER
--luego ejecuta lo siguiente:
USE master --seleccionar la base de datos de sistema
GO
DROP DATABASE Gerardo
GO

--Crear una tabla en la base de datos
--Importante: antes de ello debera seleccionar
--la base de datos donde va a crear la tabla:
USE Gerardo
GO
CREATE TABLE Producto(
	ProductoID bigint NOT NULL IDENTITY(1,1), --columna autonumerica de 1 en 1 (solo una por tabla)
	Codigo varchar(30) NOT NULL,
	Nombre varchar(200) NOT NULL,
	Costo decimal(12,2) NOT NULL, --numero decimal de 12 digitos a 2 decimales
	PrecioVenta decimal(12,2) NOT NULL,
	Existencias int NOT NULL, --int es entero de 4 bytes
	Comentarios text NULL, --texto casi ilimitado (como 2TB por registro), es opcional porque puse NULL
	PRIMARY KEY(ProductoID) --hace unico cada registro, evita numeros duplicados (llave primaria)
)
GO
--NOT NULL = columna que se debe llenar obligatoriamente
--NULL = columna opcional, se puede dejar sin llenar

--borrar una tabla: importante! destruye la tabla y sus datos aunque esten en uso
--seleccione la bd donde esta la tabla:
USE Gerardo
GO
DROP TABLE Producto
GO

--vaciar el contenido de una tabla (borrar sus datos sin destruir su estructura)
Use Gerardo
GO
TRUNCATE TABLE Producto
GO
--lo anterior tambien resetea el campo autonumerico
--a esto se le conoce como Truncar la tabla

--agregar una columna a una tabla existente sin perder sus datos
--por ejemplo: agregar una columna llada Color a la tabla Producto, de tipo varchar(15) y que admita nulos
USE Gerardo
GO
ALTER TABLE Producto
ADD Color VARCHAR(15) NULL
GO

--borrar una columna de una tabla existente sin perder los demas datos
USE Gerardo
GO
ALTER TABLE Producto
DROP COLUMN Color
GO
--lo anterior borrar la columna Color de la tabla Producto

--cambiar el tamaño a una columna existente sin perder datos
--Ampliar el tamaño de la columna Nombre a 250 caracteres
USE Gerardo
GO
ALTER TABLE Producto
ALTER COLUMN Nombre VARCHAR(250) NOT NULL
GO
