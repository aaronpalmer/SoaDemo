CREATE PROCEDURE [dbo].[uspSprockets_Insert]
	@Name varchar(50),
	@Description varchar(50)
AS

insert into [Sprockets] ([Name], [Description]) values (@Name, @Description)

select SCOPE_IDENTITY() as [Id]
