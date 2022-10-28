use LogistikData

--tabela rai lista sasan
create table dbo.Sasans(
sasanID int identity(1,1)constraint pk_sasans_sasanid primary key,
Sasan varchar(100))


--tabela rai lista supplier
create table dbo.Suppliers(
supplierID int identity(1,1)constraint pk_suppliers_supplierid primary key,
Supplier varchar(100))

--tabela rai lista departementos
create table dbo.Departementos(
departementoID int identity(1,1)constraint pk_departementos_departementoid primary key,
Departemento varchar(100))

--tabela rai lista armajen
create table dbo.Armajens(
armajenID int identity(1,1)constraint pk_armajens_armajenid primary key,
Armajen varchar(100))

--tabela rai lista sasan tama
create table Sasan_Tama(
Ids int identity(1,1)constraint pk_sasan_tama_ids primary key,
data_tama date,
supplierID int,
sasanID int,
Presu int,
Qtd int,
Total int,
armajenID int)


--tabela informasaun armajen
create table dbo.Armajen(
Ids int identity(1,1)constraint pk_armajen_ids primary key,
armajenID int,
sasanID int,
qtd_tama int,
qtd_sai int,
qtd_atual as qtd_tama - qtd_sai)



--tabela rai lista sasan sai
create table dbo.Sasan_Sai(
Ids int identity(1,1)constraint pk_sasan_sai_ids primary key,
data_sai date,
armajenID int,
departementoID int,
sasanID int,
Qtd int)

