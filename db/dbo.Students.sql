CREATE TABLE [dbo].[Students] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [IndexNumber]  INT          NOT NULL,
    [DepartmentId] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Department] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments] ([Id])
);

