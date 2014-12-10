SELECT M.NOME FROM tbApartamento A join tbMorador M on(A.Morador=M.idMorador)
WHERE A.Numero=003
SELECT COUNT(VALOR) FROM tbCUSTO WHERE Apartamento=002
SELECT CAST(VALOR AS MONEY) FROM tbCUSTO WHERE Apartamento=002
SELECT CAST(C.VALOR AS MONEY),A.Numero AS APARTAMENTO, B.Descricao FROM tbCusto C JOIN tbApartamento A ON (C.Apartamento=A.idApartamento)
JOIN tbBloco B ON (A.Bloco=B.idBloco)
WHERE A.Bloco = 1
EXEC[dbo].[uspACAOCUSTO] 1,3,NULL,NULL,81.58,0
SELECT * FROM tbBloco
SELECT SUM(CAST(C.VALOR AS MONEY)), B.Descricao FROM tbCusto C JOIN tbApartamento A ON (C.Apartamento=A.idApartamento)
JOIN tbBloco B ON (A.Bloco=B.idBloco)
WHERE A.Bloco = 1