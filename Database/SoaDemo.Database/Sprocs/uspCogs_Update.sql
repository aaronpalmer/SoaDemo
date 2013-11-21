CREATE PROCEDURE [dbo].[uspCogs_Update]
	@Id int,
	@Name varchar(50),
	@Description varchar(50)
AS

update [Cogs] set [Name] = @Name, [Description] = @Description where [Id] = @Id