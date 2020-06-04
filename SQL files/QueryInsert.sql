/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
DELETE FROM REG_ACCESO;
DELETE FROM USUARIO;
INSERT INTO USUARIO VALUES('juanse260726@gmail.com','Sebastian','Rodriguez','2001-07-26','Juli1804','Empleado');
INSERT INTO USUARIO VALUES('juanse979@hotmail.com','Sebastian','Rodriguez','2001-07-26','Juli1804','Jefe de área');
INSERT INTO USUARIO VALUES('@','Sebastian','Rodriguez','2001-07-26','1234','Administrador');
SELECT * FROM USUARIO;




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
INSERT INTO FUNCIONES VALUES (8, "Reg_conversacion")
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
INSERT INTO MENSAJE VALUES (80,100,'SIUUUUUUUUUUUUUU');
INSERT INTO MENSAJE VALUES (80,101,'¡Ay mi madre el BICHO!');
INSERT INTO MENSAJE VALUES (80,102,'Mico Mandante SIUUUU');
