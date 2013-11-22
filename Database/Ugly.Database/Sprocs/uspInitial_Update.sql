CREATE PROCEDURE [dbo].[uspInitial_Update]
	@InitialId as int, @InitialName as varchar(50), @InitialDesc as varchar(50)
AS
	update UberTable set InitialName = @InitialName, InitialDesc = @InitialDesc where InitialId = @InitialId
