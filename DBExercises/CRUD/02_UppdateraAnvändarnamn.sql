-- 2. Uppdatera användarnamn
-- Uppdatera (kopia på) tabellen user och sätt username för alla användare så den 
-- blir de 2 första bokstäverna i förnamnet, och de 2 första i efternamnet 
-- (istället för 3+3 som det är i orginalet). Hela användarnamnet ska vara i små bokstäver.

select * from Users

use everyloop
update Users
	set UserName = lower(substring(FirstName, 1, 2) + substring(LastName, 1,2))


