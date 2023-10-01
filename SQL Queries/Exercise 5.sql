--Listar los 2 empleados con mayor salario de cada departamento.

SELECT Empleado.Nombre AS 'Empleado',
	   Empleado.Salario AS 'Salario',
	   Departamento.Nombre AS 'Departamento'
  FROM (SELECT *,
               RANK () OVER (PARTITION BY DepartamentoId ORDER BY Salario DESC) AS 'Puesto'
          FROM Empleados) AS Empleado
 INNER 
  JOIN Departamentos AS Departamento
	ON Empleado.DepartamentoId = Departamento.Id
 WHERE Empleado.Puesto <= 2
 ORDER
	BY Departamento.Nombre