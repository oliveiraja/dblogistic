USE [lisdb]
GO
/****** Object:  StoredProcedure [dbo].[usp_search_Cek]    Script Date: 9/5/2022 10:16:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_search_Cek]
@Find varchar(20)
as
BEGIN
	SELECT TOP 30
	 A.Kodigo,A.Nobarcode,A.Descrisaun,A.Noserial,A.Nomesin,A.Nomatrikula,Utilizador[UTILIZADOR]
	FROM T_cek A
	WHERE A.Kodigo LIKE '%' + @Find + '%' 
	OR A.Nobarcode LIKE '%' + @Find + '%'
	OR A.Descrisaun LIKE '%' + @Find + '%' 
	OR A.Noserial LIKE '%' + @Find + '%' 
	OR A.Nomesin LIKE '%' + @Find +'%'
	OR A.Nomatrikula LIKE '%' +@Find + '%'
	OR A.Utilizador LIKE '%'+@Find +'%'
	
END
