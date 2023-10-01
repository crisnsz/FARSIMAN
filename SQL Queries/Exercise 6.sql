--Listar los empleados de cada departamento, agregando una columna que muestre el número de línea agrupado por cada departamento.

SELECT ROW_NUMBER() OVER (PARTITION BY Empleado.DepartamentoId ORDER BY Empleado.Nombre) AS 'Numero',
	   Empleado.Nombre AS 'Nombre',
	   Departamento.Nombre AS 'Departamento'
  FROM Empleados AS Empleado
 INNER 
  JOIN Departamentos AS Departamento
	ON Empleado.DepartamentoId = Departamento.Id
 ORDER 
	BY Departamento.Nombre, 
	   Empleado.Nombre;
