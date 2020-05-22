ALTER TABLE InputOptions ADD Constraint
                [FK_InputOption.Input->MultipleOptionInput]
                FOREIGN KEY ([Input])
                REFERENCES MultipleOptionInputs (ID)
                ON DELETE NO ACTION;
GO