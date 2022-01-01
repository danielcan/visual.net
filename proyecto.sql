
use master 
if exists (select * from sys.databases where name = 'DB_Juzgado')
drop database DB_Juzgado

create database DB_Juzgado
on primary (
name = 'DB_Juzgado',
filename ='C:\database1\BD_Juzgado.mdf',
size=15 MB,
Maxsize= 200 MB,
filegrowth=20%)
log on (
name = 'BD_Juzgado_log',
filename ='C:\database1\BD_Juzgado3.ldf',
size=10 MB,
Maxsize= 70 MB,
filegrowth=5 MB)
go

use DB_Juzgado
go

Create Table TBL_Acusados(
Acu_Codigo int identity(1,1) not null,
Acu_Nombre varchar(50) not null,
Acu_Genero char(10) not null,
Acu_Estatura integer not null,
Acu_Peso integer,
Acu_Ciudad_nacimiento varchar(50),
Acu_Departamento_nacimiento varchar(25),
Acu_País_nacimiento varchar(25),
Acu_Edad integer not null,
Acu_fechaNacimiento date,
Acu_Nivel_educacion varchar(50),
Acu_Estado_Civil char(10),
Acu_Color_piel varchar(20),
Acu_Color_ojos varchar(20),
Acu_Color_pelo varchar(20),
Acu_Identidad varchar(13) unique,
Acu_Direccion varchar(20),
primary key(Acu_Codigo)
)
go 

create table TBL_Evidencias(
Evi_Codigo int identity(1,1) not null,
Evi_DescripcionCorta varchar(50),
Evi_DescripcionLarga varchar(100),
primary key(Evi_Codigo)
)
go 

create table TBL_Abogado(
Abo_Codigo int identity(1,1) not null,
Abo_nombre varchar(20),
Abo_sexo char(10),
Abo_NumeroColegiacion int,
Abo_TiempoEjercer integer,
Abo_Dirección varchar(25),
Abo_Identidad varchar(13),
primary key(Abo_Codigo) 
)
go

create table TBL_Fiscalia(
Fis_Codigo int identity(1,1) not null,
Fis_Nombre varchar(50),
Fis_Departamento varchar(50),
Fis_Dirección varchar(100),
Fis_ciudad varchar(50),
Fis_Encargado varchar(50),
primary key(Fis_Codigo)
)
go


