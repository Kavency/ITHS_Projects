-- 3. Uppdatera airports
-- Uppdatera (kopia på) tabellen airports så att alla
-- null-värden i kolumnerna Time och DST byts ut mot ’-’

select * from Airports

update Airports
set Time = isnull(Time, '-'), DST = isnull(DST, '-')
