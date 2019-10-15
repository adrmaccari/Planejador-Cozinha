
CREATE PROCEDURE sp_Insumos_criar_preparo
	@IdInsumo INT=NULL,
	@Nome		VARCHAR(100),
	@Descricao	VARCHAR(256) ,
	@FeitoComprado CHAR(1),
	@PesoUnitario DECIMAL (10,4),
	@IdUnidadeConsumo INT,
	@RendimentoReceita DECIMAL(19,4)

AS
	INSERT INTO Insumo (Nome, Descricao, FeitoComprado,  PesoUnitario, IdUnidadeConsumo)
	VALUES (@Nome, @Descricao, @FeitoComprado, @PesoUnitario, @IdUnidadeConsumo)
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


CREATE PROCEDURE sp_Insumos_atualizar_totaisFT
	@IdPreparo INT,
	@Rendimento DECIMAL(10,4)=0.0
AS
	
	SELECT @Rendimento = RendimentoReceita 
	FROM Insumo INNER JOIN Preparo ON Preparo.IdInsumo=Insumo.IdInsumo AND Preparo.IdInsumo=@IdPreparo
	IF @Rendimento = 0.0
	BEGIN
		SET @Rendimento = 1.0
	END

	UPDATE Insumo
	SET Insumo.PrecoPadrao = FT.PrecoTotal/@Rendimento,
		Insumo.NutriCaloria = FT.TotalCalorias/@Rendimento,
		Insumo.NutriProteina = FT.TotalProteinas/@Rendimento,
		Insumo.NutriLipidio = FT.TotalLipidios/@Rendimento,
		Insumo.NutriSodio = FT.TotalSodio/@Rendimento,
		Insumo.NutriFibra = FT.TotalFibras/@Rendimento,
		Insumo.NutriCarb = FT.TotalCarb/@Rendimento
	FROM Insumo 
	INNER JOIN
		(
			SELECT 
				ItemReceita.IdPreparo,SUM(Insumo.PrecoPadrao * Quantidade) PrecoTotal,
				SUM (Insumo.NutriCaloria * Quantidade * PesoUnitario) TotalCalorias,
				SUM (Insumo.NutriProteina * Quantidade * PesoUnitario) TotalProteinas,
				SUM (Insumo.NutriLipidio * Quantidade * PesoUnitario) TotalLipidios,
				SUM (Insumo.NutriSodio * Quantidade * PesoUnitario) TotalSodio,
				SUM (Insumo.NutriFibra * Quantidade * PesoUnitario) TotalFibras,
				SUM (Insumo.NutriCarb * Quantidade * PesoUnitario) TotalCarb

			FROM ItemReceita,Insumo
			WHERE ItemReceita.IdPreparo = @IdPreparo AND ItemReceita.IdInsumo=Insumo.IdInsumo
			GROUP BY ItemReceita.IdPreparo
		) AS FT
		ON Insumo.IdInsumo = FT.IdPreparo
	WHERE Insumo.IdInsumo = @IdPreparo
GO



