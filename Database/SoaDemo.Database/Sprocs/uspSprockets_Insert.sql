CREATE PROCEDURE [dbo].[uspSprockets_Insert]
	@Name varchar(50),
	@Description varchar(50),
	@NewId int output
AS

insert into [Sprockets] ([Name], [Description]) values (@Name, @Description)

set @NewId = SCOPE_IDENTITY()
