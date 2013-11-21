CREATE PROCEDURE [dbo].[uspWidgets_Insert]
	@Name varchar(50),
	@Description varchar(50),
	@LastUpdatedDate datetime
AS

insert into [Widgets] ([Name], [Description], [LastUpdatedDate]) values (@Name, @Description, @LastUpdatedDate)

select SCOPE_IDENTITY() as [Id]
