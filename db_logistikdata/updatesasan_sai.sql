USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanSai_Update]    Script Date: 29/07/2019 6:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_T_SasanSai_Update]
@id int,@data_sai date,@armajenId int,@departementoId int,@kategoriaid int, @subkategoriaId int,@markaid int,@modeluid int, @Qtd int
AS
BEGIN
	UPDATE T_SasanSai set data_sai = @data_sai,armajenID = @armajenId,departementoID= @departementoId,KategoriaId=@kategoriaid,SubKategoriaId=@subkategoriaId,MarkaId=@markaid,ModeluId=@modeluid,Qtd= @Qtd 
	WHERE Id = @id

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE KategoriaId=@kategoriaid AND SubKategoriaId=@subkategoriaId and MarkaId=@markaid and ModeluId=@modeluid and armajenID = @armajenId)
		BEGIN
		   --INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,qtd_tama)
			--VALUES (@armajenId,@kategoriaId,@subkategoriaid,@markaId,@modeluId, @qtd)

			UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM(Qtd) from T_SasanSai wHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
			WHERE  KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId
END
		else
		
		
		begin
		UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM(Qtd) from T_SasanSai wHERE  ArmajenId = @armajenId and KategoriaId=@kategoriaId and SubKategoriaId=@subkategoriaId and MarkaId=@markaId and ModeluId=@modeluId)
		  --  WHERE ArmajenId=@armajenId and KategoriaId=@kategoriaId and SubKategoriaId=@subkategoriaId and MarkaId=@markaId and ModeluId=@modeluId

		-- Update  T_ArmajenStock set qtd_sai=(select sum(Qtd)from T_SasanSai where SasanId=@sasanId and armajenID=@armajenId)
			--VALUES (@armajenId,@sasanId,@qtd)
		
	END	
		
END
