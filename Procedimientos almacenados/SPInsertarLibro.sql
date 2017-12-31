CREATE PROCEDURE [dbo].[SPInsertarLibro]
@idLibro int output,
@isbn int,
@titulo varchar(50),
@lenguaje varchar(50),
@editorial varchar(50),
@publicacion varchar(50),
@genero varchar(50),
@disponibilidad varchar(50),
@comentarios varchar(50),
@autores varchar(50),
@edicion varchar(50),
@fechaedicion date,
@npaginas int,
@materia varchar(50),
@subgenero varchar(50),
@ubicacion varchar(50),
@tag varchar(50),
@codigobarras varchar(50),
@imagen image
AS

INSERT INTO Libros(isbn, titulo, lenguaje, editorial, publicacion, genero,
disponibilidad, comentarios, autores, edicion, fechaedicion, npaginas,
materia, subgenero, ubicacion, tag, codigobarras, imagen)
VALUES(@isbn, @titulo, @lenguaje, @editorial, @publicacion, @genero,
@disponibilidad, @comentarios, @autores, @edicion, @fechaedicion, @npaginas,
@materia, @subgenero, @ubicacion, @tag, @codigobarras, @imagen)
RETURN 0