CREATE PROCEDURE dbo.PipinGetStudentById
	(@Id int = 5)
AS
select * from StudentList where Id = @Id
