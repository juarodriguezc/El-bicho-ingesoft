/*==============================================================*/
/* Table: REG_ACCESO                                               */
/*==============================================================*/

DELETE FROM REG_FUNCION;
DELETE FROM REG_ACCESO;

INSERT INTO REG_ACCESO VALUES (1,'2001-07-26');


/*==============================================================*/
/* Table: REG_FUNCION                                               */
/*==============================================================*/
DELETE FROM REG_FUNCION;
INSERT INTO REG_FUNCION VALUES(2,1,1);
INSERT INTO REG_FUNCION VALUES(3,1,1);
INSERT INTO REG_FUNCION VALUES(2,1,1);
INSERT INTO REG_FUNCION VALUES(4,1,1);


SELECT * FROM REG_ACCESO;
SELECT * FROM REG_FUNCION;

--SELECT TOP 1 * FROM MENSAJE WHERE ID_FUNCION = 1 ORDER BY NEWID();
--SELECT TXTMENSAJE FROM MENSAJE INNER JOIN FUNCIONES f ON f.ID_FUNCION = MENSAJE.ID_FUNCION;
--SELECT TOP 1 TXTMENSAJE FROM MENSAJE INNER JOIN FUNCIONES f ON f.ID_FUNCION = MENSAJE.ID_FUNCION WHERE MENSAJE.ID_FUNCION = 1 ORDER BY NEWID(); 
--SELECT TOP 1 TXTMENSAJE FROM MENSAJE INNER JOIN FUNCIONES f ON f.ID_FUNCION = MENSAJE.ID_FUNCION WHERE f.NOMBRE_FUNCION = 'Greetings'  ORDER BY NEWID(); 