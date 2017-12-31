CREATE PROCEDURE [dbo].[SPEliminarLibro]
@isbn int
AS

DELETE FROM Libros WHERE isbn=@isbn

RETURN 0