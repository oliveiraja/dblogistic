USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_Registo_Update]    Script Date: 10/10/2019 11:28:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_T_Registo_Update]
@Id int,
@NaranUsers varchar (50),
@password varchar (50),
@email varchar (50),
@funsaun varchar(50)

AS
BEGIN
	UPDATE dbo.T_registo set NaranUsers = @NaranUsers, password = @password,email = @email, funsaun = @funsaun
	WHERE Id = @id
END
