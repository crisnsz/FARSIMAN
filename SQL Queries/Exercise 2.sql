--Listar los departamentos que tienen 3 o más empleados.

  WITH NoEmpleados AS (
		SELECT DepartamentoId, 
			   COUNT(*) AS 'No. Empleados'
		  FROM Empleados
		 GROUP
		    BY DepartamentoId
	)
SELECT Departamento.Nombre AS 'Departamento',
       NoEmpleados.[No. Empleados]
  FROM Departamentos AS Departamento
  JOIN NoEmpleados ON Departamento.Id = NoEmpleados.DepartamentoId
 WHERE NoEmpleados.[No. Empleados] >= 3;
