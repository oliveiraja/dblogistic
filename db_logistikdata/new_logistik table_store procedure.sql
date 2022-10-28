use LIS


--tabela rai lista sasan
create table dbo.T_Sasan(
Id int identity(1,1)constraint pk_t_sasan_id primary key,
Naran varchar(100))


--store procedure
--uspviewsasan
drop procedure dbo.usp_vwSasan 
CREATE PROCEDURE usp_T_Sasan_View
AS
BEGIN
SELECT Id[Id],Naran[Naran] from dbo.T_Sasan
END
--INSERT

CREATE PROCEDURE usp_T_Sasan_Insert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Sasan(Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_Sasan_Update
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Sasan set Naran = @naran
	WHERE Id= @id
END

--DELETE
drop procedure usp_T_SasanDelete
CREATE PROCEDURE usp_T_SasanDelete
@id int
AS
BEGIN
	DELETE from T_Sasan where Id= @id
END

--tabela rai lista supplier
create table dbo.T_Supplier(
Id int identity(1,1)constraint pk_t_supplier_id primary key,
Naran varchar(100))


--VIEW
CREATE VIEW dbo.vwSupplier
as select Id[Id],Naran[Naran] from dbo.T_Supplier

--store procedure
--uspviewsasan
drop procedure dbo.usp_vwSupplier
CREATE PROCEDURE usp_T_Sasan_View
AS
BEGIN
SELECT Id[Id],Naran[Naran] from dbo.T_Sasan
END
--INSERT

CREATE PROCEDURE usp_T_SupplierInsert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Supplier (Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_SupplierUpdate
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Supplier set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_SupplierDelete
@id int
AS
BEGIN
	DELETE from T_Supplier where Id= @id
END

--uspviewsasan
CREATE PROCEDURE usp_vwSupplier
AS
BEGIN
SELECT * FROM vwSupplier
END

--tabela rai lista departementos
create table dbo.T_Departemento(
Id int identity(1,1)constraint pk_t_departemento_id primary key,
Naran varchar(100))

--VIEW
CREATE VIEW dbo.vwDepartemento
as select Id[Id],Naran[Naran] from dbo.T_Departemento

--store procedure

--INSERT

CREATE PROCEDURE usp_T_DepartementoInsert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Departemento(Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_DepartementoUpdate
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Departemento set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_DepartementoDelete
@id int
AS
BEGIN
	DELETE from T_Departemento where Id= @id
END

--uspviewdepartemento
CREATE PROCEDURE usp_vwDepartemento
AS
BEGIN
SELECT * FROM vwDepartemento
END

--tabela rai lista armajen
create table dbo.T_Armajen(
Id int identity(1,1)constraint pk_t_armajen_id primary key,
Naran varchar(100))

--VIEW

CREATE VIEW dbo.vwArmajen
as select Id[Id],Naran[Naran] from dbo.T_Armajen

--store procedure

--INSERT

CREATE PROCEDURE usp_T_ArmajenInsert
@naran varchar(100)

AS
BEGIN
	INSERT INTO T_Armajen(Naran)
	values (@naran)
END

--UPDATE

CREATE PROCEDURE usp_T_ArmajenUpdate
@id int,@naran varchar(100)

AS
BEGIN
	UPDATE T_Armajen set Naran = @naran
	WHERE Id= @id
END

--DELETE

CREATE PROCEDURE usp_T_ArmajenDelete
@id int
AS
BEGIN
	DELETE from T_Armajen where Id= @id
END

--uspviewarmajen
CREATE PROCEDURE usp_vwArmajen
AS 
BEGIN
SELECT * FROM vwArmajen
END


--tabela rai lista sasan tama
create table dbo.T_SasanTama(
Id int identity(1,1)constraint pk_t_sasantama_id primary key,
data_tama date,
supplierID int,
sasanID int,
Presu decimal(10,2),
Qtd int,
Total as Qtd * Presu,
armajenID int)

--VIEW

ALTER VIEW dbo.vwSasanTama
as select Id[Id],data_tama [Data Tama],supplierID[Supplier ID],sasanID[Sasan ID],Presu[Presu],Qtd[Quantidade],Total[Total],armajenID[Armajen ID] from dbo.T_SasanTama

create proc dbo.usp_T_SasanTama_View

--store procedure

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


ALTER PROCEDURE usp_T_SasanTama_Update
@id int,
@data_tama date,
@supplierID int,
@sasanID int,
@presu DECIMAL(10,2),
@qtd int,
@armajenID int

AS
BEGIN
	UPDATE T_SasanTama set data_tama =@data_tama, supplierID=@supplierID,sasanID=@sasanID,Presu=@presu,Qtd =@qtd,armajenID=@armajenID
	WHERE Id = @id
	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM(Qtd) from T_SasanTama wHERE sasanID = @sasanId AND armajenID = @armajenId)
			WHERE sasanID = @sasanId AND armajenID = @armajenId
		END
END

SELECT * FROM T_ArmajenStock WHERE sasanID = 1 AND armajenID = 3

--DELETE
drop proc usp_T_SasanTamaDelete
alter PROCEDURE usp_T_SasanTama_Delete
@id int,@sasanID int,@armajenID int
AS
BEGIN
	DELETE from T_SasanTama where Id= @id
	IF EXISTS (SELECT * FROM T_ArmajenStock WHERE sasanID = @sasanId AND armajenID = @armajenId)
		BEGIN
			UPDATE T_ArmajenStock set qtd_tama = (SELECT SUM (qtd) from T_SasanTama
			WHERE sasanID = @sasanId AND armajenID = @armajenId)
		END
END

drop proc usp_vwSasanTama
CREATE PROCEDURE usp_T_SasanTama_View
AS
BEGIN
SELECT * FROM vwSasanTama
END


--tabela informasaun armajen
truncate table dbo.T_SasanTama
drop table dbo.T_ArmajenStock
create table dbo.T_ArmajenStock(
Id int identity(1,1)constraint pk_armajenstock_id primary key,
armajenID int,
sasanID int,
qtd_tama int default 0,
qtd_sai int default 0,
qtd_atual as qtd_tama - qtd_sai)


--view armajenstock
CREATE VIEW dbo.T_ArmajenStock
AS SELECT Id[ID],armajenID [Armajen ID],sasanID [Sasan ID],qtd_tama [Quantidade Tama],qtd_sai [Quantidade Sai],qtd_atual [Quantidade Atual] from dbo.T_ArmajenStock

--store procedure

--usp view
drop proc usp_vwArmajenStock
CREATE PROCEDURE usp_T_ArmajenStock_View
AS 
BEGIN
SELECT * FROM vwArmajenStock
END


--tabela rai lista sasan sai
create table dbo.T_SasanSai(
Id int identity(1,1)constraint pk_sasansai_id primary key,
data_sai date,
armajenID int,
departementoID int,
sasanID int,
Qtd int)

--view
CREATE VIEW dbo.vwSasanSai
AS SELECT iD[ID],data_sai [Data Sai],armajenID [Armajen Id],departementoID [Departemento Id],sasanID [Sasan Id],Qtd [Quantidade] from T_SasanSai

--store procedure
--view
CREATE  PROCEDURE usp_T_SasanSai_View
AS
BEGIN
SELECT * FROM vwSasanSai
END

--INSERT
CREATE PROCEDURE usp_T_SasanSai_Insert
@data_sai date,@armajenID int,@departementoID int,@sasanID int,@Qtd int
AS
BEGIN
INSERT INTO dbo.T_SasanSai (data_sai,armajenID,departementoID,sasanID,Qtd)
			values (@data_sai ,@armajenID ,@departementoID ,@sasanID ,@Qtd) 
END


--update
CREATE PROCEDURE usp_T_SasanSai_Update
@id int,
@data_sai date,@Qtd int
AS
BEGIN
UPDATE dbo.T_SasanSai set data_sai = @data_sai, Qtd = @Qtd 
			where Id = @id
END

--delete
CREATE PROCEDURE usp_T_SasanSai_Delete
@id int
AS
BEGIN
DELETE from T_SasanSai where Id = @id
END