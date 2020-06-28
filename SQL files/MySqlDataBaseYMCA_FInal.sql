/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     24/06/2020 5:54:15 p. m.                     */
/*==============================================================*/


drop table if exists COMPANIA;

drop table if exists EVENTOS;

drop table if exists FUNCIONES;

drop table if exists MENSAJE;

drop table if exists MOVIMIENTOS;

drop table if exists PERSONA;

drop table if exists PER_PROG;

drop table if exists PETICIONES;

drop table if exists PRODUCTO;

drop table if exists PROGRAMA;

drop table if exists P_EVENTOS;

drop table if exists REG_ACCESO;

drop table if exists REG_FUNCION;

drop table if exists USUARIO;

/*==============================================================*/
/* Table: COMPANIA                                              */
/*==============================================================*/
create table COMPANIA
(
   ID_COMPANIA          int not null auto_increment,
   NOMBRE_COMPANIA      varchar(100) not null,
   DIRECCION            varchar(200) not null,
   NIT                  varchar(100) not null,
   TELEFONO_CONTACTO    varchar(100) not null,
   primary key (ID_COMPANIA)
);

/*==============================================================*/
/* Table: EVENTOS                                               */
/*==============================================================*/
create table EVENTOS
(
   ID_EVENTO            int not null auto_increment,
   ID_USUARIO           int not null,
   FECHA_EVENTO         datetime not null,
   ASUNTO_EVENTO        varchar(100) not null,
   primary key (ID_EVENTO)
);

/*==============================================================*/
/* Table: FUNCIONES                                             */
/*==============================================================*/
create table FUNCIONES
(
   ID_FUNCION           int not null,
   NOMBRE_FUNCION       varchar(100) not null,
   primary key (ID_FUNCION)
);

/*==============================================================*/
/* Table: MENSAJE                                               */
/*==============================================================*/
create table MENSAJE
(
   ID_FUNCION           int not null,
   ID_MENSAJE           int not null,
   TXTMENSAJE           varchar(100) not null,
   primary key (ID_FUNCION, ID_MENSAJE)
);

/*==============================================================*/
/* Table: MOVIMIENTOS                                           */
/*==============================================================*/
create table MOVIMIENTOS
(
   ID_MOVIMIENTO        int not null auto_increment,
   ID_PRODUCTO          int not null,
   ID_USUARIO           int not null,
   FECHA_MOVIENTO       date not null,
   CANTIDAD_MOVIMIENTO  int not null,
   primary key (ID_MOVIMIENTO)
);

/*==============================================================*/
/* Table: PERSONA                                               */
/*==============================================================*/
create table PERSONA
(
   ID_PERSONA           varchar(25) not null,
   ID_USUARIO           int,
   NOMBRE_PERSONA       varchar(100) not null,
   APELLIDO_PERSONA     varchar(100) not null,
   FECHA_NACIMIENTO     date not null,
   TELEFONO_PERSONA     varchar(20) not null,
   GENERO               varchar(10) not null,
   CORREO_PERSONA       varchar(100) not null,
   PAIS_ORIGEN          varchar(100),
   ROL_PERSONA          varchar(100),
   primary key (ID_PERSONA)
);

/*==============================================================*/
/* Table: PER_PROG                                              */
/*==============================================================*/
create table PER_PROG
(
   ID_PROGRAMA          int not null,
   ID_PERSONA           varchar(25) not null,
   ROL_PROGRAMA         varchar(100) not null,
   CALIFICACION         int not null,
   primary key (ID_PROGRAMA, ID_PERSONA)
);

/*==============================================================*/
/* Table: PETICIONES                                            */
/*==============================================================*/
create table PETICIONES
(
   ID_PETICION          int not null auto_increment,
   ID_USUARIO_FROM      int not null,
   ID_USUARIO_TO        int not null,
   ASUNTO_PETICION      varchar(100) not null,
   DESC_PETICION        varchar(100) not null,
   primary key (ID_PETICION)
);

