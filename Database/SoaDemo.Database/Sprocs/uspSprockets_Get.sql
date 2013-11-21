CREATE PROCEDURE [dbo].[uspSprockets_Get]
	@id int
AS

if @id is null
  begin
	select [Id], [Name], [Description] from [Sprockets]
  end
else
  begin
	select [Id], [Name], [Description] from [Sprockets] where [Id] = @id
  end

