CREATE PROCEDURE [dbo].[SPMostrarLibros]
@isbn int
AS

select top 100 * from Libros
order by isbn asc