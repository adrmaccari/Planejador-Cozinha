UPDATE Insumo
SET Insumo.PrecoPadrao = FT.PrecoTotal,
	Insumo.NutriCaloria = FT.TotalCalorias,
	Insumo.NutriProteina = FT.TotalProteinas,
	Insumo.NutriLipidio = FT.TotalLipidios,
	Insumo.NutriSodio = FT.TotalSodio,
	Insumo.NutriFibra = FT.TotalFibras,
	Insumo.NutriCarb = FT.TotalCarb
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
        WHERE ItemReceita.IdPreparo = 13 AND ItemReceita.IdInsumo=Insumo.IdInsumo
        GROUP BY ItemReceita.IdPreparo
    ) AS FT
    ON Insumo.IdInsumo = FT.IdPreparo
WHERE Insumo.IdInsumo = 13





