Alter proc [dbo].[usp_search]
@Find varchar(20)
as
BEGIN
	SELECT TOP 30
	A.Qtd,A.Presu, A.Total, CONVERT (varchar(10), A.KategoriaId, 103),
	A.kondisaun_sasan,A.observasaun [Observasaun]
	FROM T_SasanTama A
	WHERE A.KategoriaId LIKE '%' + @Find + '%' 
	OR A.SubKategoriaId LIKE '%' + @Find + '%' 
	OR A.kondisaun_sasan LIKE '%' + @Find + '%' 
	OR A.observasaun LIKE '%' + @Find + '%' 
	OR A.Qtd LIKE '%' + @Find + '%' 
	OR A.Presu LIKE '%' + @Find + '%'
	OR A.Total LIKE '%' + @Find + '%'	
	--OR A.NoTlp LIKE '%' + @Find + '%' OR A.Email LIKE '%' + @Find + '%'
	
END
GO

exec T_Rhidentifikasaun_view 
DROP  TABLE T_RHIdentivikasaun