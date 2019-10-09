
CREATE PROCEDURE sp_fichatecnica_item_incluir
	@IdPreparo INT,
	@IdInsumo INT,
	@Quantidade DECIMAL(10,4)
AS 
	IF NOT EXISTS (SELECT * FROM ItemReceita WHERE IdInsumo=@IdInsumo AND IdPreparo=@IdPreparo) 
	BEGIN
		INSERT INTO ItemReceita(IdPreparo,IdInsumo,Quantidade)
		VALUES(@IdPreparo,@IdInsumo,@Quantidade)
	END
GO



CREATE PROCEDURE sp_fichatecnica_mostrar_itens
	@IdPreparo INT
AS
	SELECT ItemReceita.IdPreparo,ItemReceita.IdInsumo,Insumo.Nome,Insumo.Descricao,ItemReceita.Quantidade,UnidadeConsumo.Simbolo AS Unidade FROM ItemReceita
	INNER JOIN Insumo ON ItemReceita.IdInsumo=Insumo.IdInsumo AND ItemReceita.IdPreparo=@IdPreparo
	INNER JOIN UnidadeConsumo ON Insumo.IdUnidadeConsumo=UnidadeConsumo.IdUnidadeConsumo
GO



CREATE PROCEDURE sp_fichatecnica_buscar_insumos_nome
	@Nome VARCHAR(50)

AS
	SELECT Insumo.IdInsumo,Insumo.Nome,Insumo.Descricao,UnidadeConsumo.Simbolo FROM Insumo
	INNER JOIN UnidadeConsumo on Insumo.IdUnidadeConsumo=UnidadeConsumo.IdUnidadeConsumo AND Insumo.Nome LIKE '%' + @Nome + '%' 
GO

CREATE PROCEDURE sp_fichatecnica_item_excluir
	@IdInsumo INT,
	@IdPreparo INT
AS
	DELETE FROM ItemReceita WHERE IdPreparo=@IdPreparo AND IdInsumo=@IdInsumo
GO

