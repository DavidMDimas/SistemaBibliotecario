USE [SistemaBibliotecaDBGeneral]
GO
CREATE PROCEDURE [dbo].[SPInsertarAutor]
@idAutor int output,
@nombre varchar(50),
@apellido varchar(50),
@nacionalidad varchar(50),
@telefono int,
@direccion varchar(50),
@email varchar(50)
AS
INSERT INTO Autor(idAutor, Nombre, Apellido, Nacionalidad, Telefono, Direccion,Email)
VALUES(@idAutor,@nombre, @apellido, @nacionalidad, @telefono, @direccion, @email)
RETURN 0