USE [LIS]
GO
/****** Object:  StoredProcedure [dbo].[usp_T_SasanTama_Insert]    Script Date: 10/10/2019 4:48:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter PROCEDURE [dbo].[usp_T_SasanTama_Insert]
@data_tama date,
@supplierId int,
@Kodigo int,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@observasaun varchar(50),
@kondisaun_sasan varchar(50),
@qtd int, 
@presu decimal(10,2),
@compname varchar (50),
@ipcomp varchar (50),
@armajenId int

AS
BEGIN
	INSERT INTO T_SasanTama(Data_Tama,SupplierId, Kodigo,KategoriaId,SubKategoriaId,MarkaId,ModeluId, observasaun,kondisaun_sasan, Qtd,Presu, compname,ipcomp, ArmajenId)
	VALUES (@data_tama,@supplierId,@Kodigo,@kategoriaId,@subkategoriaId,@markaId,@modeluId,@observasaun,@kondisaun_sasan, @qtd,@presu,@compname,@ipcomp, @armajenId)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE   KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)			
		END
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,KategoriaId,SubKategoriaId,MarkaId,ModeluId, qtd_tama)
			VALUES (@armajenId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)
		END
END
exec usp_T_SasanTama_View