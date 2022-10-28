use LogistikData

create table dbo.Login(
logID int identity(1,1)constraint pk_Login_logid primary key,
username varchar(20),
password varchar(20))
select * from dbo.Login