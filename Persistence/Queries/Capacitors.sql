SELECT *
FROM Capacitors c
INNER JOIN ElectronicComponent ec ON c.Id = ec.Id
INNER JOIN Item i ON ec.Id = i.Id
