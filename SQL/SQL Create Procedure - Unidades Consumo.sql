
CREATE PROCEDURE sp_UnidadeConsumo_criar
	@simbolo VARCHAR(50),
	@descricao VARCHAR(100)
AS
	INSERT INTO UnidadeConsumo (Simbolo, Descricao)
	VALUES (@simbolo,@descricao)
GO

CREATE PROCEDURE sp_UnidadeConsumo_excluir
	@idunidadeconsumo INT
AS
	DELETE FROM UnidadeConsumo WHERE IdUnidadeConsumo = @idUnidadeConsumo
GO

CREATE PROCEDURE sp_UnidadeConsumo_editar
	@simbolo VARCHAR(50),
	@descricao	VARCHAR(50),
	@idunidadeconsumo	INT
AS
	UPDATE UnidadeConsumo SET Simbolo=@simbolo,Descricao=@descricao
	WHERE IdUnidadeConsumo = @idunidadeconsumo
GO

CREATE PROCEDURE sp_UnidadeConsumo_mostrar
AS
	SELECT TOP 200 * FROM UnidadeConsumo
	ORDER BY Simbolo DESC
GO


CREATE PROCEDURE sp_UnidadeConsumo_buscar
	@textobusca VARCHAR(50)
AS 
	SELECT * FROM UnidadeConsumo WHERE Simbolo LIKE @textobusca + '%'
GO

