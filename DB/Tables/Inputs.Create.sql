-- Inputs Table ========================
CREATE TABLE Inputs (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [Order] int  NOT NULL,
    Test uniqueidentifier  NOT NULL,
    [Group] uniqueidentifier  NULL,
    Title nvarchar(200)  NOT NULL,
    Description nvarchar(200)  NULL,
    Mandatory bit  NOT NULL,
    Type uniqueidentifier  NOT NULL
);
CREATE INDEX [IX_Inputs->Test] ON Inputs (Test);

GO