create table TBL_AcuOcupacion(
Acu_Codigo int not null,
OcupAc_Ocupacion varchar(50),
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go

create table TBL_AcuTelefono(
Acu_Codigo int not null,
Acu_Telefono int,
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go 

create table TBL_AcuCorreo(
Acu_Codigo int not null,
Acu_Correo varchar(25)
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go


create table TBL_AcuFotos(
Acu_Codigo int not null,
Acu_Fotos varbinary(MAX) null,
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

create table TBL_AcuRasgos(
Acu_Codigo int not null,
Acu_Rasgo varchar(35) not null
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go

create table TBL_AcuHistorialCri(
Acu_Codigo int not null,
Acu_Historial varchar(200) not null,
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go

create table TBL_AcuAlias(
Acu_Codigo int not null,
Acu_Alias varchar(25) not null,
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go



create table TBL_EviFotos(
Evi_Codigo int not null,
Evi_foto image not null,
foreign key(Evi_Codigo) references TBL_Evidencias(Evi_Codigo) on delete cascade
)
go

create table TBL_FisTelefono(
Fis_Codigo int,
Fis_telefono int,
foreign key(Fis_Codigo) references TBL_Fiscalia(Fis_Codigo) on delete cascade
)
go 

create table TBL_FisCorreo(
Fis_Codigo int,
correo varchar(20),
foreign key(Fis_Codigo) references TBL_Fiscalia(Fis_Codigo) on delete cascade
)
go

create table TBL_AbogTelefono(
Abo_Codigo int,
Abo_Telefono int,
foreign key(Abo_Codigo) references TBL_Abogado(Abo_Codigo) on delete cascade
)
go

create table TBL_AbogCorreo(
Abo_Codigo int,
Abo_correo varchar(25)
foreign key(Abo_Codigo) references TBL_Abogado(Abo_Codigo) on delete cascade
)
go

create table TBL_Delito(
Del_Codigo int identity(1,1) not null, 
Del_Nombre varchar(25) not null,
Del_NivelDelito char(25),
Del_Fianza float,
Del_PenaMaxima int,
primary key(Del_Codigo)
)
go

create table TBL_Expediente(
Exp_Nexpediente int identity(1,1) not null,
Exp_Especialidad varchar(25),
Exp_Etapa char(10),
Exp_CierreConclusión varchar(100),
Exp_FechaConclusión date,
Exp_FechaInicio date,
Exp_Estado char(15),
Fis_Codigo int,
Acu_Codigo int,
primary key(Exp_Nexpediente),
foreign key(Fis_Codigo) references TBL_Fiscalia(Fis_Codigo) on delete cascade,
foreign key(Acu_Codigo) references TBL_Acusados(Acu_Codigo) on delete cascade
)
go

create table TBL_ExObservaciones(
Exp_Nexpediente int not null,
ExpO_Observaciones varchar(100),
foreign key(Exp_Nexpediente) references TBL_Expediente(Exp_Nexpediente) on delete cascade
)
go

create table TBL_Vinculado(
Evi_Codigo int not null,
Exp_Nexpediente int not null,
primary key(Evi_Codigo,Exp_Nexpediente),
foreign key(Evi_Codigo) references TBL_Evidencias(Evi_Codigo) on delete cascade,
foreign key(Exp_Nexpediente) references TBL_Expediente(Exp_Nexpediente) on delete cascade
)
go


create table TBL_Asignan(
Abo_Codigo int not null,
Exp_Nexpediente int not null,
Asig_rol char(25),
primary key(Abo_Codigo,Exp_Nexpediente),
foreign key(Abo_Codigo) references TBL_Abogado(Abo_Codigo) on delete cascade,
foreign key(Exp_Nexpediente) references TBL_Expediente(Exp_Nexpediente) on delete cascade,
)
go

create table TBL_Tiene(
Exp_Nexpediente int not null,
Del_Codigo int not null,
primary key(Exp_Nexpediente,Del_Codigo),
foreign key(Del_Codigo) references TBL_Delito(Del_Codigo) on delete cascade,
foreign key(Exp_Nexpediente) references TBL_Expediente(Exp_Nexpediente) on delete cascade
)
go


set dateformat dmy;
insert into TBL_Acusados values ('Daniel Canales','Masculino','170','120','Tegucigalpa','Francisco Morazan','Honduras','20','05/05/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','1010553565','col 21 de octubre')
insert into TBL_Acusados values ('Maria Canales','Femenino','174','130','Tegucigalpa','Francisco Morazan','Honduras','20','05/03/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','1010253965','La san miguel')
insert into TBL_Acusados values ('Juan Perez','Masculino','175','140','San Pedro Sula','Cortes','Honduras','20','07/01/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0305646565','El cerro granda')
insert into TBL_Acusados values ('Marcos Sosa','Masculino','170','150','San Pedro Sula','Cortes','Honduras','20','08/04/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0101646565','El sitio')
insert into TBL_Acusados values ('Nicol Rodriguez','Femenino','176','160','Tegucigalpa','Francisco Morazan','Honduras','20','09/02/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0104646565','carizal')
insert into TBL_Acusados values ('Anna Rodriguez','Femenino','173','170','San Pedro Sula','Cortes','Honduras','20','07/07/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0105896765','alonso suazo')
insert into TBL_Acusados values ('Andrea Ramirez','Femenino','172','180','San Pedro Sula','Cortes','Honduras','20','02/06/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0205646565','pedregal')
insert into TBL_Acusados values ('Alex Sanchez','Masculino','171','190','Tegucigalpa','Francisco Morazan','Honduras','20','01/05/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','0405647565','alonzo suazo')
--insert into TBL_Acusados values ('jj Sanchez','Masculino','179','160','Tegucigalpa','Francisco Morazan','Honduras','20','01/05/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','090994756','alonzo suazo')
insert into TBL_Acusados values ('jjj Sanchez','Masculino','179','160','Tegucigalpa','Francisco Morazan','Honduras','20','01/05/2000','Secundaria Completa','casado','oscuro','cafes claro','negro','09000756','alonzo suazo')

insert into TBL_Evidencias values ('pistos con sangre','se encontraron pistolas con restos')
insert into TBL_Evidencias values ('cuchillos en la escena del crimen','cuchillos guardados en la mesa')
insert into TBL_Evidencias values ('cuchillos en la escena del crimen','evidencias del crimen')
insert into TBL_Evidencias values ('cuchillos en la escena del crimen','evidencias del crimen')
insert into TBL_Evidencias values ('pistos con sangre','evidencias del crimen')
insert into TBL_Evidencias values ('cuchillos en la escena del crimen','evidencias del crimen')
insert into TBL_Evidencias values ('cuchillos en la escena del crimen','evidencias del crimen')
insert into TBL_Evidencias values ('pistos con sangre','evidencias del crimen')

insert into TBL_Abogado values ('Daniel Canales','Masculino','658887','1','El pedregal','010877996544')
insert into TBL_Abogado values ('Maria Canales','Femenino','9876541','2','21 de octubre','010822996541')
insert into TBL_Abogado values ('Alejandro Canales','Masculino','9876543','3','San miguel','010833996542')
insert into TBL_Abogado values ('Jose Canales','Masculino','6549581','4','la sosa','010811194549')
insert into TBL_Abogado values ('Karla Canales','Femenino','3216874','5','La sosa','052815997542')
insert into TBL_Abogado values ('Lucia Canales','Femenino','2546879','6','EL carrizal','090765796571')
insert into TBL_Abogado values ('Naomy Canales','Femenino','1239877','7','El sitio','070415776582')
insert into TBL_Abogado values ('Jose Canales','Masculino','6543571','10','21 de octubre','020715896541')

insert into TBL_Fiscalia values ('Fiscalía Especial de la Niñez','Francisco Morazan','El centro','Tegucigalpa','Juan carcamo')
insert into TBL_Fiscalia values ('Fiscalía Especial de la Mujer','Francisco Morazan','El centro','Tegucigalpa','Daniel carcamo')
insert into TBL_Fiscalia values ('Fiscalía Especial de Derechos Humanos','Francisco Morazan','El centro','Tegucigalpa','Maria Rodriguez')
insert into TBL_Fiscalia values ('Fiscalía Especial de Etnias y Patrimonio Cultural','Francisco Morazan','El centro','Tegucigalpa','Luiz Rodriguez')
insert into TBL_Fiscalia values ('Fiscalía Especial para la Transparencia','Cortes','El centro','San Pedro Sula','Edgardo vargas')
insert into TBL_Fiscalia values ('Fiscalía Especial Contra el Crimen Organizado','Francisco Morazan','El centro','Tegucigalpa','Jorge Giron')
insert into TBL_Fiscalia values ('Fiscalía Especial del Consumidor y Tercera Edad','Atlantida','El centro','Ceiba','chang duron')
insert into TBL_Fiscalia values ('Fiscalía Especial de Enjuiciamiento Justicia','Francisco Morazan','El centro','Tegucigalpa','jacobo ismael salinas')

insert into TBL_AcuOcupacion values ('1','Mecanico')
insert into TBL_AcuOcupacion values ('2','Mecanico')
insert into TBL_AcuOcupacion values ('3','Electricista')
insert into TBL_AcuOcupacion values ('4','Mecanico')
insert into TBL_AcuOcupacion values ('5','Mecanico')
insert into TBL_AcuOcupacion values ('6','Mecanico')
insert into TBL_AcuOcupacion values ('7','Mecanico')
insert into TBL_AcuOcupacion values ('8','Mecanico')

insert into TBL_AcuTelefono values ('1','22311738')
insert into TBL_AcuTelefono values ('2','22312734')
insert into TBL_AcuTelefono values ('3','22393727')
insert into TBL_AcuTelefono values ('4','22386718')
insert into TBL_AcuTelefono values ('5','22386727')
insert into TBL_AcuTelefono values ('6','22376619')
insert into TBL_AcuTelefono values ('7','22346617')
insert into TBL_AcuTelefono values ('8','22326618')

insert into TBL_AcuCorreo values ('1','132@gmail.com')
insert into TBL_AcuCorreo values ('2','dna@gmail.com')
insert into TBL_AcuCorreo values ('3','ddd@hotmail.com')
insert into TBL_AcuCorreo values ('4','sss@gmail.com')
insert into TBL_AcuCorreo values ('5','aaa@gmail.com')
insert into TBL_AcuCorreo values ('6','ssa@yahoo.es')
insert into TBL_AcuCorreo values ('7','qqq@gmail.com')
insert into TBL_AcuCorreo values ('8','qwe@gmail.com')

insert into TBL_AcuRasgos values ('1','moreno')
insert into TBL_AcuRasgos values ('2','moreno')
insert into TBL_AcuRasgos values ('3','moreno')
insert into TBL_AcuRasgos values ('4','moreno')
insert into TBL_AcuRasgos values ('5','moreno')
insert into TBL_AcuRasgos values ('6','moreno')
insert into TBL_AcuRasgos values ('7','moreno')
insert into TBL_AcuRasgos values ('8','moreno')

insert into TBL_AcuHistorialCri values ('1','bebidas')
insert into TBL_AcuHistorialCri values ('2','portacion armas')
insert into TBL_AcuHistorialCri values ('3','portacion armas')
insert into TBL_AcuHistorialCri values ('4','portacion armas')
insert into TBL_AcuHistorialCri values ('5','portacion armas')
insert into TBL_AcuHistorialCri values ('6','portacion armas')
insert into TBL_AcuHistorialCri values ('7','portacion armas')
insert into TBL_AcuHistorialCri values ('8','portacion armas')

insert into TBL_AcuAlias values ('1','paquito1')
insert into TBL_AcuAlias values ('2','paquito2')
insert into TBL_AcuAlias values ('3','paquito3')
insert into TBL_AcuAlias values ('4','paquito4')
insert into TBL_AcuAlias values ('5','paquito5')
insert into TBL_AcuAlias values ('6','paquito6')
insert into TBL_AcuAlias values ('7','paquito7')
insert into TBL_AcuAlias values ('8','paquito8')

insert into TBL_FisTelefono values ('1','99781697')
insert into TBL_FisTelefono values ('2','92423999')
insert into TBL_FisTelefono values ('3','91413699')
insert into TBL_FisTelefono values ('4','93433899')
insert into TBL_FisTelefono values ('5','94483799')
insert into TBL_FisTelefono values ('6','97473299')
insert into TBL_FisTelefono values ('7','98493199')
insert into TBL_FisTelefono values ('8','99461891')

insert into TBL_FisCorreo values ('1','195@gmail.com')
insert into TBL_FisCorreo values ('2','195qwe@hotmail.com')
insert into TBL_FisCorreo values ('3','19qwedas5@gmail.com')
insert into TBL_FisCorreo values ('4','19asf5@yahoo.es')
insert into TBL_FisCorreo values ('5','1ghjghj95@gmail.com')
insert into TBL_FisCorreo values ('6','19ghjgh5@gmail.com')
insert into TBL_FisCorreo values ('7','19ytjty5@hotmail.com')
insert into TBL_FisCorreo values ('8','19tyutyu5@yahoo.es')

insert into TBL_AbogTelefono values ('1','22111111')
insert into TBL_AbogTelefono values ('2','22111111')
insert into TBL_AbogTelefono values ('3','22111111')
insert into TBL_AbogTelefono values ('4','22111111')
insert into TBL_AbogTelefono values ('5','22111111')
insert into TBL_AbogTelefono values ('6','22111111')
insert into TBL_AbogTelefono values ('7','22111111')
insert into TBL_AbogTelefono values ('8','22111111')

insert into TBL_AbogCorreo values ('1','195o1@gmail.com')
insert into TBL_AbogCorreo values ('2','195q987@hotmail.com')
insert into TBL_AbogCorreo values ('3','195q456@hotmail.com')
insert into TBL_AbogCorreo values ('4','195q354@hotmail.com')
insert into TBL_AbogCorreo values ('5','195ç12@hotmail.com')
insert into TBL_AbogCorreo values ('6','195q984@hotmail.com')
insert into TBL_AbogCorreo values ('7','195q987@hotmail.com')
insert into TBL_AbogCorreo values ('8','195q3527@hotmail.com')

insert into TBL_Delito values ('Extorsion','2','10000','25')
insert into TBL_Delito values ('asesinato p.g','2','10000','25')
insert into TBL_Delito values ('asesinato s.g','6','10000','25')
insert into TBL_Delito values ('Extorsion 1','8','10000','25')
insert into TBL_Delito values ('Extorsion 2','7','10000','25')
insert into TBL_Delito values ('Extorsion 3','9','10000','25')
insert into TBL_Delito values ('Extorsion 4','10','10000','25')
insert into TBL_Delito values ('Extorsion 5','14','10000','25')

insert into TBL_Expediente values ('crimen activo','cerrado','asesinato','02/05/2000','01/04/1999','cerrado','1','1')
insert into TBL_Expediente values ('crimen activo','juicio','aun en juicio','02/05/2000','01/04/1999','continua','2','2')
insert into TBL_Expediente values ('crimen activo','juicio','aun en juicio','02/05/2000','01/04/1999','continua','3','3')
insert into TBL_Expediente values ('crimen activo','cerrado','asesinato','02/05/2000','01/04/1999','cerrado','4','4')
insert into TBL_Expediente values ('crimen activo','juicio','aun en juicio','02/05/2000','01/04/1999','continua','5','5')
insert into TBL_Expediente values ('crimen activo','juicio','aun en juicio','02/05/2000','01/04/1999','continua','6','6')
insert into TBL_Expediente values ('crimen activo','juicio',' aun en juicio','02/05/2000','01/04/1999','continua','7','7')
insert into TBL_Expediente values ('crimen activo','cerrado','robo','02/05/2000','01/04/1999','cerrado','8','8')

insert into TBL_ExObservaciones values ('1','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('2','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('3','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('4','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('5','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('6','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('7','se encontraron objetos personales en la escena del crimen')
insert into TBL_ExObservaciones values ('8','se encontraron objetos personales en la escena del crimen')

insert into TBL_Vinculado values ('1','1')
insert into TBL_Vinculado values ('2','2')
insert into TBL_Vinculado values ('3','3')
insert into TBL_Vinculado values ('4','4')
insert into TBL_Vinculado values ('5','5')
insert into TBL_Vinculado values ('6','6')
insert into TBL_Vinculado values ('7','7')
insert into TBL_Vinculado values ('8','8')

insert into TBL_Asignan values ('1','1','Defensor')
insert into TBL_Asignan values ('2','2','Acusador')
insert into TBL_Asignan values ('3','3','Acusador')
insert into TBL_Asignan values ('4','4','Acusador')
insert into TBL_Asignan values ('5','5','Defensor')
insert into TBL_Asignan values ('6','6','Acusador')
insert into TBL_Asignan values ('7','7','Acusador')
insert into TBL_Asignan values ('8','8','Defensor')
insert into TBL_Asignan values ('8','1','Defensor')


insert into TBL_Tiene values ('1','1')
insert into TBL_Tiene values ('2','2')
insert into TBL_Tiene values ('3','3')
insert into TBL_Tiene values ('4','4')
insert into TBL_Tiene values ('5','5')
insert into TBL_Tiene values ('6','6')
insert into TBL_Tiene values ('7','7')
insert into TBL_Tiene values ('8','8')
insert into TBL_Tiene values ('8','1')

--Procedimiento almacenado de MOstrar de Acusado

      --primera forma
/*
create procedure mTBL_Acusados
as select s.Acu_Nombre, s.Acu_Genero,s.Acu_Estatura,s.Acu_Peso,s.Acu_Ciudad_nacimiento,s.Acu_Departamento_nacimiento,s.Acu_País_nacimiento,
s.Acu_Edad,s.Acu_fechaNacimiento,s.Acu_Nivel_educacion,s.Acu_Estado_Civil,s.Acu_Color_piel,s.Acu_Color_ojos,s.Acu_Color_pelo,s.Acu_Identidad,s.Acu_Direccion
from TBL_Acusados s order by s.Acu_Codigo desc
go
*/
      --segunda forma
create procedure mTBL_Acusados
as select * from TBL_Acusados  order by Acu_Codigo desc
go


create procedure mTBL_AcuOcupacion
as select * from TBL_AcuOcupacion order by Acu_Codigo desc
go


create procedure mTBL_AcuTelefono
as select * from TBL_AcuTelefono order by Acu_Codigo desc 
go


create procedure mTBL_AcuCorreo
as select * from TBL_AcuCorreo order by Acu_Codigo desc 
go

create procedure mTBL_AcuFotos
as select * from TBL_AcuFotos order by Acu_Codigo desc
go

create procedure mTBL_AcuRasgos
as select * from TBL_AcuRasgos order by Acu_Codigo desc 
go

create procedure mTBL_AcuHistorialCri
as select * from TBL_AcuHistorialCri order by Acu_Codigo desc
go 

create procedure mTBL_AcuAlias
as select * from TBL_AcuAlias order by Acu_Codigo desc
go 



--Procedimiento almacenado de Insercion Acusado
create procedure iTBL_Acusados
@Acu_Nombre varchar(50),
@Acu_Genero char(10),
@Acu_Estatura integer ,
@Acu_Peso integer,
@Acu_Ciudad_nacimiento varchar(50),
@Acu_Departamento_nacimiento varchar(25),
@Acu_País_nacimiento varchar(25),
@Acu_Edad integer,
@Acu_fechaNacimiento date,
@Acu_Nivel_educacion varchar(50),
@Acu_Estado_Civil char(10),
@Acu_Color_piel varchar(20),
@Acu_Color_ojos varchar(20),
@Acu_Color_pelo varchar(20),
@Acu_Identidad varchar(13),
@Acu_Direccion varchar(20)
as insert into TBL_Acusados
(Acu_Nombre,Acu_Genero,Acu_Estatura,Acu_Peso,Acu_Ciudad_nacimiento,Acu_Departamento_nacimiento,Acu_País_nacimiento,
Acu_Edad,Acu_fechaNacimiento,Acu_Nivel_educacion,Acu_Estado_Civil,Acu_Color_piel,Acu_Color_ojos,Acu_Color_pelo,Acu_Identidad,Acu_Direccion)
values
(@Acu_Nombre,@Acu_Genero,@Acu_Estatura,@Acu_Peso,@Acu_Ciudad_nacimiento,@Acu_Departamento_nacimiento,@Acu_País_nacimiento,
@Acu_Edad,@Acu_fechaNacimiento,@Acu_Nivel_educacion,@Acu_Estado_Civil,@Acu_Color_piel,@Acu_Color_ojos,@Acu_Color_pelo,@Acu_Identidad,@Acu_Direccion)
go

create procedure iTBL_AcuOcupacion
@OcupAc_Ocupacion varchar(50)
as insert into TBL_AcuOcupacion
(OcupAc_Ocupacion)
values
(@OcupAc_Ocupacion)
go 

create procedure iTBL_AcuTelefono
@Acu_Telefono int
as insert into TBL_AcuTelefono
(Acu_Telefono)
values
(@Acu_Telefono)
go 

create procedure iTBL_AcuCorreo
@Acu_Correo varchar(20)
as insert into TBL_AcuCorreo
(Acu_Correo)
values
(@Acu_Correo)
go


create procedure iTBL_AcuFotos
@Acu_Fotos varbinary(MAX)
as insert into TBL_AcuFotos
(Acu_Fotos)
values
(@Acu_Fotos)
go

create procedure iTBL_AcuRasgos
@Acu_Rasgo varchar(35)
as insert into TBL_AcuRasgos
(Acu_Rasgo)
values
(@Acu_Rasgo)
go

create procedure iTBL_AcuHistorialCri
@Acu_Historial varchar(200)
as insert into TBL_AcuHistorialCri
(Acu_Historial)
values
(@Acu_Historial)
go

create procedure iTBL_AcuAlias
@Acu_Alias varchar(25)
as insert into TBL_AcuAlias
(Acu_Alias)
values
(@Acu_Alias)
go


--Procedimiento de almacenado de actualización Acusado 

create procedure uTBL_Acusados
@Acu_Nombre varchar(50),
@Acu_Genero char(10),
@Acu_Estatura integer ,
@Acu_Peso integer,
@Acu_Ciudad_nacimiento varchar(70),
@Acu_Departamento_nacimiento varchar(25),
@Acu_País_nacimiento varchar(25),
@Acu_Edad integer,
@Acu_fechaNacimiento date,
@Acu_Nivel_educacion varchar(50),
@Acu_Estado_Civil char(10),
@Acu_Color_piel varchar(20),
@Acu_Color_ojos varchar(20),
@Acu_Color_pelo varchar(20),
@Acu_Identidad varchar(13),
@Acu_Direccion varchar(20)
as update TBL_Acusados set
Acu_Nombre=@Acu_Nombre,
Acu_Genero=@Acu_Genero,
Acu_Estatura=@Acu_Estatura,
Acu_Peso=@Acu_Peso,
Acu_Ciudad_nacimiento = @Acu_Ciudad_nacimiento,
Acu_Departamento_nacimiento=@Acu_Departamento_nacimiento,
Acu_País_nacimiento=@Acu_País_nacimiento,
Acu_Edad=@Acu_Edad,
Acu_fechaNacimiento=@Acu_fechaNacimiento,
Acu_Nivel_educacion=@Acu_Nivel_educacion,
Acu_Estado_Civil=@Acu_Estado_Civil,
Acu_Color_piel=@Acu_Color_piel,
Acu_Color_ojos=@Acu_Color_ojos,
Acu_Color_pelo=@Acu_Color_pelo,
Acu_Identidad=@Acu_Identidad,
Acu_Direccion=@Acu_Direccion 
where 
Acu_Nombre = @Acu_Nombre
go

create procedure uTBL_AcuOcupacion
@Acu_Codigo int,
@OcupAc_Ocupacion varchar(50)
as update  TBL_AcuOcupacion set 
OcupAc_Ocupacion = @OcupAc_Ocupacion
where Acu_Codigo = @Acu_Codigo
go

create procedure uTBL_AcuTelefono
@Acu_Codigo int,
@Acu_Telefono int
as update TBL_AcuTelefono set
Acu_Telefono = @Acu_Telefono
where Acu_Codigo = @Acu_Codigo
go 

create procedure uTBL_AcuCorreo
@Acu_Codigo int ,
@Acu_Correo varchar(25)
as update TBL_AcuCorreo set 
Acu_Correo = @Acu_Correo
where Acu_Codigo = @Acu_Codigo
go


create procedure uTBL_AcuFotos
@Acu_Codigo int,
@Acu_Fotos varbinary(MAX)
as update TBL_AcuFotos set 
Acu_Fotos = @Acu_Fotos
where Acu_Codigo = @Acu_Codigo
go

create procedure uTBL_AcuRasgos
@Acu_Codigo int,
@Acu_Rasgo varchar(35)
as update TBL_AcuRasgos set 
Acu_Rasgo = @Acu_Rasgo
where Acu_Codigo = @Acu_Codigo
go

create procedure uTBL_AcuHistorialCri
@Acu_Codigo int,
@Acu_Historial varchar(200)
as update TBL_AcuHistorialCri set 
Acu_Historial= @Acu_Historial
where Acu_Codigo = @Acu_Codigo
go

create procedure uTBL_AcuAlias
@Acu_Codigo int,
@Acu_Alias varchar(25)
as update TBL_AcuAlias set 
Acu_Alias = @Acu_Alias
where Acu_Codigo = @Acu_Codigo
go

--Procedimiento de almacenamiento de Eliminacion de Acusado

create procedure dTBL_Acusados
@Acu_Codigo int
as 
begin 
	delete from TBL_Acusados
	where Acu_Codigo = @Acu_Codigo
end
go

--multivalorados
create procedure TBL_dAcuOcupacion
@Acu_Codigo int,
@OcupAc_Ocupacion varchar(50)
as 
begin 
	delete from TBL_AcuOcupacion
	where Acu_Codigo = @Acu_Codigo and
	OcupAc_Ocupacion = @OcupAc_Ocupacion
end
go

create procedure dTBL_AcuTelefono
@Acu_Codigo int,
@Acu_Telefono int
as 
begin 
	delete from TBL_AcuTelefono
	where Acu_Codigo = @Acu_Codigo and
	Acu_Telefono = @Acu_Telefono
end
go



create procedure dTBL_AcuCorreo
@Acu_Codigo int,
@Acu_Correo varchar(25)
as 
begin 
	delete from TBL_AcuCorreo
	where Acu_Codigo = @Acu_Codigo and
	Acu_Correo = @Acu_Correo
end
go


create procedure dTBL_AcuFotos
@Acu_Codigo int,
@Acu_Fotos varbinary(MAX)
as 
begin 
	delete from TBL_AcuFotos
	where Acu_Codigo = @Acu_Codigo and
	Acu_Fotos = @Acu_Fotos
end
go


create procedure dTBL_AcuRasgos
@Acu_Codigo int,
@Acu_Rasgo varchar(35)
as 
begin 
	delete from TBL_AcuRasgos
	where Acu_Codigo = @Acu_Codigo and
	Acu_Rasgo = @Acu_Rasgo
end
go




create procedure dTBL_AcuHistorialCri
@Acu_Codigo int,
@Acu_Historial varchar(200)
as 
begin 
	delete from TBL_AcuHistorialCri
	where Acu_Codigo = @Acu_Codigo and
	Acu_Historial = @Acu_Historial
end
go



create procedure dTBL_AcuAlias
@Acu_Codigo int,
@Acu_Alias varchar(25)
as 
begin 
	delete from TBL_AcuAlias
	where Acu_Codigo = @Acu_Codigo and
	Acu_Alias = @Acu_Alias
end
go


--login 

create table TBL_usuarios
(
id varchar (50),
nombre varchar (50)null,
passwd varchar (50)null,
primary key(id)
)
go

--drop procedure ver_users
create procedure ver_users(
@nombre varchar(50)
)
as
select *from TBL_usuarios
where nombre=@nombre
go


create procedure mTBL_usuarios
as select * from TBL_usuarios order by id desc
go 


create procedure iTBL_usuarios
@id varchar (50),
@nombre varchar (50),
@passwd varchar (50)
as insert into TBL_usuarios
(id,nombre,passwd)
values
(@id,@nombre,@passwd)
go

create procedure uTBL_usuarios
@id varchar (50),
@nombre varchar (50),
@passwd varchar (50)
as update TBL_usuarios set 
id = @id,
nombre = @nombre,
passwd = @passwd
where id = @id
go

create procedure dTBL_usuarios
@id varchar (50)
as 
begin 
	delete from TBL_usuarios
	where id = @id 
end
go

insert into TBL_usuarios values ('1','daniel','daniel')
insert into TBL_usuarios values('2','mirro','mirro')
insert into TBL_usuarios values('3','angel','angel')

select * from TBL_usuarios



--reportes
--1  Mostrar la información del perfil del acusado que más delitos ha cometido. Se desea
--	conocer es el nombre, email, genero, dirección, estatura, peso, sobrenombre de acusado,
-- 	edad, fotos 
--falta foto
--drop procedure Mostrar_Acusado

create procedure Mostrar_Acusado
as
select B.Acu_Nombre,V.Acu_Correo,B.Acu_Genero,B.Acu_Direccion,B.Acu_Estatura,B.Acu_Peso,S.Acu_Alias,B.Acu_Edad ,COUNT(L.Del_PenaMaxima) as [cantidad delitos]
from TBL_Acusados B,TBL_AcuCorreo V,TBL_AcuAlias S,TBL_Expediente E,TBL_Delito L,TBL_Tiene T
where B.Acu_Codigo=V.Acu_Codigo 
and B.Acu_Codigo = S.Acu_Codigo
and B.Acu_Codigo = E.Acu_Codigo
and E.Exp_Nexpediente = T.Exp_Nexpediente
and T.Del_Codigo = L.Del_Codigo
group by B.Acu_Nombre,V.Acu_Correo,B.Acu_Genero,B.Acu_Direccion,B.Acu_Estatura,B.Acu_Peso,S.Acu_Alias,B.Acu_Edad
having MAX (L.Del_Nombre) > MIN(L.Del_Nombre) 

--execute Mostrar_Acusado 




--2
/*
	2.  Mostrar la información del expediente(s) del acusado, como ser el número de expediente,
		fecha de inicio, fecha de conclusión, estado del proceso, especialidad, etapa, motivo de
		conclusiones, observaciones, nombre del delito, nombre del acusado y el nombre de las
		evidencias asociadas al expediente. Este procedimiento recibirá como parámetro el código
		del acusado
*/
--Drop procedure Mostrar_expedien

create procedure Mostrar_expedien
@Acu_codigo int
as
begin
	select E.Exp_Nexpediente,E.Exp_FechaInicio,E.Exp_FechaConclusión,E.Exp_Estado,
	E.Exp_Especialidad,E.Exp_Etapa,E.Exp_CierreConclusión,X.ExpO_Observaciones,
	D.Del_Nombre,A.Acu_Nombre,V.Evi_DescripcionCorta
	from TBL_Expediente E,TBL_ExObservaciones X,TBL_Delito D,TBL_Acusados A,TBL_Evidencias V,TBL_Tiene T,TBL_Vinculado C
	where @Acu_codigo = A.Acu_Codigo
	and A.Acu_Codigo = E.Acu_Codigo
	and E.Exp_Nexpediente = C.Exp_Nexpediente
	and C.Evi_Codigo = V.Evi_Codigo
	and E.Exp_Nexpediente = T.Exp_Nexpediente	
	and T.Del_Codigo = D.Del_Codigo
	group by E.Exp_Nexpediente,E.Exp_FechaInicio,E.Exp_FechaConclusión,E.Exp_Estado,
	E.Exp_Especialidad,E.Exp_Etapa,E.Exp_CierreConclusión,X.ExpO_Observaciones,
	D.Del_Nombre,A.Acu_Nombre,V.Evi_DescripcionCorta
end
go


--execute Mostrar_expedien 2

/*
3. Mostrar la información de un abogado que haya sido acusador. Este procedimiento
recibirá el código del abogado o nombre del abogado
*/

--Drop procedure Mostrar_Abogado

create procedure Mostrar_Abogado
@cod_Abogado int null,
@Abo_Nombre varchar(20) null
as
begin 
	select C.Abo_Codigo,C.Abo_nombre,c.Abo_sexo,c.Abo_NumeroColegiacion,C.Abo_TiempoEjercer,
	c.Abo_Identidad,C.Abo_Identidad
	from TBL_Abogado C, TBL_Asignan A 
	where @cod_Abogado = C.Abo_Codigo 
	and C.Abo_Codigo = A.Abo_Codigo
	and A.Asig_rol in ('Acusador')
	or @Abo_Nombre = C.Abo_nombre
	and C.Abo_Codigo = A.Abo_Codigo
	and A.Asig_rol in ('Acusador')
	group by C.Abo_Codigo,C.Abo_nombre,c.Abo_sexo,c.Abo_NumeroColegiacion,C.Abo_TiempoEjercer,
	c.Abo_Identidad,C.Abo_Identidad	
end
go



--select * from TBL_Asignan

--execute Mostrar_Abogado 2,NULL

--execute Mostrar_Abogado null,'Daniel Canales'

--4. Mostrar la cantidad de acusados que han sido detenidos por un delito
--específico. Este procedimiento recibirá como parámetro el nombre del delito
--drop procedure Mostrar_canti
 create procedure Mostrar_canti
 @Ndelito varchar(20)
 as
 begin 
	select COUNT (A.Acu_Nombre) as [Conteo Acusado]
	from TBL_Delito D, TBL_Tiene T,TBL_Expediente E,TBL_Acusados A
	where @Ndelito = D.Del_Nombre
	and D.Del_Codigo = T.Del_Codigo
	and T.Exp_Nexpediente = E.Exp_Nexpediente
	and E.Acu_Codigo = A.Acu_Codigo
	having  COUNT (A.Acu_Nombre) > 0	
 end
 go

-- execute Mostrar_canti 'Extorsion'

 --5. Mostrar la información de los acusados, que hayan sido defendidos por un abogado
--especifico, Este procedimiento recibirá como parámetro el nombre del abogado 
create procedure Mostrar_Info
@Nabogado varchar(25)
as
begin
	select C.Acu_Nombre,C.Acu_Peso,C.Acu_País_nacimiento,C.Acu_Nivel_educacion,C.Acu_Identidad,
	C.Acu_Genero,C.Acu_fechaNacimiento,C.Acu_Estatura,C.Acu_Estado_Civil,C.Acu_Edad,C.Acu_Direccion,C.Acu_Departamento_nacimiento,
	C.Acu_Color_piel,C.Acu_Color_pelo,C.Acu_Color_ojos,C.Acu_Ciudad_nacimiento
	from TBL_Abogado B,TBL_Asignan A,TBL_Expediente E,TBL_Acusados C
	where @Nabogado = B.Abo_nombre
	and B.Abo_Codigo = A.Abo_Codigo
	and A.Asig_rol = 'Defensor'
	and A.Exp_Nexpediente = E.Exp_Nexpediente
	and E.Acu_Codigo = C.Acu_Codigo
	group by C.Acu_Nombre,C.Acu_Peso,C.Acu_País_nacimiento,C.Acu_Nivel_educacion,C.Acu_Identidad,
	C.Acu_Genero,C.Acu_fechaNacimiento,C.Acu_Estatura,C.Acu_Estado_Civil,C.Acu_Edad,C.Acu_Direccion,C.Acu_Departamento_nacimiento,
	C.Acu_Color_piel,C.Acu_Color_pelo,C.Acu_Color_ojos,C.Acu_Ciudad_nacimiento
end
go

--execute Mostrar_Info 'Jose Canales'



--Mostrar bitacoraç
--tabla de bitacora
--drop table Bitacora
create table Bitacora(
--id int primary key,
ingreso_sistemaIngreso datetime,
cierre_sistemaIngreso datetime,
fechaIngreso datetime,
horaAccion time,
usuario_sistema varchar(100),
nombre_PC varchar(150),
acción_realizada varchar(150) 
)
go

create procedure mBitacora
as
select nombre_PC,
ingreso_sistemaIngreso as ingresoSystem,
cierre_sistemaIngreso as cierreSystem,
fechaIngreso as fechaIngre,
horaAccion As hora,
usuario_sistema as usuario,
nombre_PC as nombrepc,
acción_realizada as accion 
from Bitacora
order by nombre_PC asc
go

select * from Bitacora

create trigger insert_Bitacora
on TBL_Acusados
after insert
as
begin
insert into Bitacora(ingreso_sistemaIngreso,cierre_sistemaIngreso,fechaIngreso,horaAccion,usuario_sistema,nombre_PC,acción_realizada)
values(SYSDATETIME(),CONVERT (date, SYSUTCDATETIME()),CONVERT (date, GETDATE()),CONVERT (time, GETDATE()),SUSER_NAME(),host_name(),'Inserción')
end
go

create trigger Update_Bitacora
on TBL_Acusados
after update
as
begin
insert into Bitacora(ingreso_sistemaIngreso,cierre_sistemaIngreso,fechaIngreso,horaAccion,usuario_sistema,nombre_PC,acción_realizada)
values(SYSDATETIME(),CONVERT (date, SYSUTCDATETIME()),CONVERT (date, GETDATE()),CONVERT (time, GETDATE()),SUSER_NAME(),host_name(),'Actualización')
end
go

create trigger Delete_Bitacora
on TBL_Acusados
after delete
as
begin
insert into Bitacora(ingreso_sistemaIngreso,cierre_sistemaIngreso,fechaIngreso,horaAccion,usuario_sistema,nombre_PC,acción_realizada)
values(SYSDATETIME(),CONVERT (date, SYSUTCDATETIME()),CONVERT (date, GETDATE()),CONVERT (time, GETDATE()),SUSER_NAME(),host_name(),'eliminación')
end
go










/*
CREATE TABLE Nota (
Id int IDENTITY (1, 1) NOT NULL, 
Titulo varchar(50) NOT NULL, 
Imagen varbinary(MAX) NOT NULL) 
ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
*/