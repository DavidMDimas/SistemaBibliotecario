create proc [dbo].[SPBuscarISBN]
@isbn varchar(50)
as
select * from Libros
where isbn = @isbn
