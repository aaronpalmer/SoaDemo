CREATE PROCEDURE [dbo].[uspInitial_Get]
	@id int
AS
	SELECT InitialId, InitialName, InitialDesc from UberTable where InitialId = @id

