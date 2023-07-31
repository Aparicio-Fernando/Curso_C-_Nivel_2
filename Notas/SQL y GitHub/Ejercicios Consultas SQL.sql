--Ejercicios Consultas SQL

--Ejercicio 1
SELECT * FROM DISCOS
SELECT * FROM ESTILOS

SELECT D.Titulo [Nombre del disco], D.FechaLanzamiento [Fecha de lanzamiento], E.Descripcion Estilo FROM DISCOS D, ESTILOS E

-- Ejercicio 2
SELECT * FROM ESTILOS

INSERT INTO ESTILOS (Descripcion)
VALUES('Clasica')
INSERT INTO ESTILOS (Descripcion)
VALUES('Heaby')

UPDATE ESTILOS
SET Descripcion = 'Heavy'
WHERE Id=6;

--Ejercicio 3
SELECT * FROM DISCOS
SELECT * FROM ESTILOS
SELECT * FROM TIPOSEDICION

INSERT INTO DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)
VALUES('Narigon del Siglo',2000-01-01,13,'https://rateyourmusic.com/release/album/divididos/narigon-del-siglo/',3,2)

INSERT INTO DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)
VALUES('En vivo 1993 Argentina',1993-01-01,13,'https://en.wikipedia.org/wiki/En_vivo_1993_Argentina',6,1)

--Ejercicio 4
UPDATE DISCOS
SET CantidadCanciones = 13, FechaLanzamiento = '2000-01-01'
WHERE Id = 1

--Ejercicio 5
DELETE FROM DISCOS
WHERE Id=1

-- ejercicio 6: Traer todos los estilos que estén asociados a algún disco.

SELECT D.Titulo [Nombre del disco], E.Descripcion Estilo
FROM DISCOS D
INNER JOIN ESTILOS E
ON E.Id = D.Id

SELECT D.Titulo AS [Nombre del Disco], E.Descripcion Estilo
FROM DISCOS D
INNER JOIN ESTILOS E ON D.IdEstilo = E.Id
WHERE E.Descripcion = 'Rock';

--Ejercicio 7: Traer todos los discos con el siguiente formato: Nombre, Estilo, Edición (todo texto).

SELECT D.Titulo Nombre, E.Descripcion Estilo, T.Descripcion Edicion
FROM DISCOS D
INNER JOIN ESTILOS E ON D.IdEstilo = E.Id
INNER JOIN TIPOSEDICION T ON D.IdTipoEdicion=T.Id

--Ejercicio 8: Traer todos los discos que contengan en su nombre la sílaba "ho".

SELECT Titulo [Nombre del Disco]
FROM DISCOS
WHERE Titulo LIKE '%ho%';