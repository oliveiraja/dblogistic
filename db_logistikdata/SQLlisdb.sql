use lisdb

CREATE PROCEDURE dbo.T_Reset
AS
BEGIN
	truncate table dbo.T_SasanTama
	truncate table dbo.T_ArmajenStock
	truncate table dbo.T_SasanSai
END
exec usp_T_SasanSai_View

CREATE PROCEDURE dbo.T_Reset_Kategoria
AS
BEGIN
	TRUNCATE TABLE dbo.T_Kategoria
	TRUNCATE TABLE dbo.T_SubKategoria
	TRUNCATE TABLE dbo.T_Marka
	TRUNCATE TABLE dbo.T_Modelu
END	
Create table dbo.T_registo (
Id int identity (1,1) constraint pk_T_registo_id primary key,
NaranUsers varchar (50),
password varchar (50),
email varchar (50),
funsaun varchar (50))
drop table T_registo

--VIEW REGISTO
CREATE PROCEDURE usp_T_Registo_View
AS
BEGIN
	SELECT Id[ID],NaranUsers[NARAN_USER],password[PASSWORD] ,email[EMAIL],funsaun[FUNSAUN] FROM T_registo
END

--INSERT REGISTO
Create PROCEDURE usp_T_Registo_Insert
@Naranusers varchar (50),
@password varchar (50),
@email varchar (50),
@funsaun varchar(50)
AS
BEGIN
	INSERT INTO  dbo.T_registo(NaranUsers,password,email,funsaun)
	VALUES (@Naranusers,@password,@email,@funsaun)
END

--UPDATE REGISTO

Create PROCEDURE usp_T_Registo_Update
@Id int,
@Naranusers varchar (50),
@password varchar (50),
@email varchar (50),
@funsaun varchar(50)

AS
BEGIN
	UPDATE dbo.T_registo set NaranUsers = @Naranusers, password = @password,email = @email, funsaun = @funsaun
	WHERE Id = @Id
END


select * from dbo.T_SasanSai

--tabela T_Konidisaun Sasan
create table dbo.T_konidsaun_sasan(
Id int identity(1,1)constraint pk_t_kondisaunsasan_id primary key,
kondisaun_sasan varchar(50))

--store procedure
--uspviewsasan

create PROCEDURE usp_T_kondisaunSasan_View
AS
BEGIN
SELECT Id[Id],kondisaun_sasan[KONDISAUN_SASAN] from dbo. T_konidsaun_sasan
END
exec usp_T_kondisaunSasan_View

--INSERT

CREATE PROCEDURE usp_T_kondisaunsasan_Insert
@konisaun varchar(50)
AS
BEGIN
	INSERT INTO T_kondisaun_sasan(kondisaun_sasan)
	values (@konisaun)
END
Insert into dbo.T_konidsaun_sasan(kondisaun_sasan)
values ('Diak'),('At'),('Rasuavel')

--UPDATE

CREATE PROCEDURE usp_T_kondisaun_sasan_Update
@id int,@kondisaun_sasan varchar(50)
AS
BEGIN
	UPDATE T_kondisaun_sasan set kondisaun_sasan = @kondisaun_sasan
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_Sasan_Delete
@id int
AS
BEGIN
	DELETE from T_Sasan where Id= @id
END

--tabela rai lista supplier
create table dbo.T_Supplier(
Id int identity(1,1)constraint pk_t_supplier_id primary key,
Naran varchar(100))

insert into  dbo.T_Supplier (Naran)
values ('MR BROWN'),('DEALER')


CREATE PROCEDURE usp_T_Supplier_View
AS
BEGIN
SELECT Id[Id],Naran[Naran] from dbo.T_Supplier
END
--INSERT

