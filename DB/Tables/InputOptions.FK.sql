ALTER TABLE InputOptions ADD Constraint
                [FK_InputOption.Input->MultipleOptionsInput]
                FOREIGN KEY ([Input])
                REFERENCES MultipleOptionsInputs (ID)
                ON DELETE NO ACTION;
GO