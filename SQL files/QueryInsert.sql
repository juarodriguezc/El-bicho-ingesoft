DELETE FROM PERSONAS;
/*==============================================================*/
/* Table: PERSONA 						*/
/*==============================================================*/
INSERT INTO PERSONA VALUES('1',NULL,'admin','man','1890-07-26','696969','Masculino','@dmin','Barrancabermeja','Trabajador');


/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
DELETE FROM REG_ACCESO;
DELETE FROM USUARIO;
INSERT INTO USUARIO (Id_persona,Nickname,Contrasenia,Rol_empresa)VALUES('1','@','123','Administrador');
SELECT * FROM USUARIO;

/*==============================================================*/
/* Table: PERSONA - UPDATE 					*/
/*==============================================================*/
UPDATE PERSONA SET Id_usuario = 1 WHERE Id_persona = '1';


/*==============================================================*/
/* Table: FUNCIONES                                               */
/*==============================================================*/
DELETE FROM MENSAJE;
DELETE FROM FUNCIONES;
INSERT INTO FUNCIONES VALUES (-2,'Hello and welcome!');
INSERT INTO FUNCIONES VALUES (-1,'Start_chatbot');
INSERT INTO FUNCIONES VALUES (0,'No QnAMaker answers found.');
INSERT INTO FUNCIONES VALUES (1,'Greetings');
INSERT INTO FUNCIONES VALUES (2,'Add_user');
INSERT INTO FUNCIONES VALUES (3,'Edit_user');
INSERT INTO FUNCIONES VALUES (4,'Find_user');
INSERT INTO FUNCIONES VALUES (5,'Show_users');
INSERT INTO FUNCIONES VALUES (6,'Thanks');
INSERT INTO FUNCIONES VALUES (7,'Smile');
INSERT INTO FUNCIONES VALUES (8,'Reg_conversacion');
INSERT INTO FUNCIONES VALUES (9,'Info_specific_program');
INSERT INTO FUNCIONES VALUES (10,'User_request');
INSERT INTO FUNCIONES VALUES (11,'Show_company');
INSERT INTO FUNCIONES VALUES (12,'Show_personas_info');
INSERT INTO FUNCIONES VALUES (13,'Add_program');
INSERT INTO FUNCIONES VALUES (14,'Search_foreign_volunteers');
INSERT INTO FUNCIONES VALUES (15,'Search_program_by_person');
INSERT INTO FUNCIONES VALUES (16,'Add_volunter');
INSERT INTO FUNCIONES VALUES (17,'Show_stock');
INSERT INTO FUNCIONES VALUES (18,'Show_calendar');
INSERT INTO FUNCIONES VALUES (19,'Add_event');
INSERT INTO FUNCIONES VALUES (20,'Show_user_info');
INSERT INTO FUNCIONES VALUES (21,'Pick_stock');
INSERT INTO FUNCIONES VALUES (22,'Add_stock');
INSERT INTO FUNCIONES VALUES (23,'Modificar_evento');
INSERT INTO FUNCIONES VALUES (24,'Show_events');
INSERT INTO FUNCIONES VALUES (25,'Change_programInfo');
INSERT INTO FUNCIONES VALUES (26,'Add_volunteer_program');
INSERT INTO FUNCIONES VALUES (27,'Add_person');
INSERT INTO FUNCIONES VALUES (28,'Program_fecha');
INSERT INTO FUNCIONES VALUES (29,'Program_fecha');
INSERT INTO FUNCIONES VALUES (80,'El bicho siuu');

SELECT * FROM FUNCIONES;


