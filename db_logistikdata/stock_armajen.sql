USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_ArmajenStock_View]    Script Date: 8/08/2019 6:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_T_ArmajenStock_View]
AS 
BEGIN
		SELECT T1.Id[Id],T2.Naran[ARMAJEN],T4.Naran[KATEGORIA],T5.Naran[SUBKATEGORIA],T6.Naran[MARKA],T7.Naran[MODELU],kondisaun_sasan[KONDISAUN],observasaun[OBSERVASAUN], T1.qtd_tama [QUANTIDADE_TAMA],T1.qtd_sai [QUANTIDADE_SAI],T1.qtd_atual [QUANTIDADE_ATUAL] 
		from dbo.T_ArmajenStock T1
		INNER JOIN T_Armajen T2 ON T1.ArmajenId=T2.Id
		--INNER JOIN T_Sasan T3 ON T1.SasanId=T3.Id
		INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
		INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
		INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
		INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
END

exec usp_T_SasanTama_View