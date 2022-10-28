USE [lisdb]
GO
/****** Object:  StoredProcedure [dbo].[usp_search]    Script Date: 22/02/2021 4:39:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[usp_search]
@Find varchar(20)
as
BEGIN
	SELECT TOP 30
	A.Descrisaun, A.Nomatrikula,A.Nomesin,A.Noserial,A.tinan_produsan,
	A.naran_utilizador,A.observasaun [Observasaun],Qtd
	FROM T_transporte A
	

	WHERE A.Descrisaun LIKE '%' + @Find + '%' 
	OR A.Nomatrikula LIKE '%' + @Find + '%' 
	OR A.Nomesin LIKE '%' + @Find + '%' 
	OR A.Noserial LIKE '%' + @Find + '%' 
	OR A.tinan_produsan LIKE '%' + @Find + '%' 
	OR A.Qtd LIKE '%' + @Find + '%'
	OR A.naran_utilizador LIKE '%' + @Find + '%'	
	OR A.observasaun LIKE '%' + @Find + '%' 
	
END

exec usp_search 2


