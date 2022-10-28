CREATE TABLE dbo.T_SasanAtk(
Id int identity(1,1)constraint pk_t_sasanatk_id primary key,
Data_Tama date,
SasanId int,
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
Qtd int,
Unidade Varchar(50),
observasaun varchar(50),
compname varchar(50),
ipcomp varchar(50),
ArmajenId int)

--SP SASAN ATK
CREATE PROCEDURE [dbo].[usp_T_SasanAtk_View]
AS
BEGIN
SELECT T1.Id[Id],T1.Data_Tama[DATA_TAMA],T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran [MODELU],
T1.Qtd[QUANTIDADE],T1.Unidade[UNIDADE], observasaun[OBSERVASAUN], T1.ipcomp[IPCOMP],T1.compname[COMPNAME], T8.Naran[ARMAJEN]
from T_SasanAtk T1

INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
INNER JOIN T_Armajen T8 ON T1.ArmajenId=T8.Id
END
exec usp_T_SasanAtk_View

-- SP INSER SASAN ATK


CREATE PROCEDURE usp_T_Sasanatk_Insert
@data_tama date,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@qtd int, 
@unidade varchar(50),
@observasaun varchar(50),
@compname varchar (50),
@ipcomp varchar (50),
@armajenId int

AS
BEGIN
	INSERT INTO T_SasanAtk(Data_Tama,KategoriaId,SubKategoriaId,MarkaId,ModeluId ,Qtd,Unidade,observasaun,compname,ipcomp, ArmajenId)
	VALUES (@data_tama,@kategoriaId,@subkategoriaId,@markaId,@modeluId,@qtd,@unidade,@observasaun,@compname,@unidade, @armajenId)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE   KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)			
		END
		
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,qtd_tama)
		 VALUES (@armajenId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)
		END
END

