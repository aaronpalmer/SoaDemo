CREATE PROCEDURE [dbo].[uspWidgets_Delete]
	@Id as int
AS

delete from [Widgets] where [Id] = @Id