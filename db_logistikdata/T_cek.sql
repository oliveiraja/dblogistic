CREATE TABLE dbo.T_cek(
Id int identity(1,1)constraint pk_t_cek_id primary key,
Kodigo int,
Nobarcode varchar(50),
Descrisaun varchar(50),
Noserial Varchar(50),
KategoriaId int,
SubkategoriaId int,
MarkaId int,
ModeluId int)



Alter PROCEDURE usp_T_Cek_View
AS
BEGIN
SELECT T1.Id[Id], T1.Kodigo[KODIGO],T1.Nobarcode[NO_BARCODE],Descrisaun[DESCRISAUN],  T1.Noserial[NO_SERIAL],T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran[MARKA],T7.Naran[MODELU]
FROM T_cek T1
INNER JOIN T_Kategoria T4 ON T1.KategoriaId= T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubkategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId= T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
END
exec usp_T_Cek_View

Alter PROCEDURE Usp_T_cek_Insert
@Kodigo int,
@Nobarcode varchar(50),
@Descrisaun varchar(50),
@Noserial Varchar(50),
@KategoriaId int,
@SubkategoriaId int,
@MarkaId int,
@ModeluId int
AS
BEGIN
	INSERT INTO T_cek(Kodigo,Nobarcode,Descrisaun, Noserial,KategoriaId,SubkategoriaId,MarkaId,ModeluId)
	 VALUES (@Kodigo,@Nobarcode,@Descrisaun, @Noserial,@KategoriaId,@SubkategoriaId,@MarkaId,@ModeluId)
END

exec usp_T_Cek_View


