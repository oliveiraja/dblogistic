create proc [dbo].[usp_transporteCHECK]
@Kodigo int
as
BEGIN
	SELECT TOP 1 Kodigo FROM T_transporte WHERE Kodigo=@Kodigo
END