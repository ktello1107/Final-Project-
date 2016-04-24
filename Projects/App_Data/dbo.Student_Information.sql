CREATE TABLE [dbo].[Student_Information] (
    [RollNo]     INT           NOT NULL,
    [Name]       TEXT NULL,
    [Department] TEXT NULL,
    [DOB]        DATE NULL,
    [Address]    TEXT NULL,
    [MNo]        NTEXT           NULL,
    [EID]        TEXT NULL,
    [Notes]      TEXT NULL,
    PRIMARY KEY CLUSTERED ([RollNo] ASC)
);

