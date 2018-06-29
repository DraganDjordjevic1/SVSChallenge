/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


if '$(LoadTestData)' = 'true'
BEGIN

DELETE FROM Treatment
DELETE FROM [Procedure]
DELETE FROM Pet
DELETE FROM [Owner]


INSERT INTO [Owner](OwnerID, GivenName, Surname, Phone) VALUES
(1, 'Frank', 'Sinatra', 400111222),
(2, 'Duke','Ellington',  400222333),
(3, 'Ella', 'Fitzgerald', 400333444);

INSERT INTO Pet(PetName, [Type], OwnerID) VALUES
('Buster', 'Dog', 1),
('Fluffy', 'Cat', 1),
('Stew', 'Rabbit', 2),
('Buster', 'Dog', 3),
('Pooper', 'Dog', 3);

INSERT INTO [Procedure](ProcedureID, [Description], ProcedurePrice) VALUES
(01, 'Rabies Vaccination', $24.00),
(10, 'Examine and Treat Wound', $30.00),
(05, 'Heart Worm Test', $25.00),
(08, 'Tetnus Vaccination', $17.00);

INSERT INTO Treatment(PetName, OwnerID, ProcedureID, Notes, TreatmentPrice, TreatmentDate) VALUES
(
'Buster', 1, 01, 'Routine Vaccination', $22.00,
CONVERT(DATETIME, '06/20/2017', 101)
),

(
'Buster', 1, 01, 'Booster Shot', $24.00,
CONVERT(DATETIME, '05/15/2018', 101)
),

(
'Fluffy', 1, 10, 'Wounds sustained in apparent cat fight', $30.00,
CONVERT(DATETIME, '05/10/2018', 101)
),

(
'Stew', 2, 10, 'Wounds sustained during attempt to cook the stew.', $30.00,
CONVERT(DATETIME, '05/10/2018', 101)
),

(
'Pooper', 3, 05, 'Routine Test', $25.00,
CONVERT(DATETIME, '05/18/2018', 101)
);

END;