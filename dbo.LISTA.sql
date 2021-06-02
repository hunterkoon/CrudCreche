CREATE TABLE [dbo].[LISTA] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [nome]  VARCHAR (62) NOT NULL,
	[nome_responsavel]  VARCHAR (62) NOT NULL,
    [idade] SMALLINT     NOT NULL,
    [email] VARCHAR (62) NOT NULL,
	[telefone] VARCHAR (62) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

