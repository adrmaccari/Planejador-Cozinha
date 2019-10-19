CREATE PROCEDURE sp_tabelanutricional_incluir
	@Nome VARCHAR(100) ,
	@Fonte CHAR(1),
	@FonteDetalhe VARCHAR(100),
	@Observacao VARCHAR (250),
	@PesoAmostra DECIMAL(10,4),
	@Caloria DECIMAL(10,4),
	@Proteina DECIMAL(10,4),
	@Lipidio DECIMAL(10,4),
	@Fibra DECIMAL(10,4),
	@Sodio DECIMAL(10,4),
	@Carb DECIMAL(10,4)
AS
	INSERT INTO TabelaNutricional (Nome,Fonte,FonteDetalhe,Observacao,PesoAmostra,Caloria,Proteina,Lipidio,Fibra,Sodio,Carb )
	VALUES (@Nome, @Fonte, @FonteDetalhe, @Observacao, @PesoAmostra, @Caloria, @Proteina, @Lipidio, @Fibra, @Sodio, @Carb )
GO


CREATE PROCEDURE sp_tabelanutricional_editar
	@IdTabelaNutricional INT ,
	@Nome VARCHAR(100) ,
	@Fonte CHAR(1),
	@FonteDetalhe VARCHAR(100),
	@Observacao VARCHAR (250),
	@PesoAmostra DECIMAL(10,4),
	@Caloria DECIMAL(10,4),
	@Proteina DECIMAL(10,4),
	@Lipidio DECIMAL(10,4),
	@Fibra DECIMAL(10,4),
	@Sodio DECIMAL(10,4),
	@Carb DECIMAL(10,4)
AS
	UPDATE TabelaNutricional 
	SET 
		Nome = @Nome, 
		Fonte = @Fonte, 
		FonteDetalhe = @FonteDetalhe, 
		Observacao = @Observacao,
		PesoAmostra = @PesoAmostra, 
		Caloria = @Caloria, 
		Proteina = @Proteina, 
		Lipidio = @Lipidio, 
		Fibra = @Fibra, 
		Sodio = @Sodio,
		Carb = @Carb
	WHERE IdTabelaNutricional = @IdTabelaNutricional
GO

CREATE PROCEDURE sp_tabelanutricional_excluir
	@IdTabelaNutricional INT
AS
	DELETE FROM TabelaNutricional WHERE IdTabelaNutricional = @IdTabelaNutricional
GO

CREATE PROCEDURE sp_tabelanutricional_buscar_nome
	@Nome VARCHAR (100)
AS
	SELECT * 
	FROM TabelaNutricional 
	WHERE Nome LIKE '%' + @Nome + '%'
GO


CREATE PROCEDURE sp_tabelanutricional_buscar_id
	@IdTabelaNutricional INT
AS
	SELECT * 
	FROM TabelaNutricional 
	WHERE IdTabelaNutricional = @IdTabelaNutricional
GO