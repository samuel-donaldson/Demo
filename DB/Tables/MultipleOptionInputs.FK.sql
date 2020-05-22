ALTER TABLE MultipleOptionInputs ADD CONSTRAINT 
[FK_MultipleOptionInput.Id->Input] FOREIGN KEY (Id) 
REFERENCES Inputs (ID)
 ON DELETE CASCADE;


GO