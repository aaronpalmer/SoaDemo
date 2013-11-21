CREATE PROCEDURE [dbo].[uspWidgets_Get]
	@id int
AS

if @id is null
  begin
	select [Id], [Name], [Description], [LastUpdatedDate] from [Widgets]
  end
else
  begin
	select [Id], [Name], [Description], [LastUpdatedDate] from [Widgets] where [Id] = @id
  end

