CREATE PROCEDURE [dbo].[uspWidgets_Update]
	@Id int,
	@Name varchar(50),
	@Description varchar(50),
	@LastUpdatedDate datetime
AS

update [Widgets] set [Name] = @Name, [Description] = @Description, [LastUpdatedDate] = @LastUpdatedDate where [Id] = @Id