/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2016                    */
/* Created on:     1/06/2020 4:26:17 p. m.                      */
/*==============================================================*/


drop table EVENTOS
drop table FUNCIONES
drop table MENSAJE
drop table PETICIONES
drop table P_EVENTOS
drop table REG_ACCESO
drop table REG_FUNCION
drop table USUARIO






/*==============================================================*/
/* Table: EVENTOS                                               */
/*==============================================================*/
create table EVENTOS (
   ID_EVENTO            int                  not null,
   FECHA_EVENTO         datetime             not null,
   ASUNTO_EVENTO        varchar(100)         not null,
   constraint PK_EVENTOS primary key (ID_EVENTO)
)
go

/*==============================================================*/
/* Table: FUNCIONES                                             */
/*==============================================================*/
create table FUNCIONES (
   ID_FUNCION           int                  not null,
   NOMBRE_FUNCION       varchar(100)         not null,
   constraint PK_FUNCIONES primary key (ID_FUNCION)
)
go

/*==============================================================*/
/* Table: MENSAJE                                               */
/*==============================================================*/
create table MENSAJE (
   ID_FUNCION           int                  not null,
   ID_MENSAJE           int                  not null,
   TXTMENSAJE           varchar(100)         not null,
   constraint PK_MENSAJE primary key (ID_FUNCION, ID_MENSAJE)
)
go

/*==============================================================*/
/* Table: PETICIONES                                            */
/*==============================================================*/
create table PETICIONES (
   ID_USUARIO           int                  not null,
   ID_PETICION          int                  not null,
   ASUNTO_PETICION      varchar(100)         not null,
   DESC_PETICION        varchar(100)         not null,
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
   ID_ACCESO            int                  not null	IDENTITY(1,1),
   FECHA_ACCESO         datetime             not null,
   constraint PK_REG_ACCESO primary key (ID_USUARIO, ID_ACCESO)
)
go

/*==============================================================*/
/* Table: REG_FUNCION                                           */
/*==============================================================*/
create table REG_FUNCION (
   ID_FUNCION           int                  not null,
   ID_USUARIO           int                  not null,
   ID_ACCESO            int                  not null,
   ID_REG_FUNC          int                  not null	IDENTITY(1,1),
   constraint PK_REG_FUNCION primary key (ID_FUNCION, ID_USUARIO, ID_ACCESO, ID_REG_FUNC)
)
go

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO (
   ID_USUARIO           int                  not null	IDENTITY(1,1),
   CORREO               varchar(100)         not null,
   NOMBRE               varchar(100)         not null,
   APELLIDO             varchar(100)         not null,
   FECHA_NACIMIENTO     datetime             not null,
   CONTRASENIA          varchar(100)         not null,
   ROL_EMPRESA          varchar(100)         not null,
   constraint PK_USUARIO primary key (ID_USUARIO)
)
go

alter table MENSAJE
   add constraint FK_MENSAJE_FUNC_MENS_FUNCIONE foreign key (ID_FUNCION)
      references FUNCIONES (ID_FUNCION)
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

alter table REG_FUNCION
   add constraint FK_REG_FUNC_REG_FUNCI_FUNCIONE foreign key (ID_FUNCION)
      references FUNCIONES (ID_FUNCION)
go

alter table REG_FUNCION
   add constraint FK_REG_FUNC_REG_FUNCI_REG_ACCE foreign key (ID_USUARIO, ID_ACCESO)
      references REG_ACCESO (ID_USUARIO, ID_ACCESO)
go



