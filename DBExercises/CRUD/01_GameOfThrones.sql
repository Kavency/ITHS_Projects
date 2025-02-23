--1. Game of thrones
--Ta ut data (select) från tabellen GameOfThrones på sådant sätt att ni får ut en kolumn
--’Title’ med titeln samt en kolumn ’Episode’ som visar episoder och säsonger i formatet
--”S01E01”, ”S01E02”, osv. Tips: kolla upp funktionen format(

use everyloop
select
	title, Season, EpisodeInSeason,
	'S' + format(Season, '00') + 'E' + format(EpisodeInSeason, '00') as 'New Episode'
from
	GameOfThrones