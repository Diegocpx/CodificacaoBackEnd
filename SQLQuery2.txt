CREATE DATABASE TesteSegBET9
GO

USE TesteSegBET9
GO

CREATE TABLE Usuarios
(
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(30) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@email.com', 123456)
GO

SELECT * FROM Usuarios

SELECT Email FROM Usuarios

SELECT Email, HASHBYTES('MD2', Senha) AS 'Senha Hash MD2' FROM Usuarios
SELECT Email, HASHBYTES('MD4', Senha) AS 'Senha Hash MD4' FROM Usuarios
SELECT Email, HASHBYTES('MD5', Senha) AS 'Senha Hash MD5' FROM Usuarios
SELECT Email, HASHBYTES('SHA', Senha) AS 'Senha Hash SHA' FROM Usuarios
SELECT Email, HASHBYTES('SHA1', Senha) AS 'Senha Hash SHA1' FROM Usuarios
SELECT Email, HASHBYTES('SHA2_256', Senha) AS 'Senha Hash SHA2_256' FROM Usuarios
SELECT Email, HASHBYTES('SHA2_512', Senha) AS 'Senha Hash SHA2_512' FROM Usuarios