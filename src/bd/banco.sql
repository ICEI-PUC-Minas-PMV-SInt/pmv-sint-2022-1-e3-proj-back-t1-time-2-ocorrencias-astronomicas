USE [app_web_backend]
GO

/****** Object: Table [dbo].[Dados] Script Date: 03/04/2022 17:13:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Dados] (
    [Id]    NVARCHAR (450) NOT NULL,
    [Nome]  NVARCHAR (MAX) NOT NULL,
    [Email] NVARCHAR (MAX) NOT NULL,
    [Senha] NVARCHAR (MAX) NOT NULL,
    [CEP]   INT            NOT NULL
);


