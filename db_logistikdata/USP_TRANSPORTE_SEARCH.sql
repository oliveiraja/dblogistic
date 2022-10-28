alter proc [dbo].[usp_search_transporte]
@Find varchar(20)
as
BEGIN
	SELECT TOP 30
	 A.naran_utilizador[NARAN_UTILIZADOR],  A.Kodigo, a.Qtd,A.Nobarcode,A.Nomatrikula,A.Nomesin,A.Fontes,
	A.observasaun [Observasaun]
	FROM T_transporte A
	WHERE A.naran_utilizador LIKE '%' + @Find + '%' 
	OR A.Kodigo LIKE '%' + @Find + '%' 
	OR A.Qtd LIKE '%' + @Find + '%'
	OR A.Nobarcode LIKE '%' + @Find + '%' 
	OR A.Nomatrikula LIKE '%' + @Find + '%' 
	OR A.Nomesin LIKE '%' + @Find + '%' 
	OR A.Fontes LIKE '%' + @Find + '%' 
	OR A.observasaun LIKE '%' + @Find + '%' 
	
	
		
	--OR A.NoTlp LIKE '%' + @Find + '%' OR A.Email LIKE '%' + @Find + '%'
	
END
GO
truncate table T_transporte
