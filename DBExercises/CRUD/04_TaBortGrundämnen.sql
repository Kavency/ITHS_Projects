-- 4. Ta bort grundämnen
-- Ta bort de rader från (kopia på) tabellen Elements där ”Name” är 
-- någon av följande: 'Erbium', 'Helium', 'Nitrogen', 'Platinum', 
-- 'Selenium', samt alla rader där ”Name” börjar på någon av bokstäverna d, k, m, o, eller u.

select * from Elements

delete from 
	Elements 
where 
	name in ('Erbium', 'Helium', 'Nitrogen', 'Platinum', 'Selenium') or
	name like 'D%' or
	name like 'K%' or
	name like 'M%' or
	name like 'O%' or
	name like 'U%'
