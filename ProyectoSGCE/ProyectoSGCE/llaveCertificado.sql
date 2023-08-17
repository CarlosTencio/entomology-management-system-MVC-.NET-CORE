--crear llave maestra
CREATE MASTER KEY ENCRYPTION BY PASSWORD = '12345'
GO

--crear certificado validador
CREATE CERTIFICATE certProyectoLenguajes
WITH SUBJECT='Certificate ProyectoLenguajes'
GO

--crear llave simetrica
CREATE SYMMETRIC KEY smkProyectoLenguajes
WITH ALGORITHM= AES_256
ENCRYPTION BY CERTIFICATE certProyectoLenguajes
GO