CREATE PROCEDURE usp_T_Supplier_Insert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Supplier (Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_Supplier_Update
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Supplier set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_Supplier_Delete
@id int
AS
BEGIN
	DELETE from T_Supplier where Id= @id
END


--CREATE KODIGO TABEL
create table dbo.T_Kodigo(
Id int identity(1,1)constraint pk_t_kodigo_id primary key,
Kodigo int)

CREATE PROCEDURE usp_T_Kodigo_View
AS
BEGIN
SELECT Id[Id],Kodigo[KODIGO] from dbo.T_Kodgo
END


CREATE PROCEDURE usp_T_Kodigo_Insert
@Kodigo int

AS
BEGIN
	INSERT INTO T_Kodigo (Kodigo)
	values (@Kodigo)
END

CREATE PROCEDURE usp_T_Kodigo_Update
@id int,@kodigo varchar(100)

AS
BEGIN
	UPDATE T_Kodigo set Kodigo = @kodigo
	WHERE Id= @id
END





--store procedure
--uspviewsupplier


--tabela rai lista departemento
CREATE TABLE dbo.T_Departemento(
Id int identity(1,1)constraint pk_t_departemento_id primary key,
Naran varchar(100))

--store procedure
--uspviewsasan
drop procedure usp_T_Departemento_View
CREATE PROCEDURE usp_T_Departemento_View
AS
BEGIN
SELECT Id[Id],Naran[Naran] from dbo.T_Departemento
END
--INSERT

CREATE PROCEDURE usp_T_Departemento_Insert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Departemento(Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_Departemento_Update
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Departemento set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_Departemento_Delete
@id int
AS
BEGIN
	DELETE from T_Departemento where Id= @id
END

--tabela rai lista armajen
CREATE TABLE dbo.T_Armajen(
Id int identity(1,1)constraint pk_t_armajen_id primary key,
Naran varchar(100))

insert into  dbo.T_Armajen(Naran)
values ('INSS'),('ARMAJEN INSS')

--store procedure
--uspviewsasan

CREATE PROCEDURE usp_T_Armajen_View
AS
BEGIN
SELECT Id[Id],Naran[Naran] from dbo.T_Armajen
END
--INSERT

CREATE PROCEDURE usp_T_Armajen_Insert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Armajen(Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_Armajen_Update
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Armajen set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_Armajen_Delete
@id int
AS
BEGIN
	DELETE from T_Armajen where Id= @id
END

--tabela rai lista sasan tama
drop table dbo.T_SasanTama
CREATE TABLE dbo.T_SasanTama(
Id int identity(1,1)constraint pk_t_sasantama_id primary key,
Kodigo int,
Data_Tama date,
SupplierId int,
SasanId int,
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
observasaun varchar(50),
kondisaun_sasan int,
Qtd int,
Presu decimal(10,2),
Total as Qtd * Presu,
compname varchar(30),
ipcomp varchar(30),
ArmajenId int)


--VIEW

CREATE VIEW dbo.vwSasanTama
as select Id[Id],data_tama [Data_Tama],supplierID[Supplier ID],sasanID[Sasan ID],Presu[Presu],Qtd[Quantidade],Total[Total],armajenID[Armajen ID] from dbo.T_SasanTama

create proc dbo.usp_T_SasanTama_View


--store procedure
--uspviewsasan
drop proc usp_T_SasanTama_View
Create PROCEDURE usp_T_SasanTama_View
AS
BEGIN
SELECT T1.Id[Id],T1.Data_Tama[DATA_TAMA],T2.Naran[SUPPLIER],T4.Naran[KATEGORIA],
T5.Naran [SUBKATEGORIA],T6.Naran [MARKA],T7.Naran [MODELU], T1.kondisaun_sasan[KONDISAUN_SASAN],T1.observasaun[OBSERVASAUN],
T1.Qtd[QUANTIDADE],T1.Presu[PRESU],T1.Total[TOTAL],T8.Naran[ARMAJEN]
from dbo.T_SasanTama T1
INNER JOIN T_Supplier T2 ON T1.supplierID=T2.Id
--INNER JOIN T_Sasan T3 ON T1.sasanId=T3.Id
INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
INNER JOIN T_Armajen T8 ON T1.ArmajenId=T8.Id
END

--INSERT
drop proc usp_T_SasanTama_Insert
CREATE PROCEDURE usp_T_SasanTama_Insert
@data_tama date,
@supplierId int,
@sasanId int,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@observasaun varchar(50),
@kondisaun_sasan int,
@modeluId int,
@qtd int, 
@presu decimal(10,2),
@armajenId int

AS
BEGIN
	INSERT INTO T_SasanTama(Data_Tama,SupplierId,KategoriaId,SubKategoriaId,MarkaId,ModeluId ,Qtd,Presu,ArmajenId)
	VALUES (@data_tama,@supplierId,@sasanId,@kategoriaId,@subkategoriaId,@markaId,@modeluId,@qtd,@presu,@armajenId)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE SasanId=@sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE SasanId = @sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)			
		END
		
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (ArmajenId,SasanId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,qtd_tama)
		 VALUES (@armajenId,@sasanId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)
		END
END

exec usp_T_SasanTama_View

select * from T_SasanTama
--UPDATE
drop proc usp_T_SasanTama_Update
CREATE PROCEDURE usp_T_SasanTama_Update
@id int,
@data_tama date,
@supplierId int,
@sasanId int,
@kategoriaId int,
@subkategoriaId int,
@markaId int,
@modeluId int,
@qtd int, 
@presu decimal(10,2),
@armajenId int,
@sasanIdtuan int

AS
BEGIN
	UPDATE T_SasanTama set Data_Tama =@data_tama, SupplierId=@supplierId,SasanId=@sasanId,KategoriaId=@kategoriaId,SubKategoriaId=@subkategoriaId,MarkaId=@markaId,ModeluId=@modeluId,Presu=@presu,Qtd =@qtd,armajenID=@armajenID
	WHERE Id = @id
	IF NOT EXISTS (SELECT * FROM T_ArmajenStock WHERE SasanId=@sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenID = @armajenId)
		BEGIN
			
			INSERT INTO T_ArmajenStock (ArmajenId,SasanId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,qtd_tama)
			VALUES (@armajenId,@sasanId,@kategoriaId,@subkategoriaid,@markaId,@modeluId,@qtd)

			--UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE SasanId = @sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)
			--WHERE SasanId = @sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND ArmajenId = @armajenId

			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanIdtuan AND armajenID = @armajenId)
			WHERE sasanID = @sasanIdtuan AND armajenID = @armajenId

		
		END
	ELSE
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE SasanId = @sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId)
			WHERE SasanId = @sasanId and KategoriaId = @kategoriaId and SubKategoriaId =@subkategoriaId and MarkaId = @markaId and ModeluId=@modeluId AND armajenId = @armajenId
			--UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanIdtuan AND armajenID = @armajenId)
			--WHERE sasanID = @sasanIdtuan AND armajenID = @armajenId
		END

