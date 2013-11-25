CREATE PROCEDURE [dbo].[uspWidgets_Insert]
	@Name varchar(50),
	@Description varchar(50),
	@LastUpdatedDate datetime,
	@NewId int output
AS

insert into [Widgets] ([Name], [Description], [LastUpdatedDate]) values (@Name, @Description, @LastUpdatedDate)

set @NewId = SCOPE_IDENTITY()
