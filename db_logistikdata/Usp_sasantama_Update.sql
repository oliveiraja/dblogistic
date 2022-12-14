USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanTama_UpdateE]    Script Date: 10/10/2019 4:49:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_T_SasanTama_UpdateE]
@id int,
@data_tama date,
@supplierId int,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@observasaun varchar(50),
@kondisaun_sasan varchar (50),
@qtd int, 
@presu decimal(10,2),
@armajenId int


AS
BEGIN
	UPDATE T_SasanTama set Data_Tama =@data_tama, SupplierId=@supplierId,KategoriaId=@kategoriaId,SubKategoriaId=@subkategoriaId,MarkaId=@markaId,ModeluId=@modeluId, observasaun=@observasaun,kondisaun_sasan=@kondisaun_sasan, Presu=@presu,Qtd =@qtd,ArmajenId=@armajenID
	WHERE Id = @id
	IF NOT EXISTS (SELECT * FROM T_ArmajenStock WHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,qtd_tama)
			VALUES (@armajenId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)

			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId   AND  kondisaun_sasan=@kondisaun_sasan and observasaun=@observasaun and armajenID = @armajenId)
			WHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId 

			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE  ArmajenId = @armajenId and KategoriaId=@kategoriaId and SubKategoriaId=@subkategoriaId and MarkaId=@markaId and ModeluId=@modeluId and kondisaun_sasan=@kondisaun_sasan and observasaun=@observasaun)
		    WHERE ArmajenId=@armajenId and KategoriaId=@kategoriaId and SubKategoriaId=@subkategoriaId and MarkaId=@markaId and ModeluId=@modeluId 

		END
	ELSE
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)
			WHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND ArmajenId = @armajenId
			--UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanIdtuan AND armajenID = @armajenId)
			--WHERE sasanID = @sasanIdtuan AND armajenID = @armajenId
		END

END
