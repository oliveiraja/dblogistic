USE [lisdb]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanTama_View]    Script Date: 15/02/2021 9:42:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_T_SasanTama_View]
AS
BEGIN
SELECT T1.Id[Id],T1.Data_Tama[DATA_TAMA],T2.Naran[SUPPLIER],T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran [MODELU],
T1.Qtd[QUANTIDADE],T1.Presu[PRESU],T1.Total[TOTAL], T1.observasaun[OBSERVASAUN], T3.kondisaun_sasan[KONDISAUN_SASAN], T1.ipcomp[IPCOMP],T1.compname[COMPNAME], T8.Naran[ARMAJEN]
from dbo.T_SasanTama T1
INNER JOIN T_Supplier T2 ON T1.SupplierId=T2.Id
INNER JOIN T_konidsaun_sasan T3 ON T1.kondisaun_sasan=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
INNER JOIN T_Armajen T8 ON T1.ArmajenId=T8.Id
END
exec usp_T_ArmajenStock_View