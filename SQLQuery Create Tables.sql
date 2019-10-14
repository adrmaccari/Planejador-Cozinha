CREATE TABLE UnidadeConsumo(
IdunidadeConsumo	INT IDENTITY PRIMARY KEY ,
Simbolo		VARCHAR(02) NOT NULL ,
Descricao	VARCHAR(100) 
)

CREATE TABLE TipoInsumo(
IdTipoInsumo	INT IDENTITY PRIMARY KEY ,
Tipo		VARCHAR(20) NOT NULL ,
Descricao	VARCHAR(100) 
)

CREATE TABLE Insumo(
IdInsumo	INT	IDENTITY PRIMARY KEY  ,
Nome		VARCHAR(100) NOT NULL ,
Descricao	VARCHAR(256) ,
FeitoComprado CHAR(1) NOT NULL ,
PrecoPadrao DECIMAL(19,4),
PesoUnitario DECIMAL (10,4),
NutriCaloria DECIMAL(10,4),
NutriSodio DECIMAL(10,4),
NutriProteina DECIMAL(10,4),
NutriLipidio DECIMAL(10,4),
NutriFibra DECIMAL(10,4),
NutriCarb DECIMAL(10,4),
IdUnidadeConsumo	INT NOT NULL REFERENCES UnidadeConsumo (IdUnidadeConsumo)
)

CREATE TABLE Comprado(
IdInsumo INT PRIMARY KEY NOT NULL,
IdTipoInsumo	INT NOT NULL REFERENCES Tipoinsumo(IdTipoInsumo) ,
CONSTRAINT Pk_ExtPrimaryKey FOREIGN KEY (IdInsumo) REFERENCES Insumo

)


CREATE TABLE Preparo(
IdInsumo INT PRIMARY KEY NOT NULL,
RendimentoReceita DECIMAL(10,4),
CONSTRAINT Pk_ExternInsumo FOREIGN KEY(IdInsumo) REFERENCES Insumo
)


CREATE TABLE ItemReceita(
IdPreparo INT NOT NULL,
IdInsumo INT NOT NULL,
Quantidade DECIMAL(10,4),
CONSTRAINT Pk_PreparoInsumo PRIMARY KEY (IdPreparo,IdInsumo),
CONSTRAINT Pk_Parent FOREIGN KEY (IdPreparo) REFERENCES Preparo,
CONSTRAINT Pk_Child FOREIGN KEY (IdInsumo) REFERENCES Insumo
)
