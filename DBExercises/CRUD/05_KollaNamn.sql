-- 5. Kolla om namnet börjar med bokstäverna i 'Symbol'
-- Skapa en ny tabell med alla rader från tabellen Elements. Den nya tabellen ska 
-- innehålla ”Symbol” och ”Name” från orginalet, samt en tredje kolumn med värdet
-- ’Yes’ för de rader där ”Name” börjar med bokstäverna i ”Symbol”, och ’No’ för 
-- de rader där de inte gör det.

select * from NewElements

--create table NewElements
--(
--	Symbol nvarchar(max),
--	Name nvarchar(max),
--	YesNo nvarchar(max)
--)

--insert into NewElements (Symbol, Name)
--select Symbol, Name
--from Elements;


UPDATE 
	NewElements 
SET 
	YesNo = 
CASE 
	WHEN LEFT(Symbol, 1) = LEFT(Name, 1) and SUBSTRING(Symbol, 2, 1) = SUBSTRING(Name, 2,1) THEN 'Yes' ELSE 'No'
END;