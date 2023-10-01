--Mostrar una lista de los empleados, 
--ordenándolos primero por los que pertenecen al departamento de Mercadeo, 
--y luego por ordenados por el nombre del departamento y nombre del empleado.

SELECT Empleado.Nombre AS 'Colaborador',
	   Departamento.Nombre AS 'Departamento',
	   (CASE WHEN Departamento.Nombre = 'Mercadeo' 
			 THEN 1
			 ELSE 2
		END) AS 'Orden'
  FROM Empleados AS Empleado
 INNER
  JOIN Departamentos AS Departamento ON Empleado.DepartamentoId = Departamento.Id
 ORDER 
	BY Orden,
	   Departamento.Nombre,
	   Empleado.Nombre;
