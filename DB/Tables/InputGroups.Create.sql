-- InputGroups Table ========================
CREATE TABLE InputGroups (
    Id uniqueidentifier PRIMARY KEY NONCLUSTERED,
    [Order] int  NOT NULL,
    Test uniqueidentifier  NOT NULL,
    Name nvarchar(200)  NOT NULL
);

