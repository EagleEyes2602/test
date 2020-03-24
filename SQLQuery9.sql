create proc [Employee_GetById]
@Id INT
as
BEGIN
	SELECT TOP 1 * FROM Employee WHERE Id = @Id
END

exec [Employee_GetById] 1
GO

create proc [Employee_GetAll]
as
BEGIN
	SELECT * FROM Employee
END
GO

ALTER proc [Employee_Add]
	@Code varchar(20)
	,@FirstName nvarchar(255)
	,@LastName nvarchar(255)
	,@Email varchar(255)
	,@Password varchar(255)
	,@Phone varchar(50)
	,@Gender tinyint
	,@DOB datetime
	,@CreatedBy int
	,@Notes ntext
	,@Status tinyint
as
BEGIN
	INSERT INTO Employee(
		Code
		,FirstName
		,LastName
		,Email
		,Password
		,Phone
		,Gender
		,DOB
		,CreatedTime
		,CreatedBy
		,Notes
		,Status
	) VALUES(
		@Code
		,@FirstName
		,@LastName
		,@Email
		,@Password
		,@Phone
		,@Gender
		,@DOB
		,GETDATE()
		,@CreatedBy
		,@Notes
		,@Status
	)
	SELECT SCOPE_IDENTITY()
END
GO


select 'param.Add("@'+COLUMN_NAME+'", 1);' FROM INFORMATION_SCHEMA.COLUMNS
where TABLE_NAME = 'Employee'
GO

exec [Employee_Add] '123', 'a', 'b', '123@gmail.com', '123', '123456789', 0, '2020-10-10',1,'', 1

select * from Employee