END


--DELETE

ALTER PROCEDURE usp_T_SasanTama_Delete
@id int,@sasanID int,@armajenID int--,@msg varchar(50) output
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM T_SasanTama WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			DELETE from T_SasanTama where Id= @id
			IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
				BEGIN
					UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (qtd) from T_SasanTama
					WHERE sasanID = @sasanId AND armajenID = @armajenId)
				END
			DECLARE @X1 INT
			SET @X1 = (SELECT qtd_tama FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
			IF @X1 IS NULL
				BEGIN
					UPDATE T_ArmajenStock set qtd_tama=0 WHERE sasanID = @sasanId AND armajenID = @armajenId
				END
		END
	--ELSE
		--BEGIN
			--SET @msg = 'LABELE DELETE'
		--END
END


--tabela informasaun armajen
drop table dbo.T_ArmajenStock
CREATE TABLE dbo.T_ArmajenStock(
Id int identity(1,1)constraint pk_armajenstock_id primary key,
ArmajenId int,
SasanId int,
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
kondisaun_sasan varchar(50),
observasaun varchar(50),
qtd_tama int default 0,
qtd_sai int default 0,
qtd_atual as qtd_tama - qtd_sai)


select * from dbo.T_ArmajenStock
--store procedure
--view armajenstock
drop proc usp_T_ArmajenStock_View
CREATE PROCEDURE usp_T_ArmajenStock_View
AS 
BEGIN
		SELECT T1.Id[Id],T2.Naran[ARMAJEN],T4.Naran[KATEGORIA],T5.Naran[SUBKATEGORIA],T6.Naran[MARKA],T7.Naran[MODELU],  T1.kondisaun_sasan[KONDISAUN],T1.observasaun[OBSERVASAUN], T1.qtd_tama [QUANTIDADE_TAMA],T1.qtd_sai [QUANTIDADE_SAI],T1.qtd_atual [QUANTIDADE_ATUAL] 
		from dbo.T_ArmajenStock T1
		INNER JOIN T_Armajen T2 ON T1.ArmajenId=T2.Id
		--INNER JOIN T_Sasan T3 ON T1.SasanId=T3.Id
		INNER JOIN T_Kategoria T4 ON T1.KategoriaId=T4.Id
		INNER JOIN T_SubKategoria T5 ON T1.SubKategoriaId=T5.Id
		INNER JOIN T_Marka T6 ON T1.MarkaId=T6.Id
		INNER JOIN T_Modelu T7 ON T1.ModeluId=T7.Id
END

create PROC usp_T_ArmajenStock_Sasan
@sasanid int
AS
BEGIN
SELECT DISTINCT T1.sasanID[ID],T2.Naran[NARAN] FROM dbo.T_ArmajenStock T1 
INNER JOIN T_Kategoria T2 ON T1.sasanID = T2.Id 
where sasanID=@sasanid
END

exec usp_T_ArmajenStock_Armajen 1
exec usp_T_ArmajenStock_Sasan

CREATE PROC usp_T_ArmajenStock_Armajen
AS
BEGIN
SELECT DISTINCT T1.armajenID[ID],T2.Naran[NARAN] FROM dbo.T_ArmajenStock T1
INNER JOIN T_Armajen T2 ON T1.armajenID = T2.Id
END

--tabela rai lista sasan sai
drop table dbo.T_SasanSai
CREATE TABLE dbo.T_SasanSai(
Id int identity(1,1)constraint pk_sasansai_id primary key,
Data_Sai date,
ArmajenId int,
DepartementoId int,
SasanId int,
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
Qtd int)


--store procedure
--view
drop proc usp_T_SasanSai_View
CREATE  PROCEDURE usp_T_SasanSai_View
AS
BEGIN
SELECT T1.Id[ID],T1.Data_Sai[DATA_SAI],
T2.Naran[ARMAJEN],
T3.Naran[DEPARTEMENTO],
T5.Naran[KATEGORIA],T6.Naran[SUBKATEGORIA],T7.Naran[MARKA],T8.Naran[MODELU],
T1.Qtd[QUANTIDADE]
FROM T_SasanSai T1 
INNER JOIN T_Armajen T2 ON T1.ArmajenId=T2.Id
INNER JOIN T_Departemento T3 ON T1.DepartementoId=T3.Id
--INNER JOIN T_Sasan T4 ON T1.SasanId=T4.Id
INNER JOIN T_Kategoria T5 ON T1.KategoriaId=T5.Id
INNER JOIN T_SubKategoria T6 ON T1.SubKategoriaId=T6.Id
INNER JOIN T_Marka T7 ON T1.MarkaId=T7.Id
INNER JOIN T_Modelu T8 ON T1.ModeluId=T8.Id
END

--INSERT
drop proc usp_T_SasanSai_Insert
CREATE PROCEDURE usp_T_SasanSai_Insert
@data_sai date,@armajenId int,@departementoId int,@sasanId int,@kategoriaId int,
@subKategoriaId int,
@markaId int,
@modeluId int, @Qtd int,@msg varchar(100) output 
AS
BEGIN
	IF @Qtd <= (SELECT SUM (qtd_atual) from T_ArmajenStock where SasanId = @sasanId AND KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId  AND ArmajenId = @armajenId)
		BEGIN
			INSERT INTO dbo.T_SasanSai (Data_Sai,ArmajenId,DepartementoId,SasanId,KategoriaId,SubKategoriaId,MarkaId,ModeluId,Qtd)
			VALUES (@data_sai ,@armajenId ,@departementoId ,@sasanId,@kategoriaId,@subKategoriaId,@markaId,@modeluId, @Qtd) 


			IF EXISTS (SELECT * FROM T_ArmajenStock WHERE SasanId = @sasanId AND KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId)
				BEGIN
					UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM (Qtd) from T_SasanSai WHERE SasanId = @sasanId AND KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId)
					WHERE SasanId = @sasanId AND KategoriaId = @kategoriaId AND SubKategoriaId =@subkategoriaId AND MarkaId = @markaId AND ModeluId=@modeluId AND ArmajenId = @armajenId
				END
		END
		ELSE
			BEGIN
				SET @msg = 'Quantidade Sasan Bot Liu'
			END
