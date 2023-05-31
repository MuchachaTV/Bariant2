use Bariant2
create table Client (id_Client int primary key not null, FIO varchar(60) not null, Login varchar(30) not null, Password varchar(30) not null, Role varchar(30) not null)

create table Admin (id_Admin int primary key not null, FIO varchar(60) not null, Login varchar(30) not null, Password varchar(30) not null, Role varchar(30) not null)

create table Menedger (id_Menedger int primary key not null, FIO varchar(60) not null, Login varchar(30) not null, Password varchar(30) not null, Role varchar(30) not null)