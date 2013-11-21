CREATE PROCEDURE [dbo].[uspCogs_Insert]
	@Name varchar(50),
	@Description varchar(50)
AS

insert into [Cogs] ([Name], [Description]) values (@Name, @Description)

select SCOPE_IDENTITY() as [Id]
