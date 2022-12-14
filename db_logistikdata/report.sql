USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_reportviewer]    Script Date: 24/10/2019 12:37:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter procedure [dbo].[usp_reportviewer]
(
@fromDate datetime,
@toDate datetime
)
as 
SELECT T1.Id[Id],T1.Data_Tama[Data_Tama],T2.Naran[SUPPLIER],T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran [MODELU],T1.observasaun[OBSERVASAUN],T1.kondisaun_sasan[KONDISAUN_SASAN],
T1.Qtd[QUANTIDADE],T1.Presu[PRESU],T1.Total[TOTAL],T8.Naran[ARMAJEN]
from dbo.T_SasanTama T1
INNER JOIN T_Supplier T2 ON T1.supplierID=T2.Id
--INNER JOIN T_Sasan T3 ON T1.sasanId=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
INNER JOIN T_Armajen T8 ON T1.ArmajenId=T8.Id
where Data_Tama between @fromDate and @toDate
--order by Data_Tama asc
--exec usp_reportviewer