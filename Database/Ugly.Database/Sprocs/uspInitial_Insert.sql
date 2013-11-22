CREATE PROCEDURE [dbo].[uspInitial_Insert]
	@InitialId as int, @InitialName as varchar(50), @InitialDesc as varchar(50)
AS
	insert into UberTable (InitialId, InitialName, InitialDesc) values (@InitialId, @InitialName, @InitialDesc)
