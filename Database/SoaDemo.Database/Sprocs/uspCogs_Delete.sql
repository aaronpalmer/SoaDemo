CREATE PROCEDURE [dbo].[uspCogs_Delete]
	@Id as int
AS

delete from [Cogs] where [Id] = @Id