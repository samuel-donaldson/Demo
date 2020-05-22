ALTER TABLE InputGroups ADD Constraint
                [FK_InputGroup.Test->TestRecord]
                FOREIGN KEY (Test)
                REFERENCES TestRecords (ID)
                ON DELETE NO ACTION;
GO