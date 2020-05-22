ALTER TABLE MultipleOptionsInputs ADD CONSTRAINT 
[FK_MultipleOptionsInput.Id->Input] FOREIGN KEY (Id) 
REFERENCES Inputs (ID)
 ON DELETE CASCADE;


GO