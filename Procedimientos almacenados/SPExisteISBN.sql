CREATE PROCEDURE [dbo].[SPExisteISBN]
@isbn varchar(50)
AS
SELECT COUNT(*) FROM Libros WHERE isbn = @isbn