USE AdventureWorks2014
GO

CREATE PROCEDURE sp_EliminarDepartamento (
	@nombreDepartamento NVARCHAR(50)
)
AS
BEGIN
	DELETE FROM HumanResources.Department
	WHERE Name = @nombreDepartamento
END