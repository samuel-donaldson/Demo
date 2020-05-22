-- TestRecords Table ========================
CREATE TABLE TestRecords (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    Title nvarchar(200)  NOT NULL,
    TestDescription nvarchar(MAX)  NULL,
    TestNumber nvarchar(200)  NOT NULL,
    [Procedure] nvarchar(200)  NULL
);

