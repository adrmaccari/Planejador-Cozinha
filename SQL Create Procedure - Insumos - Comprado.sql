
CREATE PROCEDURE sp_Insumos_criar_comprado
	@IdInsumo INT=NULL,
	@Nome		VARCHAR(100),
	@Descricao	VARCHAR(256) ,
	@FeitoComprado CHAR(1),
	@PrecoPadrao DECIMAL(19,4),
	@IdUnidadeConsumo INT,
	@IdTipoInsumo INT

AS
	INSERT INTO Insumo (Nome, Descricao, FeitoComprado, PrecoPadrao, IdUnidadeConsumo)
	VALUES (@Nome, @Descricao, @FeitoComprado, @PrecoPadrao, @IdUnidadeConsumo)
	SET @IdInsumo = SCOPE_IDENTITY()

	INSERT INTO Comprado (IdInsumo,IdTipoInsumo)
	VALUES(@IdInsumo,@IdTipoInsumo)
GO

CREATE PROCEDURE sp_Insumos_excluir
	@IdInsumo INT
AS
	DELETE FROM Comprado where IdInsumo = @IdInsumo
	DELETE FROM Preparo where IdInsumo =@IdInsumo
	DELETE FROM Insumo WHERE IdInsumo = @IdInsumo
GO

CREATE PROCEDURE sp_Insumos_editar_comprado
	@IdInsumo	INT,
	@Nome		VARCHAR(100),
	@Descricao	VARCHAR(256) ,
	@FeitoComprado CHAR(1),
	@PrecoPadrao DECIMAL(19,4),
	@IdTipoInsumo INT,
	@IdUnidadeConsumo INT   	  
AS
	UPDATE Insumo
	SET 
		Nome=			@Nome,
		Descricao=		@Descricao, 
		FeitoComprado=	@FeitoComprado,
		PrecoPadrao=	@PrecoPadrao, 
		IdUnidadeConsumo=@IdUnidadeConsumo
	WHERE IdInsumo = @IdInsumo

	UPDATE Comprado
	SET 
		IdTipoInsumo=	@IdTipoInsumo
	WHERE IdInsumo = @IdInsumo
GO

CREATE PROCEDURE sp_Insumos_mostrar_comprado
AS
	SELECT TOP 200 * FROM Insumo,Comprado,UnidadeConsumo,TipoInsumo
	where Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo AND Insumo.IdTipoInsumo=TipoInsumo.IdTipoinsumo AND Insumo.IdInsumo=Comprado.IdInsumo
	ORDER BY Insumo.Nome DESC
GO


CREATE PROCEDURE sp_Insumos_buscar_nome_comprado
	@textobusca VARCHAR(100)
AS 
	SELECT * FROM Insumo, Comprado, TipoInsumo, UnidadeConsumo 
	WHERE Insumo.Nome LIKE @textobusca + '%' 
		AND Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo 
		AND Comprado.IdTipoInsumo=TipoInsumo.IdTipoinsumo
		AND Insumo.IdInsumo=Comprado.IdInsumo
GO


CREATE PROCEDURE sp_Insumos_buscar_id_comprado
	@IdInsumo INT
AS 
	SELECT * FROM Insumo 
	INNER JOIN Comprado ON Insumo.IdInsumo=Comprado.IdInsumo
	INNER JOIN TipoInsumo ON TipoInsumo.IdTipoInsumo=Comprado.IdTipoInsumo
	INNER JOIN UnidadeConsumo ON Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo;
GO

CREATE PROCEDURE sp_Insumos_buscar_tipoinsumo
	@textobusca VARCHAR(100)
AS 
	SELECT Insumo.IdInsumo,Insumo.Nome FROM Insumo,Comprado , TipoInsumo
	WHERE TipoInsumo.Tipo LIKE @textobusca + '%' 
		AND Comprado.IdTipoInsumo=TipoInsumo.IdTipoInsumo
		AND Insumo.IdInsumo=Comprado.IdInsumo
GO


CREATE PROCEDURE sp_TiposInsumo_mostrar
AS
	SELECT * FROM TipoInsumo
		ORDER BY Tipo 
GO
