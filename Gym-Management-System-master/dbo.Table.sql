CREATE TABLE [dbo].[Table] (
    [ID]      INT           NOT NULL,
    [Name]    CHAR (10)     NOT NULL,
    [Address] CHAR (10)     NOT NULL,
    [Age]     INT           NOT NULL,
    [Phone]   NVARCHAR (50) NOT NULL,
    [Gender]  CHAR (10)     NOT NULL,
    [fee] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([ID] ASC),
    UNIQUE NONCLUSTERED ([Phone] ASC)
);

