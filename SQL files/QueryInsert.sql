/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
DELETE FROM USUARIO;
INSERT INTO USUARIO VALUES(1,'juanse260726@gmail.com','Sebastian','Rodriguez','2001-07-26','Juli1804',1);
INSERT INTO USUARIO VALUES(2,'juanse979@hotmail.com','Sebastian','Rodriguez','2001-07-26','Juli1804',2);
INSERT INTO USUARIO VALUES(3,'@','Sebastian','Rodriguez','2001-07-26','1234',3);
SELECT * FROM USUARIO;




/*==============================================================*/
/* Table: FUNCIONES                                               */
/*==============================================================*/
DELETE FROM MENSAJE;
DELETE FROM FUNCIONES;
INSERT INTO FUNCIONES VALUES (0,'No QnAMaker answers found.');
INSERT INTO FUNCIONES VALUES (1,'Greetings');
INSERT INTO FUNCIONES VALUES (2,'Add_user');
INSERT INTO FUNCIONES VALUES (3,'Edit_user');
INSERT INTO FUNCIONES VALUES (4,'Find_user');
INSERT INTO FUNCIONES VALUES (5,'Show_users');
INSERT INTO FUNCIONES VALUES (6,'Thanks');
INSERT INTO FUNCIONES VALUES (7,'Smile');
SELECT * FROM FUNCIONES;


/*==============================================================*/
/* Table: MENSAJE                                               */
/*==============================================================*/
DELETE FROM MENSAJE;
INSERT INTO MENSAJE VALUES (0,1,'Lo siento, no te entendí, ¿puedes repetir lo que escribiste?');
INSERT INTO MENSAJE VALUES (1,2,'Hola, Bienvenido al Chatbot Empresarial YMCA \n ¿Qué puedo hacer por ti?');
INSERT INTO MENSAJE VALUES (1,3,'Hola :D, \n ¿Cómo te puedo ayudar? ');
SELECT * FROM MENSAJE;
