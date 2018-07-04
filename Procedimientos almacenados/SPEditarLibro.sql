CREATE PROCEDURE [dbo].[SPEditarLibro]
@idLibro int output,
@isbn varchar(50),
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

UPDATE Libros SET isbn=@isbn, titulo=@titulo, lenguaje=@lenguaje, editorial = @editorial, publicacion=@publicacion,
genero=@genero, disponibilidad=@disponibilidad, comentarios=@comentarios, autores=@autores, edicion=@edicion,
fechaedicion=@fechaedicion, npaginas=@npaginas, materia=@materia, subgenero=@subgenero,ubicacion=@ubicacion, tag=@tag,
codigobarras=@codigobarras, imagen=@imagen WHERE isbn=@isbn

RETURN 0