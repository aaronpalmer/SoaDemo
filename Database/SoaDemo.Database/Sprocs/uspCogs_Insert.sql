CREATE PROCEDURE [dbo].[uspCogs_Insert]
	@Name varchar(50),
	@Description varchar(50),
	@NewId int output
AS

insert into [Cogs] ([Name], [Description]) values (@Name, @Description)

set @NewId = SCOPE_IDENTITY()