END

--update

CREATE PROCEDURE usp_T_SasanSai_Update
@id int,@data_sai date,@armajenId int,@departementoId int,@sasanId int,@Qtd int
AS
BEGIN
	UPDATE T_SasanSai set data_sai = @data_sai,armajenID = @armajenId,departementoID= @departementoId,sasanID=@sasanId,Qtd= @Qtd 
	WHERE Id = @id

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM(Qtd) from T_SasanSai wHERE sasanID = @sasanId AND armajenID = @armajenId)
			WHERE sasanId = @sasanId AND armajenID = @armajenId
		END
END

--delete
drop procedure usp_T_SasanSai_Delete
CREATE PROCEDURE usp_T_SasanSai_Delete
@id int,@armajenId int,@departementoId int,@sasanID int
AS
BEGIN
	DELETE from T_SasanSai where Id= @id
	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_sai = (SELECT SUM (Qtd) from T_SasanSai
			WHERE sasanID = @sasanId AND armajenID = @armajenId)
			WHERE sasanID = @sasanId AND armajenID = @armajenId
		END
	DECLARE @X1 INT
	SET @X1 = (SELECT qtd_sai FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
	IF @X1 IS NULL
		BEGIN
			UPDATE T_ArmajenStock set qtd_sai=0 WHERE sasanID = @sasanId AND armajenID = @armajenId
		END
END



--table kategoria
drop table T_Kategoria
CREATE TABLE dbo.T_Kategoria(
Id int identity (1,1)constraint pk_tkategoria_id primary key,
--Kodigo int,
Naran varchar(50))

--VIEW KATEGORI
Alter PROCEDURE usp_T_Kategoria_View
AS
BEGIN
SELECT Id[Id], Naran[KATEGORIA] from dbo.T_Kategoria
END


--Insert
Alter PROC usp_T_Kategoria_Insert
@naran varchar(50)
--@kodigo int
AS
BEGIN
	INSERT INTO dbo.T_Kategoria (Naran)values(@naran)
END
--update
Alter PROC usp_T_Kategoria_Update
@id int, @naran varchar(50)
AS
BEGIN
	UPDATE dbo.T_Kategoria SET Kodigo= Naran=@naran where Id=@id
END

--Select
drop proc usp_T_Kategoria
CREATE PROC usp_T_Kategoria
AS
BEGIN
	SELECT * from dbo.T_Kategoria 
END


select * from T_Kategoria  
--view
drop proc usp_T_Kategoria_View

SELECT * FROM usp_T_Kategoria_View
exec usp_T_Kategoria_View


--table subkategoria
drop table T_subKategoria
CREATE TABLE dbo.T_SubKategoria(
Id int identity(1,1)constraint pk_tsubkategoria_id Primary key,
KategoriaId int constraint fk_tsubkategoria_id references T_Kategoria(Id),
Naran varchar(50))

--Insert
CREATE PROC usp_T_SubKategoria_Insert
@naran varchar(50),@kategoriaId int
AS
BEGIN
	INSERT INTO dbo.T_SubKategoria (KategoriaId,Naran) values (@kategoriaId,@naran)
END

--update
CREATE PROC usp_T_SubKategoria_Update
@id int,@kategoriaId int, @naran varchar(50)
AS
BEGIN
	UPDATE dbo.T_SubKategoria SET Naran=@naran where Id=@id
END

select * from T_SubKategoria
--Select
CREATE PROC usp_T_SubKategoria 
@id int
AS
BEGIN
	SELECT * from T_SubKategoria where KategoriaId=@id
END

--vIEW
exec dbo.usp_T_SubKategoria_View
exec dbo.usp_T_SubKategoria_ViewID '1'
CREATE PROC dbo.usp_T_SubKategoria_View
AS
BEGIN
		SELECT T1.Id[ID],T2.Naran[KATEGORIA],T1.Naran[SUB KATEGORIA] FROM dbo.T_SubKategoria T1  
		INNER JOIN T_Kategoria T2 ON T1.KategoriaId=T2.Id
END	

CREATE PROC dbo.usp_T_SubKategoria_ViewID
@kategoriaId int
AS
BEGIN
	SELECT T1.Id[ID],T2.Naran[KATEGORIA],T1.Naran[SUB KATEGORIA]
	from T_SubKategoria T1
	inner Join T_Kategoria T2 on T1.KategoriaId=T2.Id
	where T1.KategoriaId=@kategoriaId
END

exec usp_T_SubKategoria_ViewID 1



insert into  T_SubKategoria (KategoriaId,Naran)
values (1,'Monitor'),(1,'UPS')


--table marka
drop table T_Marka
CREATE TABLE dbo.T_Marka(
Id int identity(1,1)constraint pk_tmarka_id Primary Key,
SubKategoriaId int constraint fk_tmarka_id references T_SubKategoria(Id),
Naran varchar(50))

--Insert
CREATE PROC usp_T_Marka_Insert
@subkategoriaId int, @naran varchar(50)
AS
BEGIN
	INSERT INTO dbo.T_Marka(SubKategoriaId,Naran)values(@subkategoriaId,@naran)
END

--update
CREATE PROC usp_T_Marka_Update
@id int,@naran varchar(50)
AS
BEGIN
	UPDATE dbo.T_Marka SET Naran=@naran where Id=@id
END

--Select
CREATE PROC usp_T_Marka
@id int
AS
BEGIN
	SELECT * from T_Marka where SubKategoriaId=@id
END

--vIEW
CREATE PROC dbo.usp_T_Marka_View
AS
BEGIN
	SELECT T1.Id[ID],T2.Naran[SUBKATEGORIA],T1.Naran[MARKA]
	from T_Marka T1
	inner Join T_SubKategoria T2 on T1.SubKategoriaId=T2.Id
END

exec usp_T_Marka_View 

CREATE PROC dbo.usp_T_Marka_ViewID
@subkategoriaId int
AS
BEGIN
	SELECT T1.Id[ID],T2.Naran[SUBKATEGORIA],T1.Naran[MARKA] 
	FROM dbo.T_Marka T1
	INNER JOIN T_SubKategoria T2 ON T1.SubKategoriaId=T2.Id
	WHERE T1.SubKategoriaId=@subkategoriaId 
END

exec usp_T_Marka_ViewID 1

drop table T_Modelu
--table modelu
CREATE TABLE dbo.T_Modelu(
Id int identity(1,1)constraint pk_tmodelu_id primary key,
MarkaId int constraint fk_tmodelu_id references T_Marka(Id),
Naran varchar(50))

--Insert
CREATE PROC usp_T_Modelu_Insert
@markaId int,@naran varchar(50)
AS
BEGIN
	INSERT INTO dbo.T_Modelu(MarkaId,Naran)values(@markaId,@naran)
END

--update
CREATE PROC usp_T_Modelu_Update
@id int,@naran varchar(50)
AS
BEGIN
	UPDATE dbo.T_Modelu SET Naran=@naran where Id=@id
END

--Select
CREATE PROC usp_T_Modelu
@id int
AS
BEGIN
	SELECT * from T_Modelu where MarkaId=@id
END

--vIEW
CREATE PROC dbo.usp_T_Modelu_View
AS
BEGIN
	SELECT T1.Id[ID],T2.Naran[MARKA],T1.Naran[MODELU]
	from T_Modelu T1
	inner Join T_Marka T2 on T1.MarkaId=T2.Id
END

exec usp_T_Modelu_View 


CREATE PROC dbo.usp_T_Modelu_ViewID
@markaId int
AS
BEGIN
	SELECT T1.Id[ID],T2.Naran[MARKA],T1.Naran[MODELU]
	FROM dbo.T_Modelu T1
	INNER JOIN T_Marka T2 ON T1.MarkaId=T2.Id
	WHERE T1.MarkaId=@markaId
END	

exec usp_T_Modelu_ViewID 1
--NEW SASAN TAMA

CREATE TABLE dbo.T_SasanTama1(
Id int identity(1,1)constraint pk_t_sasantama_id primary key,
Data_Tama date,
SupplierID int,
KategoriaId int,
SubKategoriaId int,
MarkaId int,
ModeluId int,
Qtd int,
Presu decimal(10,2),
Total as Qtd * Presu,
ArmajenID int)

select * from dbo.T_SasanTama1
--VIEW

ALTER VIEW dbo.vwSasanTama
as select Id[Id],data_tama [Data_Tama],supplierID[Supplier ID],sasanID[Sasan ID],Presu[Presu],Qtd[Quantidade],Total[Total],armajenID[Armajen ID] from dbo.T_SasanTama

create proc dbo.usp_T_SasanTama_View


--store procedure
--uspviewsasan

ALTER PROCEDURE usp_T_SasanTama_View
AS
BEGIN
SELECT Id[Id],data_tama[Data_Tama],supplierId[Supplier Id],sasanId[Sasan Id],
presu[Presu],Qtd[Quantidade],Total[Total],armajenId[Armajen Id] 
from dbo.T_SasanTama
END

--INSERT

ALTER PROCEDURE usp_T_SasanTama_Insert
@data_tama date,
@supplierId int,
@sasanId int,
@presu decimal(10,2),
@qtd int, 
@armajenId int

AS
BEGIN
	INSERT INTO T_SasanTama(data_tama,supplierID,sasanID,Presu,Qtd,armajenID)
	VALUES (@data_tama,@supplierId,@sasanId,@presu,@qtd,@armajenId)

	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (Qtd) from T_SasanTama
			WHERE sasanID = @sasanId AND armajenID = @armajenId)			
		END
	ELSE
		BEGIN
			INSERT INTO T_ArmajenStock (armajenID,sasanID,qtd_tama)
			VALUES (@armajenId,@sasanId,@qtd)
		END
END

--UPDATE
ALTER PROCEDURE usp_T_SasanTama_Update
@id int,
@data_tama date,
@supplierID int,
@sasanID int,
@presu DECIMAL(10,2),
@qtd int,
@armajenID int,
@sasanIDtuan int

AS
BEGIN
	UPDATE T_SasanTama set data_tama =@data_tama, supplierID=@supplierID,sasanID=@sasanID,Presu=@presu,Qtd =@qtd,armajenID=@armajenID
	WHERE Id = @id
	IF NOT EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			
			INSERT INTO T_ArmajenStock (armajenID,sasanID,qtd_tama)
			VALUES (@armajenId,@sasanId,@qtd)

			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanId AND armajenID = @armajenId)
			WHERE sasanID = @sasanId AND armajenID = @armajenId

			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanIdtuan AND armajenID = @armajenId)
			WHERE sasanID = @sasanIdtuan AND armajenID = @armajenId

		END
	ELSE
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanId AND armajenID = @armajenId)
			WHERE sasanID = @sasanId AND armajenID = @armajenId 
			--UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanIdtuan AND armajenID = @armajenId)
			--WHERE sasanID = @sasanIdtuan AND armajenID = @armajenId
		END

END
