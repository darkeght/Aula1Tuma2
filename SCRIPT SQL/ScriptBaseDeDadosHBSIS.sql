CREATE DATABASE BaseDeDadosHBSIS;
USE BaseDeDadosHBSIS;
CREATE TABLE [dbo].[Tipos] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Codigo] INT           NULL,
    [Nome]   NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Marcas] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Codigo]     INT           NULL,
    [Nome]       NVARCHAR (20) NULL,
    [TipoCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Veiculos] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descricao]   NVARCHAR (30) NULL,
    [MarcaCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
/*Insert das informações de tipo*/
INSERT INTO Tipos (Codigo,Nome) values (1,'Carro');
INSERT INTO Tipos (Codigo,Nome) values (2,'Moto');
/*Insert das informações de Marcas*/
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (1,'BMW',1);
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (2,'BMW',2);
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (3,'KIA',1);
INSERT INTO Marcas (Codigo,Nome,TipoCodigo) values (4,'KAWASAKI',2);
/*Insert das informações de Veiculos*/
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('M6',1);
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('R 1200',2);
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Besta',3);
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Sportage',3);
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Z 1000',4);
INSERT INTO Veiculos (Descricao,MarcaCodigo) values ('Z 900',4);

SELECT tip.Tipo, mar.Nome 'Marca', vei.Descricao 'Veículo' FROM Veiculos vei 
		inner join Marcas mar on vei.MarcaCodigo = mar.Codigo
		inner join Tipos tip on mar.TipoCodigo = tip.Codigo	
		WHERE mar.Codigo = 4 
