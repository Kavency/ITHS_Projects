-- 5. Sammanställ data för olika regioner
-- Ta ut en lista över regioner i tabellen ”Countries” där det för varje region 
-- framgår regionens namn, antal länder i regionen, totalt antal invånare, total 
-- area, befolkningstätheten med 2 decimaler, samt spädbarnsdödligheten per 100.000 
-- födslar avrundat till heltal.

SELECT
	[Region],
	count(*) AS 'Number of countries',
	sum(cast(Population AS float)) AS 'Inhabitants',
	sum(cast([Area (sq# mi#)] AS bigint)) AS 'Total area',
	format(avg(cast(replace([Pop# Density (per sq# mi#)], ',', '.') as float)), 'N2') AS 'Population density'
FROM
	[Countries]


GROUP BY
	[Region]