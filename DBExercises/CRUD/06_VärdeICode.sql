-- 6. Beräkna värdet i 'Code' från RGB-värdena
-- Kopiera tabellen Colors till Colors2, men skippa kolumnen ”Code”. 
-- Gör sedan en select från Colors2 som ger samma resultat som du 
-- skulle fått från select * from Colors; (Dvs, återskapa den saknade 
-- kolumnen från RGBvärdena i resultatet).

--select * from Colors

SELECT
	 Red,
	 Green,
	 Blue,
	 '#' + 
	 RIGHT('0' + CONVERT(nvarchar(8), CONVERT(varbinary(1), Red), 2), 2) +
	 RIGHT('0' + CONVERT(nvarchar(8), CONVERT(varbinary(1), Green), 2), 2) +
	 RIGHT('0' + CONVERT(nvarchar(8), CONVERT(varbinary(1), Blue), 2), 2) as HexValue
FROM
	Colors