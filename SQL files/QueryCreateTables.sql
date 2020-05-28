/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     28/05/2020 10:36:20 a. m.                    */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PETICIONES') and o.name = 'FK_PETICION_S_PETICIO_USUARIO')
alter table PETICIONES
   drop constraint FK_PETICION_S_PETICIO_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('P_EVENTOS') and o.name = 'FK_P_EVENTO_P_EVENTOS_EVENTOS')
alter table P_EVENTOS
   drop constraint FK_P_EVENTO_P_EVENTOS_EVENTOS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('P_EVENTOS') and o.name = 'FK_P_EVENTO_P_EVENTOS_USUARIO')
alter table P_EVENTOS
   drop constraint FK_P_EVENTO_P_EVENTOS_USUARIO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('REG_ACCESO') and o.name = 'FK_REG_ACCE_ACCESOS_USUARIO')
alter table REG_ACCESO
   drop constraint FK_REG_ACCE_ACCESOS_USUARIO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EVENTOS')
            and   type = 'U')
   drop table EVENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PETICIONES')
            and   type = 'U')
   drop table PETICIONES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('P_EVENTOS')
            and   type = 'U')
   drop table P_EVENTOS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REG_ACCESO')
            and   type = 'U')
   drop table REG_ACCESO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USUARIO')
            and   type = 'U')
   drop table USUARIO
go

/*==============================================================*/
/* Table: EVENTOS                                               */
/*==============================================================*/
create table EVENTOS (
   ID_EVENTO            int                  not null,
   FECHA_EVENTO         datetime             not null,
   ASUNTO_EVENTO        text                 not null,
   constraint PK_EVENTOS primary key (ID_EVENTO)
)
go

/*==============================================================*/
/* Table: PETICIONES                                            */
/*==============================================================*/
create table PETICIONES (
   ID_USUARIO           int                  not null,
   ID_PETICION          int                  not null,
   ASUNTO_PETICION      text                 not null,
   DESC_PETICION        text                 not null,
   constraint PK_PETICIONES primary key (ID_USUARIO, ID_PETICION)
)
go

/*==============================================================*/
/* Table: P_EVENTOS                                             */
/*==============================================================*/
create table P_EVENTOS (
   ID_EVENTO            int                  not null,
   ID_USUARIO           int                  not null,
   constraint PK_P_EVENTOS primary key (ID_EVENTO, ID_USUARIO)
)
go

/*==============================================================*/
/* Table: REG_ACCESO                                            */
/*==============================================================*/
create table REG_ACCESO (
   ID_USUARIO           int                  not null,
   ID_ACCESO            int                  not null,
   FECHA_ACCESO         datetime             not null,
   constraint PK_REG_ACCESO primary key (ID_USUARIO, ID_ACCESO)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           int                  not null,
   CORREO               nvarchar(100)	     not null,
   NOMBRE               text                 not null,
   APELLIDO             text                 not null,
   FECHA_NACIMIENTO     datetime             not null,
   CONTRASENIA          nvarchar(100)  	     not null,
   ROL_EMPRESA          int                  not null,
   constraint PK_USUARIO primary key (ID_USUARIO)
)
go

alter table PETICIONES
   add constraint FK_PETICION_S_PETICIO_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table P_EVENTOS
   add constraint FK_P_EVENTO_P_EVENTOS_EVENTOS foreign key (ID_EVENTO)
      references EVENTOS (ID_EVENTO)
go

alter table P_EVENTOS
   add constraint FK_P_EVENTO_P_EVENTOS_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

alter table REG_ACCESO
   add constraint FK_REG_ACCE_ACCESOS_USUARIO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO)
go

