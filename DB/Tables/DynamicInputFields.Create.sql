-- DynamicInputFields Table ========================
CREATE TABLE DynamicInputFields (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [Order] int  NOT NULL,
    Name nvarchar(200)  NOT NULL,
    [Input] uniqueidentifier  NULL,
    [Group] nvarchar(200)  NULL
);
CREATE INDEX [IX_DynamicInputFields->Input] ON DynamicInputFields ([Input]);

GO

