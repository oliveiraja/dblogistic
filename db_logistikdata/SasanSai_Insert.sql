USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanSai_Insert]    Script Date: 9/30/2019 4:06:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_T_SasanSai_Insert]
@data_sai date,@armajenId int,@departementoId int,@kategoriaId int,
@subKategoriaId int,
@markaId int,
@modeluId int, @Qtd int,@msg varchar(100) output 
AS
BEGIN
	IF @Qtd <= (SELECT SUM (qtd_atual) from T_ArmajenStock where   KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId  AND ArmajenId = @armajenId)
		BEGIN
			INSERT INTO dbo.T_SasanSai (Data_Sai,ArmajenId,DepartementoId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,Qtd)
			VALUES (@data_sai ,@armajenId ,@departementoId ,@kategoriaId,@subKategoriaId,@markaId,@modeluId, @Qtd) 


			IF EXISTS (SELECT * FROM T_ArmajenStock WHERE  KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId)
				BEGIN
					UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM (Qtd) from T_SasanSai WHERE KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId)
					WHERE  KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId
				END
		END
		ELSE
			BEGIN
				SET @msg = 'Quantidade Sasan Bot Liu'
			END
END

