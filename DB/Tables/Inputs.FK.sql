ALTER TABLE Inputs ADD Constraint
                [FK_Input.Test->TestRecord]
                FOREIGN KEY (Test)
                REFERENCES TestRecords (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE Inputs ADD Constraint
                [FK_Input.Group->InputGroup]
                FOREIGN KEY ([Group])
                REFERENCES InputGroups (ID)
                ON DELETE NO ACTION;
GO
ALTER TABLE Inputs ADD Constraint
                [FK_Input.Type->InputDataType]
                FOREIGN KEY (Type)
                REFERENCES InputDataTypes (ID)
                ON DELETE NO ACTION;
GO