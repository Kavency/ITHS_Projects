select * from NewUsers;

BEGIN TRANSACTION; -- Starta 'loggning' av ändringar.

update -- Gör någon ändring av tabeller.
	NewUsers
SET
	UserName = '---' WHERE FirstName LIKE 'a%';

ROLLBACK; -- Händer det något oönskat så rullar man tillbaka.

COMMIT; -- Allt har gått bra till och ändringar sparas först när commit körs.