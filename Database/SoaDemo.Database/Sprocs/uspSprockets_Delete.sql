CREATE PROCEDURE [dbo].[uspSprockets_Delete]
	@Id as int
AS

delete from [Sprockets] where [Id] = @Id