ALTER TABLE DynamicInputFields ADD Constraint
                [FK_DynamicInputField.Input->DynamicInput]
                FOREIGN KEY ([Input])
                REFERENCES DynamicInputs (ID)
                ON DELETE NO ACTION;
GO