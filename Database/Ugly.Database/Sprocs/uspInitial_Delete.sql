CREATE PROCEDURE [dbo].[uspInitial_Delete]
	@InitialId as int
AS
	update UberTable set InitialId = null, InitialName = null, InitialDesc = null where InitialId = @InitialId
