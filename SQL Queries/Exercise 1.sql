--Mostrar el salario mínimo, máximo y promedio por cada departamento.

SELECT Departamento.Nombre AS 'Departamento',
	   MIN(Empleado.Salario) AS 'Mínimo',
	   MAX(Empleado.Salario) AS 'Máximo',
	   CAST(AVG(Empleado.Salario) AS DECIMAL(10, 2)) AS 'Promedio'
  FROM Empleados AS Empleado
 INNER
  JOIN Departamentos AS Departamento 
    ON Empleado.DepartamentoId = Departamento.Id
 GROUP
	BY Departamento.Nombre;
