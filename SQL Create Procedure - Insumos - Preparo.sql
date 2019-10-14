
CREATE PROCEDURE sp_Insumos_criar_preparo
	@IdInsumo INT=NULL,
	@Nome		VARCHAR(100),
	@Descricao	VARCHAR(256) ,
	@FeitoComprado CHAR(1),
	@PrecoPadrao DECIMAL(19,4),
	@PesoUnitario DECIMAL (10,4),
	@IdUnidadeConsumo INT,
	@RendimentoReceita DECIMAL(19,4)

AS
	INSERT INTO Insumo (Nome, Descricao, FeitoComprado, PrecoPadrao, PesoUnitario, IdUnidadeConsumo)
	VALUES (@Nome, @Descricao, @FeitoComprado, @PrecoPadrao,@PesoUnitario, @IdUnidadeConsumo)
	SET @IdInsumo = SCOPE_IDENTITY()

	INSERT INTO Preparo(IdInsumo,RendimentoReceita)
	VALUES(@IdInsumo,@RendimentoReceita)
GO

CREATE PROCEDURE sp_Insumos_editar_preparo
	@IdInsumo	INT,
	@Nome		VARCHAR(100),
	@Descricao	VARCHAR(256) ,
	@FeitoComprado CHAR(1),
	@PesoUnitario DECIMAL (10,4),
	@RendimentoReceita DECIMAL(19,4),
	@IdUnidadeConsumo INT
AS
	UPDATE Insumo
	SET 
		Nome=			@Nome,
		Descricao=		@Descricao, 
		FeitoComprado=	@FeitoComprado,
		PesoUnitario=	@PesoUnitario,
		IdUnidadeConsumo=@IdUnidadeConsumo
	WHERE IdInsumo = @IdInsumo

	UPDATE Preparo
	SET 
		RendimentoReceita=	@RendimentoReceita
	WHERE IdInsumo = @IdInsumo
GO

CREATE PROCEDURE sp_Insumos_mostrar_preparo
AS
	SELECT TOP 200 * FROM Insumo,Preparo,UnidadeConsumo
	where Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo AND Insumo.IdInsumo=Preparo.IdInsumo
	ORDER BY Insumo.Nome DESC
GO


CREATE PROCEDURE sp_Insumos_buscar_nome_preparo
	@textobusca VARCHAR(100)
AS 
	SELECT * FROM Insumo, Preparo, UnidadeConsumo 
	WHERE Insumo.Nome LIKE @textobusca + '%' 
		AND Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo 
		AND Insumo.IdInsumo=Preparo.IdInsumo
GO


CREATE PROCEDURE sp_Insumos_buscar_id_preparo
	@IdInsumo INT
AS 
	SELECT * FROM Insumo 
	INNER JOIN Preparo ON Insumo.IdInsumo=Preparo.IdInsumo AND Insumo.IdInsumo=@IdInsumo
	INNER JOIN UnidadeConsumo ON Insumo.IdUnidadeConsumo=UnidadeConsumo.IdunidadeConsumo;
GO

