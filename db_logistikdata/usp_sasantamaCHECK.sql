USE [lisdb]
GO
/****** Object:  StoredProcedure [dbo].[usp_sasantamaCHECK]    Script Date: 5/03/2021 3:22:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[usp_sasantamaCHECK]
@Kodigo int
as
BEGIN
	SELECT * FROM T_cek WHERE Kodigo=@Kodigo
END