USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_Registo_Insert]    Script Date: 10/10/2019 11:50:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_T_Registo_Insert]
@NaranUsers varchar (50),
@password varchar (50),
@email varchar (50),
@funsaun varchar(50)
AS
BEGIN
	INSERT INTO  dbo.T_registo(NaranUsers,password,email,funsaun)
	VALUES (@NaranUsers,@password,@email,@funsaun)
END