/*==============================================================*/
/* Table: MENSAJE                                               */
/*==============================================================*/
DELETE FROM MENSAJE;
INSERT INTO MENSAJE VALUES (-2,2,'Chatbot Empresarial v1.0 Iniciado');
INSERT INTO MENSAJE VALUES (-1,2,'Hola, Bienvenido al Chatbot Empresarial YMCA * ¿Qué puedo hacer por ti?');
INSERT INTO MENSAJE VALUES (0,1,'Lo siento, no te entendí, ¿puedes repetir lo que escribiste?');
INSERT INTO MENSAJE VALUES (1,3,'Hola :D * ¿Cómo te puedo ayudar? ');
INSERT INTO MENSAJE VALUES (1,4,'Hola buenos días:D * ¿Cómo te puedo ayudar? ');
INSERT INTO MENSAJE VALUES (1,5,'Holaaa :D * ¿Qué necesitas hacer? ');
INSERT INTO MENSAJE VALUES (1,6,'Hola * ¿Te puedo ayudar en algo? ');
INSERT INTO MENSAJE VALUES (2,7,'De acuerdo, añadir un usuario');
INSERT INTO MENSAJE VALUES (2,8,'Ok, vamos a añadir un usuario');
INSERT INTO MENSAJE VALUES (2,9,'¿Añadir usuario? Ok');
INSERT INTO MENSAJE VALUES (2,10,'Muy bien, vamos a añadir un usuario');
INSERT INTO MENSAJE VALUES (3,11,'De acuerdo, modificar un usuario');
INSERT INTO MENSAJE VALUES (3,12,'Muy bien, modificar un usuario');
INSERT INTO MENSAJE VALUES (3,13,'Ok, desplegando formulario para edición de usuario');
INSERT INTO MENSAJE VALUES (4,14,'De acuerdo, vamos a buscar un usuario');
INSERT INTO MENSAJE VALUES (4,15,'Ok, piensa en alguno de los datos del usuario a buscar');
INSERT INTO MENSAJE VALUES (4,16,'Muy bien, buscar un usuario, para esto debes tener algún dato de búsqueda');
INSERT INTO MENSAJE VALUES (4,17,'Ok, vamos a buscar un usuario ');
INSERT INTO MENSAJE VALUES (5,18,'De acuerdo, voy a desplegar una ventana con los usuarios');
INSERT INTO MENSAJE VALUES (5,19,'Ok, se va a abrir una ventana con los usuarios');
INSERT INTO MENSAJE VALUES (5,20,'Muy bien, voy a mostrarte los usuarios');
INSERT INTO MENSAJE VALUES (5,21,'Bueno, mostrando los usuarios');
INSERT INTO MENSAJE VALUES (6,22,'¡No hay de qué! ;D ');
INSERT INTO MENSAJE VALUES (6,23,'De nada :D');
INSERT INTO MENSAJE VALUES (6,24,'De nada* Si necesitas algo puedes escribirlo ');
INSERT INTO MENSAJE VALUES (6,25,'Vale, estoy aquí para ayudarte ');
INSERT INTO MENSAJE VALUES (6,26,':D ');
INSERT INTO MENSAJE VALUES (7,27,':D ');
INSERT INTO MENSAJE VALUES (7,28,':D :D :D ;D ');
INSERT INTO MENSAJE VALUES (7,29,'	\(^o^)/');
INSERT INTO MENSAJE VALUES (8,30,'Ok * Mostrar el registro de las conversaciones');
INSERT INTO MENSAJE VALUES (9,31,'Ok * Voy a mostrar la información del programa que selecciones');
INSERT INTO MENSAJE VALUES (10,32,'Ok * Voy a deplegar un formulario para que realices tu solicitud');
INSERT INTO MENSAJE VALUES (11,33,'Ok * Te voy a mostrar la información de las compañias asociadas');
INSERT INTO MENSAJE VALUES (12,34,'Listo * Voy a mostrar la información de las personas registradas');
INSERT INTO MENSAJE VALUES (13,35,'Entiendo,voy a mostrar un formulario para que añadas un programa');
INSERT INTO MENSAJE VALUES (14,36,'Ok * Voy a desplegar una ventana con las personas extranjeras');
INSERT INTO MENSAJE VALUES (15,37,'Bueno* Voy a desplegar una ventana para que busques los programas en los que ha participado una persona');
INSERT INTO MENSAJE VALUES (16,38,'Ok * Voy a mostrar un formulario para que añadas una voluntario');
INSERT INTO MENSAJE VALUES (17,39,'Mostrare los productos en bodega');
INSERT INTO MENSAJE VALUES (17,40,'Ok. Voy a mostrar un tabla con los productos en bodega');
INSERT INTO MENSAJE VALUES (18,41,'Ok, voy a mostrar el calendario');
INSERT INTO MENSAJE VALUES (19,42,'De acuerdo* Voy a mostrar un formulario para que añadas un evento');
INSERT INTO MENSAJE VALUES (20,43,'Ok* Voy a mostrarte la información de los usuarios');
INSERT INTO MENSAJE VALUES (21,44,'Ok* Voy a mostrarte un formulario para realizar un movimiento sobre bodega');
INSERT INTO MENSAJE VALUES (22,45,'Ok* Voy a mostrarte un formulario para ingresar un producto en bodega');
INSERT INTO MENSAJE VALUES (23,46,'Ok* Voy a mostrarte tus eventos para que puedas editarlos');
INSERT INTO MENSAJE VALUES (24,47,'Muy bien! *Voy a desplegar una ventana con los eventos empresariales que tienes programados');
INSERT INTO MENSAJE VALUES (25,48,'Muy bien! *Voy a desplegar una ventana para que puedas editar los programas');
INSERT INTO MENSAJE VALUES (26,49,'Muy bien! *Voy a desplegar una ventana para que puedas añadir voluntarios al programa de tu eleccion');
INSERT INTO MENSAJE VALUES (27,50,'Ok * Voy a mostrar un formulario para que añadas una persona a la base de datos');
INSERT INTO MENSAJE VALUES (28,51,'Ok * Voy a mostrar una ventana con los programas activos en la fecha que elijas');
INSERT INTO MENSAJE VALUES (29,52,'Ok * Voy a desplegar un formulario para que añadas una empresa');
INSERT INTO MENSAJE VALUES (80,100,'SIUUUUUUUUUUUUUU');
INSERT INTO MENSAJE VALUES (80,101,'¡Ay mi madre el BICHO!');
INSERT INTO MENSAJE VALUES (80,102,'Mico Mandante SIUUUU');


/*==============================================================*/
/* Table: PRODUCTO                                              */
/*==============================================================*/

INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Pelotas de piscina',20,'B5');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Pelotas antiestres',30,'A4');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Pelotas de tenis',25,'A4');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Hula hula',15,'C1');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Balon de futbol',10,'D3');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Balon basketball',5,'5');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Costales',15,'A1');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('JUegos de cartas',5,'C2');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Puntillas',100,'A2');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Conos',20,'B5');
INSERT INTO PRODUCTO(NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES ('Borrador tablero pequeno',30,'C2');