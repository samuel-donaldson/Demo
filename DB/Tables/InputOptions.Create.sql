-- InputOptions Table ========================
CREATE TABLE InputOptions (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [Input] uniqueidentifier  NOT NULL,
    [Value] nvarchar(200)  NULL
);
CREATE INDEX [IX_InputOptions->Input] ON InputOptions ([Input]);

GO

