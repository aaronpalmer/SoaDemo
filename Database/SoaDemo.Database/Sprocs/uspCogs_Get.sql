CREATE PROCEDURE [dbo].[uspCogs_Get]
	@id int
AS

if @id is null
  begin
	select [Id], [Name], [Description] from [Cogs]
  end
else
  begin
	select [Id], [Name], [Description] from [Cogs] where [Id] = @id
  end

