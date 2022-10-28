CREATE TABLE dbo.T_transporte(
Id int identity(1,1)constraint pk_t_transporte_id primary key,
Kodigo int,
Nobarcode varchar(50),
Descrisaun varchar(50),
Nomatrikula varchar(50),
KategoriaId int,
SubkategoriaId int,
MarkaId int,
ModeluId int,
Nomesin varchar(50),
Noserial varchar(50),
Fontes varchar(50),
tinan_produsan date,
DepartamentoId int,
naran_utilizador varchar (50),
aramajenId int)



drop table T_transporte




EXEC usp_T_SasanTama_View

ALTER PROCEDURE usp_T_Transporte_View
AS
BEGIN
SELECT T1.Id[Id], T1.Kodigo[KODIGO],T1.Nobarcode[NO_BARCODE], T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran[MARKA],T7.Naran[MODELU],
T8.Naran[ARAMAJEN], Descrisaun[DESCRISAUN], T1.Nomatrikula[NO_MATRIKULA],T1.Noserial[NO_SERIAL],
T1.Fontes[FONTES],T1.tinan_produsan[TINAN_PRODUSAN], T3.Naran[DEPARTAMENTO], T1.naran_utilizador[NARAN_UTILIZADOR] 
FROM T_transporte T1
INNER JOIN T_Departemento T3 ON T1.DepartamentoId=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId
INNER JOIN T_Armajen T8 ON T1.aramajenId=T8.Id

END



ALTER PROCEDURE [dbo].[usp_Transporte_Insert]
@Kodigo int,
@Nobarcode varchar(50),
@Descrisaun varchar(50),
@Nomatrikula varchar(50),
@Nomesin varchar(50),
@Noserial varchar(50),
@Fontes varchar(50),
@tinan_produsan date,
@Departamentoid int,
@naran_utilizador varchar(50),
@aramajenId int
AS
BEGIN
	INSERT INTO T_transporte(Kodigo,Nobarcode,Descrisaun,Nomatrikula,Nomesin,Noserial,Fontes,
	 tinan_produsan, DepartamentoId,naran_utilizador,aramajenId)
	VALUES (@Kodigo,@Nobarcode,@Descrisaun, @Nomatrikula, @Nomesin, @Noserial, @Fontes,@tinan_produsan,
	@Departamentoid,@naran_utilizador,@aramajenId)
END




exec usp_T_Transporte_View
select *from T_transporte where