CREATE TABLE [dbo].[LISTA] (
    [Id]    INT IDENTITY (1, 1) NOT NULL,
    [nome]  VARCHAR (62) NULL,
    [idade] SMALLINT     NOT NULL,
    [email] VARCHAR (62) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