/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/
create table PRODUCTO
(
   ID_PRODUCTO          int not null auto_increment,
   NOMBRE_ACCESO        varchar(100) not null,
   CANTIDAD             int not null,
   LOCALIZACION         varchar(100) not null,
   TIPO_PRODUCTO        varchar(100) not null,
   primary key (ID_PRODUCTO)
);

/*==============================================================*/
/* Table: PROGRAMA                                              */
/*==============================================================*/
create table PROGRAMA
(
   ID_PROGRAMA          int not null auto_increment,
   ID_COMPANIA          int not null,
   NOMBRE_PROGRAMA      varchar(100) not null,
   FECHA_INICIO         date not null,
   FECHA_FIN            date not null,
   TIPO_PROGRAMA        varchar(100) not null,
   primary key (ID_PROGRAMA)
);

/*==============================================================*/
/* Table: P_EVENTOS                                             */
/*==============================================================*/
create table P_EVENTOS
(
   ID_EVENTO            int not null,
   ID_USUARIO           int not null,
   primary key (ID_EVENTO, ID_USUARIO)
);

/*==============================================================*/
/* Table: REG_ACCESO                                            */
/*==============================================================*/
create table REG_ACCESO
(
   ID_ACCESO            int not null auto_increment,
   ID_USUARIO           int not null,
   FECHA_ACCESO         datetime not null,
   primary key (ID_ACCESO)
);

/*==============================================================*/
/* Table: REG_FUNCION                                           */
/*==============================================================*/
create table REG_FUNCION
(
   ID_FUNCION           int not null,
   ID_ACCESO            int not null,
   ID_REG_FUNCION       int not null,
   primary key (ID_REG_FUNCION)
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO
(
   ID_USUARIO           int not null auto_increment,
   ID_PERSONA           varchar(25) not null,
   NICKNAME             varchar(100) not null,
   CONTRASENIA          varchar(100) not null,
   ROL_EMPRESA          varchar(100) not null,
   primary key (ID_USUARIO)
);

alter table EVENTOS add constraint FK_P_EVENTOS_DUENO foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table MENSAJE add constraint FK_FUNC_MENSAJE foreign key (ID_FUNCION)
      references FUNCIONES (ID_FUNCION) on delete restrict on update restrict;

alter table MOVIMIENTOS add constraint FK_PROD_USER foreign key (ID_PRODUCTO)
      references PRODUCTO (ID_PRODUCTO) on delete restrict on update restrict;

alter table MOVIMIENTOS add constraint FK_USER_PROD2 foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table PERSONA add constraint FK_REG_USUARIOS foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table PER_PROG add constraint FK_PER_PROG foreign key (ID_PROGRAMA)
      references PROGRAMA (ID_PROGRAMA) on delete restrict on update restrict;

alter table PER_PROG add constraint FK_PER_PROG2 foreign key (ID_PERSONA)
      references PERSONA (ID_PERSONA) on delete restrict on update restrict;

alter table PETICIONES add constraint FK_PET_FROM foreign key (ID_USUARIO_FROM)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table PETICIONES add constraint FK_PET_TO foreign key (ID_USUARIO_TO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table PROGRAMA add constraint FK_COMP_PROG foreign key (ID_COMPANIA)
      references COMPANIA (ID_COMPANIA) on delete restrict on update restrict;

alter table P_EVENTOS add constraint FK_INVITADOS_EVENTO foreign key (ID_EVENTO)
      references EVENTOS (ID_EVENTO) on delete restrict on update restrict;

alter table P_EVENTOS add constraint FK_P_EVENTOS2 foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table REG_ACCESO add constraint FK_ACCESOS foreign key (ID_USUARIO)
      references USUARIO (ID_USUARIO) on delete restrict on update restrict;

alter table REG_FUNCION add constraint FK_REG_FUNCION foreign key (ID_FUNCION)
      references FUNCIONES (ID_FUNCION) on delete restrict on update restrict;

alter table REG_FUNCION add constraint FK_REG_FUNCION2 foreign key (ID_ACCESO)
      references REG_ACCESO (ID_ACCESO) on delete restrict on update restrict;

alter table USUARIO add constraint FK_REG_PERSONA foreign key (ID_PERSONA)
      references PERSONA (ID_PERSONA) on delete restrict on update restrict;

