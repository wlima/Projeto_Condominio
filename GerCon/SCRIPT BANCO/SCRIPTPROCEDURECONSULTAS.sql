--PESQUISA POR MORADOR INADIPLENTE--
CREATE PROCEDURE uspCONINADIPLENCIA
AS
BEGIN
	SELECT M.Nome Morador, A.Numero Apartamento, C.Descricao Custo, C.DataVencimento FROM tbCusto C RIGHT JOIN tbApartamento A ON(C.Apartamento=A.idApartamento)
	RIGHT JOIN tbMorador M ON (A.Morador=M.idMorador) WHERE C.Pago =0;
END;


create procedure uspCONfUNCIONARIO
AS
BEGIN
select f.*, c.idCondominio, c.Nome,c.Endereco from tbFuncionario f join tbCondominio c on(f.Condominio=c.idCondominio) order by f.Nome;
END;