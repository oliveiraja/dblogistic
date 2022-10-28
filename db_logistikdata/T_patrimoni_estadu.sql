--Tabela Patrimoni
CREATE TABLE dbo.T_patrimoni(
Id int identity(1,1)constraint pk_t_sasanpatrimoni_id primary key,
Kodigo int,
Data_Tama date,
Nobarcode varchar(50),
Descrisaun varchar(50),
Noserial varchar(50),
Fontes varchar(50),
tinan_produsan date,
--kondisaun_sasan int,
DepartamentoId int,
--naran_utilizador varchar (50),
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
Qtd int)
--observasaun varchar(50),

drop Table T_patrimoni


--View Patrimoni

Alter PROCEDURE usp_T_Sasanpatrimoni_View
AS
BEGIN
SELECT T1.Id[Id], T1.Kodigo[KODIGO], T1.Data_Tama[DATA_TAMA],T1.Nobarcode[NO_BARCODE], T1.Descrisaun[DESCRISAUN], T1.Noserial[NO_SERIAL],
T1.Fontes[FONTES],T1.tinan_produsan[TINAN_PRODUSAN], T3.Naran[DEPARTAMENTO], T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran [MODELU],T1.Qtd[QUANTIDADE]

FROM T_patrimoni T1
--INNER JOIN T_konidsaun_sasan T2 ON T1.kondisaun_sasan=T2.Id
INNER JOIN T_Departemento T3 ON T1.DepartamentoId=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
--INNER JOIN T_Armajen T8 ON T1.ArmajenId=T8.Id
END

Alter PROCEDURE [dbo].[usp_T_Sasanpatrimoni_Insert]
@Kodigo int,
@data_tama date,
@nobarcode varchar(50),
@descrisaun varchar(50),
@noserial varchar(50),
@fontes varchar(50),
@tinan_produsan varchar(50),
--@kondisaun_sasan int,
@departamentoid int,
--@naran_utilizador varchar(50),
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@qtd int
--@observasaun varchar(50),

AS
BEGIN
	INSERT INTO T_patrimoni(Kodigo,Data_Tama,Nobarcode, Descrisaun,Noserial,Fontes,tinan_produsan,DepartamentoId, KategoriaId,SubKategoriaId,MarkaId,ModeluId,Qtd)
	VALUES (@Kodigo,@data_tama,@nobarcode, @descrisaun,@noserial,@fontes,@tinan_produsan,@departamentoid, @kategoriaId,@subkategoriaId,@markaId,@modeluId,@qtd)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE   KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId)			
		END
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId)
			VALUES (@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)
		END
END
delete from T_SasanTama

exec usp_T_Sasanpatrimoni_View