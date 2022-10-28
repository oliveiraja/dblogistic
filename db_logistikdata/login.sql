Alter proc [dbo].[usp_tusersVALIDATE]
@Email varchar(50),@uPwd varchar(50)
as
BEGIN
	SELECT TOP 1 * FROM T_registo WHERE email=@Email AND password=@uPwd
END