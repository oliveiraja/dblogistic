USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanTama_Insert]    Script Date: 8/08/2019 5:54:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_T_SasanTama_Insert]
@data_tama date,
@supplierId int,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@kondisaun_sasan varchar(50),
@observasaun varchar(50),
@qtd int, 
@presu decimal(10,2),
@armajenId int

AS
BEGIN
	INSERT INTO T_SasanTama(Data_Tama,SupplierId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,observasaun,kondisaun_sasan, Qtd,Presu,ArmajenId)
	VALUES (@data_tama,@supplierId,@kategoriaId,@subkategoriaId,@markaId,@modeluId, @kondisaun_sasan,@observasaun, @qtd,@presu,@armajenId)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE   KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)			
		END
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,observasaun,kondisaun_sasan,qtd_tama)
			VALUES (@armajenId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@kondisaun_sasan,@observasaun, @qtd)
		END
END