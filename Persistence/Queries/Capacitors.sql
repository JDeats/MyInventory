SELECT *
FROM Capacitors c
INNER JOIN ElectronicComponents ec ON c.Id = ec.Id
INNER JOIN Items i ON ec.Id = i.Id
