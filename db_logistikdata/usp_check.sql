USE [lisdb]
GO
/****** Object:  StoredProcedure [dbo].[usp_sasantamaCHECK]    Script Date: 5/03/2021 5:10:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_sasantamaCHECK]
@Kodigo int
as
BEGIN
	SELECT * FROM T_transporte WHERE Kodigo=@Kodigo
END