Create PROCEDURE [dbo].[usp_T_transporte_Insert]
@Nobarcode varchar(50),
@KategoriaId int,
@SubkategoriaId int,
@MarkaId int,
@ModeluId int,
@Descrisaun varchar(50),
@Noserial varchar(50),
@Nomesin varchar(50),
@Nomatrikula varchar(50),
@Fontes varchar(50),
@Tinan_produsan date,
@kondisaun_sasan int,
@Departamentoid int,
@ArmajenId int,
@naran_utilizador varchar(50),
@observasaun varchar(50),
@Qtd int
AS
BEGIN
	INSERT INTO T_transporte(Nobarcode,KategoriaId,SubKategoriaId,MarkaId,ModeluId, Descrisaun, Nomatrikula,
Nomesin,Noserial,Fontes,tinan_produsan,kondisaun_sasan,Qtd, DepartamentoId,aramajenId, naran_utilizador,observasaun)
	VALUES (@Nobarcode, @KategoriaId,@SubkategoriaId,@MarkaId,@ModeluId, @Descrisaun,@Noserial,@Fontes,@Tinan_produsan,@kondisaun_sasan,@Departamentoid,@naran_utilizador,@observasaun,@Qtd)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_transporte
			WHERE   KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId)			
		END
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId)
			VALUES (@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)
		END
END
