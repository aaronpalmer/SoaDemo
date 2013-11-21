CREATE PROCEDURE [dbo].[uspSprockets_Update]
	@Id int,
	@Name varchar(50),
	@Description varchar(50)
AS

update [Sprockets] set [Name] = @Name, [Description] = @Description where [Id] = @Id