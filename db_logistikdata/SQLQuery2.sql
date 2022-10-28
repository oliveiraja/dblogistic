Alter PROCEDURE usp_T_SasanSai_Update
@id int,@data_sai date,@armajenId int,@departementoId int, @kategoriaId int,@subkategoriaId int,@MarkaId,@modeloId int,     @Qtd int
AS
BEGIN
	UPDATE T_SasanSai set data_sai = @data_sai, KategoriaId=@kategoriaId, ArmajenId = @armajenId,departementoID= @departementoId,Qtd= @Qtd 
	WHERE Id = @id

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE  ArmajenId = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM(Qtd) from T_SasanSai wHERE  ArmajenId = @armajenId)
			WHERE  ArmajenId= @armajenId
		END
END

