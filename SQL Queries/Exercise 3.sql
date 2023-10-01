--Mostrar los colaboradores que tienen al menos 1 año de haber ingresado, indicando en una columna los meses que tienen de haber ingresado. 
 
 WITH Empleado AS (
		SELECT Nombre AS 'Colaborador',
		       DATEDIFF(MONTH, FechaIngreso, GETDATE()) AS 'Meses'
		  FROM Empleados
	)
SELECT *
  FROM Empleado
 WHERE Meses >= 12
 ORDER
    BY Meses;