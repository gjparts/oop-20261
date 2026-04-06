/*DML: Data Manipulation Language
Lenguaje de manipulacion de datos
Son las instrucciones que se usan para interactuar con los
datos almacenados en las diferentes tablas de nuestra base
de datos.
Las mas utilizadas son: SELECT, INSERT, UPDATE, DELETE*/

--IMPORTANTE: las instrucciones DML no requieren del uso de GO (es opcional)

--siempre seleccione la bd antes de ejecutar instrucciones
USE Gerardo
GO

--Instruccion INSERT
/*agrega uno o mas registros a una tabla.
1) en INSERT debe incluir todos los campos/columnas que sean NOT NULL (obligatorias)
2) Los campos que son NULL son opciones Usted decide si los coloca o no en INSERT
3) La columna definida como IDENTITY (autonumerica) NO se coloca en el INSERT
   debido a que este tipo de columna es autonumerada por la BD.*/

--INSERT que llena todas las columnas de la tabla Producto
INSERT Producto(Codigo, Nombre, Costo, PrecioVenta, Existencias, Comentarios)
VALUES('CC01','Coca Cola 3L',60,70,0,'Mala para la salud')

--consultar los registros de la tabla
SELECT * FROM Producto
