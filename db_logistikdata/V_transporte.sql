Alter PROCEDURE [dbo].[usp_T_Transporte_View]
AS
BEGIN
SELECT T1.Id[Id],T1.Kodigo[KODIGO],T1.Nobarcode[NO_BARCODE], T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran[MODELU],T1.Descrisaun[DESCRISAUN],  
T1.Nomatrikula[NOMATRIKULA],T1.Nomesin[NOMESIN],
T1.Noserial[NOSERIAL],T1.Fontes[FONTES],T1.tinan_produsan[TINANPRODUSAN],
T2.kondisaun_sasan[KONDISAUN_SASAN],T1.Qtd[QUANTIDADE],T3.Naran[DEPARTAMENTU],T1.naran_utilizador[NARANUTILIZADOR], T8.Naran[ARMAJEN]  ,
T1.observasaun[OBSERVASAUN]
FROM T_transporte T1
INNER JOIN T_konidsaun_sasan T2 ON T1.kondisaun_sasan=T2.Id
INNER JOIN T_Departemento T3 ON T1.DepartamentoId=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
INNER JOIN T_Armajen T8 ON T1.aramajenId=T8.Id
end