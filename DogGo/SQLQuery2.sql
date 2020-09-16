--SELECT d.Name, d.OwnerId FROM Dog d WHERE d.OwnerId IN (SELECT O.Id FROM Owner O WHERE o.ID = 1);
--SELECT * FROM DOG;

--SELECT d.Name, d.OwnerId FROM Dog d WHERE d.OwnerId = 1;

--SELECT d.Name FROM Dog d INNER JOIN Owner o on d.OwnerId = 1;

--SELECT o.Name, d.Name FROM Owner o left JOIN Dog d on o.id = d.id;

SELECT * FROM Owner;
